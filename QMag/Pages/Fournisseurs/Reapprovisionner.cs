using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controls;
using Core;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
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

		private bool _modeEdition = false;

		public Reapprovisionner()
		{
			InitializeComponent();

			GetBdData();

			flatLabelArticle.ForeColor = flatLabelQuantite.ForeColor = flatLabelTotal.ForeColor = flatLabelTotalMontant.ForeColor = Theme.BackDark;
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
				flatListBoxArticle.Text = GetInDataGridView(ligne, colonneNom);
				flatTextBoxQuantite.Text = GetInDataGridView(ligne, colonneQuantite);
				EnableEdit(true);
			}

			else if (colonne == flatDataGridView.Column["Supprimer"]?.DisplayIndex) // si la colonne cliquée correspond à la suppression
			{
				DialogResult question = Dialog.ShowYesNo("Voulez-vous vraiment supprimer l'article " + GetInDataGridView(ligne, colonneNom) + " de la commande ?");
				if (question == DialogResult.Yes)
					flatDataGridView.RemoveRowAt(ligne);
			}
		}

		// récupère les données de la bdd et les associe au formulaire
		private void GetBdData()
		{
			List<C_Stock> liste = new G_Stock(Connexion).Lire("id");

			_articles = new List<ArticleEnregistrement>(liste.Count);

			foreach (C_Stock article in liste)
			{
				flatListBoxArticle.Add(article.nom); // ajout à la flatlist

				_articles.Add(
					new ArticleEnregistrement(
						article.id,
						article.nom,
						article.prix_achat
					));
			}

			flatListBoxArticle.Text = liste[0].nom; // mets en text de la listbox le premier article
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
			_useGridView = new UseGridView("Article", "Quantité", "Coût unitaire");

			flatDataGridView.SetColonnesCliquables(
				_useGridView.CreateImageColumn("Editer", "Supprimer")
			);

			flatDataGridView.SetColonnesMasquees("id");
		}

		// que faire lorsque l'on ajoute/modifie un item de la liste
		private void Ajouter_Click(object sender, EventArgs e)
		{
			if (ChampsVides())
			{
				Dialog.Show("Veuillez remplir tous les champs !");
				return;
			}

			int id = flatListBoxArticle.IdSelected;

			if (_modeEdition)
			{
				flatDataGridView.UpdateRowAt(
					flatDataGridView.SelectedRow,
					flatListBoxArticle.Text,
					flatTextBoxQuantite.Text,
					Money.Round(_articles[id].Prix),
					_imageEditer,
					_imageSupprimer
					);

				EnableEdit(false);
			}
			else
			{
				_useGridView.Add(
					flatListBoxArticle.Text,
					flatTextBoxQuantite.Text,
					Money.Round(_articles[id].Prix),
					_imageEditer,
					_imageSupprimer
				);
			}

			// Actualisation du label montant
			flatDataGridView.DataSource = _useGridView.Liens; // ajout(liage) des colonnes à la gridview

			ActualiseMontant();
		}

		private void ActualiseMontant()
		{
			Money total = new Money();

			for (int i = 0; i < flatDataGridView.Rows.Count; i++)
				total.Montant += Convert.ToDecimal(flatDataGridView.Get(new Couple(i, 2)));

			flatLabelTotalMontant.Text = total.ToString();
		}

		// action lors du click sur confirmer
		private void flatButtonConfirmer_Click(object sender, EventArgs e)
		{
			//if()
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

		private bool ChampsVides()
		{
			return flatListBoxArticle.Text == "" || flatTextBoxQuantite.Text == "";
		}

		private class ArticleEnregistrement
		{
			public ArticleEnregistrement(int id, string nom, decimal prix)
			{
				Id = id;
				Nom = nom;
				//Quantite = quantite;
				Prix = prix;
			}

			public int Id { get; set; }
			public string Nom { get; set; }
			//public int Quantite { get; set; }
			public decimal Prix { get; set; }
		}
	}
}
