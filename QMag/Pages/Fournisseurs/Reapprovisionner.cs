using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controls;
using Core;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Controls;
using QMag.Core;
using QMag.Fenetres;

namespace QMag.Pages.Fournisseurs
{
	public partial class Reapprovisionner : ThemePanel
	{
		private UseGridView _useGridView;
		private readonly Image _imageSupprimer = Image.FromFile("Ressources/Images/supprimer.png");
		private readonly Image _imageEditer = Image.FromFile("Ressources/Images/editer.png");

		private List<ArticleEnregistrement> _articles;
		private readonly List<int> _associeDbetDgv = new List<int>(); // l'ordre de la liste sera le même que dans _articles

		private bool _modeEdition = false;

		public Reapprovisionner()
		{
			InitializeComponent();

			GetBdData();

			flatLabelFournisseur.ForeColor = flatLabelArticle.ForeColor = flatLabelQuantite.ForeColor = flatLabelTotal.ForeColor = flatLabelTotalMontant.ForeColor = Theme.BackDark;
		}

		private void Reapprovisionner_Load(object sender, EventArgs e)
		{
			SetColonnes();

			flatDataGridView.AddClickMethod(EffetClic); // s'inscrit aux event de clic dans la dgv

			flatDataGridView.DataSource = _useGridView.Liens; // ajout(liage) des colonnes à la gridview

			if(flatDataGridView.Rows.Count > 0)
				flatDataGridView.Column["Supprimer"].Width = 200;
		}

		// appelé lors du clic sur la dgv
		private void EffetClic(object sender, DataGridViewCellMouseEventArgs e)
		{
			int colonne = e.ColumnIndex;
			int ligne = e.RowIndex;

			int colonneNom = 0;
			int colonneQuantite = 1;

			if (colonne == flatDataGridView.Column["Editer"]?.DisplayIndex) // si la colonne cliquée correspond à l'édition
			{
				flatListBoxArticle.SelectId(_associeDbetDgv[ligne]);
				flatTextBoxQuantite.Text = GetInDataGridView(ligne, colonneQuantite);
				EnableEdit(true);
			}

			else if (colonne == flatDataGridView.Column["Supprimer"]?.DisplayIndex) // si la colonne cliquée correspond à la suppression
			{
				DialogResult question = Dialog.ShowYesNo("Voulez-vous vraiment supprimer l'article " + GetInDataGridView(ligne, colonneNom) + " de la commande ?");
				if (question == DialogResult.Yes)
				{
					flatDataGridView.RemoveRowAt(ligne);
					ActualiseMontant();
				}
			}
		}

		// récupère les données de la bdd et les associe au formulaire
		private void GetBdData()
		{
			List<C_Stock> listeArticles = new G_Stock(Connexion).Lire("id");

			_articles = new List<ArticleEnregistrement>(listeArticles.Count);

			// remplissage listbox articles
			foreach (C_Stock article in listeArticles)
			{
				flatListBoxArticle.Add(article.nom); // ajout à la flatlist

				// ajoute à notre liste arguments
				_articles.Add(
					new ArticleEnregistrement(
						article.id,
						article.nom,
						article.prix_achat
					));
			}

			flatListBoxArticle.SelectId(0); // mets en text de la listbox le premier article

			// remplissage listbox fournisseurs
			List<C_Fournisseurs> listeFournisseurs = new G_Fournisseurs(Connexion).Lire("id");
			foreach (C_Fournisseurs fournisseur in listeFournisseurs)
				flatListBoxFournisseur.Add(fournisseur.nom); // ajout à la flatlist

		}

		//COUCOU MON LOULOU, Ye te Nem!!! <3

		// permet de récupérer le contenu d'une cellule de la dgv
		private string GetInDataGridView(int x, int y)
		{
			return flatDataGridView.Get(new Couple(x, y));
		}

		// initialise les colonnes
		protected void SetColonnes()
		{
			_useGridView = new UseGridView("Article", "Quantité", "Coût unitaire", "Fournisseur");

			flatDataGridView.SetColonnesCliquables(
				_useGridView.CreateImageColumn("Editer", "Supprimer")
			);
		}

		// que faire lorsque l'on ajoute/modifie un item de la liste
		private void Ajouter_Click(object sender, EventArgs e)
		{
			if (!ChampsValides())
				return;

			int id = flatListBoxArticle.IdSelected; // ne convient as à la modification (pas mis à jour vu que simple changement du texte)
			int sommeQuantite = Convert.ToInt32(flatTextBoxQuantite.Text);

			if (_modeEdition) // mode Modifier
			{
				flatDataGridView.UpdateRowAt(
					_associeDbetDgv.IndexOf(id),
					flatListBoxArticle.Text,
					sommeQuantite,
					Money.Round(_articles[id].Prix),
					_imageEditer,
					_imageSupprimer
					);

				EnableEdit(false);
			}
			else // mode Ajouter
			{
				if(!_associeDbetDgv.Contains(id)) // si la dgv ne contient pas déjà le même article
				{
					_useGridView.Add(
						flatListBoxArticle.Text,
						sommeQuantite,
						Money.Round(_articles[id].Prix),
						_imageEditer,
						_imageSupprimer
					);

					_associeDbetDgv.Add(id);
				}
				else // sinon on ajoute les quantités à celles déjà présentes
				{
					sommeQuantite += _articles[id].Quantite;

					flatDataGridView.UpdateRowAt(
						_associeDbetDgv.IndexOf(id),
						flatListBoxArticle.Text,
						sommeQuantite,
						Money.Round(_articles[id].Prix),
						_imageEditer,
						_imageSupprimer
					);
				}
			}

			_articles[id].Quantite = sommeQuantite; // mets à jour la classe arguments

			// Actualisation du label montant
			flatDataGridView.DataSource = _useGridView.Liens; // ajout(liage) des colonnes à la gridview
			ActualiseMontant();
		}

		private void ActualiseMontant()
		{
			Money total = new Money(0);
			int nombreArticles;
			int id;

			for (int i = 0; i < flatDataGridView.Rows.Count; i++)
			{
				id = _associeDbetDgv[i];
				nombreArticles = _articles[id].Quantite;

				total.Montant += Convert.ToDecimal(flatDataGridView.Get(new Couple(i, 2))) * nombreArticles;
			}

			flatLabelTotalMontant.Text = total.ToString();
		}

		// action lors du click sur confirmer
		private void flatButtonConfirmer_Click(object sender, EventArgs e)
		{
			if (flatDataGridView.Rows.Count < 1)
			{
				Dialog.Show("Aucun article à commander !");
				return;
			}

			/*foreach (DataGridViewRowCollection ligne in flatDataGridView.Rows)
			{
				new G_Fournisseurs(Connexion).Modifier(
					_idModification,
					nom
				);
			}*/
		}

		// permet de passer ou quitter le mode édition
		private void EnableEdit(bool state)
		{
			if (state)
			{
				_modeEdition = true;
				flatButtonAjouter.Text = @"Modifier";
			}
			else
			{
				_modeEdition = false;
				flatButtonAjouter.Text = @"Ajouter";
			}
		}

		private bool ChampsValides()
		{
			bool resultat = true;
			string messageErreur = "";

			resultat &= flatListBoxArticle.Text != "" && flatTextBoxQuantite.Text != "";
			if(!resultat)
				messageErreur = "Veuillez remplir tous les champs !";

			resultat &= int.TryParse(flatTextBoxQuantite.Text, out _);
			if (!resultat)
				messageErreur = "Le champs Quantité ne contient pas un nombre !";

			if(!resultat)
				Dialog.Show(messageErreur);

			return resultat;
		}

		private class ArticleEnregistrement
		{
			public ArticleEnregistrement(int id, string nom, decimal prix)
			{
				Id = id;
				Nom = nom;
				Prix = prix;
			}

			public int Id { get; set; }
			public string Nom { get; set; }
			public int Quantite { get; set; }
			public decimal Prix { get; set; }
		}
	}
}
