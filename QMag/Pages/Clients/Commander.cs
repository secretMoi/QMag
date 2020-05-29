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

namespace QMag.Pages.Clients
{
	public partial class Commander : ThemePanel
	{
		private UseGridView _useGridView;
		private readonly Image _imageSupprimer = Image.FromFile("Ressources/Images/supprimer.png");
		private readonly Image _imageEditer = Image.FromFile("Ressources/Images/editer.png");

		private bool _modeEdition = false;

		private List<ArticleEnregistrement> _articles;
		private List<ClientEnregistrement> _clients;
		private readonly List<int> _associeArticleDbetDgv = new List<int>(); // l'ordre de la liste sera le même que dans _articles

		public Commander()
		{
			InitializeComponent();

			GetBdData();

			flatLabelClient.ForeColor = flatLabelArticle.ForeColor = flatLabelQuantite.ForeColor = flatLabelTotal.ForeColor = flatLabelTotalMontant.ForeColor = Theme.BackDark;
		}

		private void Commander_Load(object sender, System.EventArgs e)
		{
			SetColonnes();

			flatDataGridView.AddClickMethod(EffetClic); // s'inscrit aux event de clic dans la dgv

			flatDataGridView.DataSource = _useGridView.Liens; // ajout(liage) des colonnes à la gridview

			if (flatDataGridView.Rows.Count > 0)
				flatDataGridView.Column["Supprimer"].Width = 200;

		}

		private void SetColonnes()
		{
			_useGridView = new UseGridView("Article", "Quantité", "Coût unitaire");

			flatDataGridView.SetColonnesCliquables(
				_useGridView.CreateImageColumn("Editer", "Supprimer")
			);
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
			List<C_Clients> listeClients = new G_Clients(Connexion).Lire("id");
			_clients = new List<ClientEnregistrement>(listeClients.Count);
			foreach (C_Clients client in listeClients)
			{
				flatListBoxClient.Add(client.nom); // ajout à la flatlist

				// ajoute à notre liste arguments
				_clients.Add(
					new ClientEnregistrement(
						client.id,
						client.nom,
						client.prenom
					));
			}

			flatListBoxClient.SelectId(0); // mets en text de la listbox le premier article
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
				flatListBoxArticle.SelectId(_associeArticleDbetDgv[ligne]);
				flatTextBoxQuantite.Text = flatDataGridView.Get(ligne, colonneQuantite);
				EnableEdit(true);
			}

			else if (colonne == flatDataGridView.Column["Supprimer"]?.DisplayIndex) // si la colonne cliquée correspond à la suppression
			{
				DialogResult question =
					Dialog.ShowYesNo("Voulez-vous vraiment supprimer l'article " + flatDataGridView.Get(ligne, colonneNom) + " de la commande ?");
				if (question == DialogResult.Yes)
				{
					flatDataGridView.RemoveRowAt(ligne);
					_associeArticleDbetDgv.RemoveAt(ligne);
					EnableEdit(false);
					ActualiseMontant();
				}
			}
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

		// met à jour le label de la somme totale
		private void ActualiseMontant()
		{
			Money total = new Money();
			int nombreArticles;
			int id;

			for (int i = 0; i < flatDataGridView.Rows.Count; i++)
			{
				id = _associeArticleDbetDgv[i];
				nombreArticles = _articles[id].Quantite;

				total.Montant += Convert.ToDecimal(flatDataGridView.Get(new Couple(i, 2))) * nombreArticles;
			}

			flatLabelTotalMontant.Text = total.ToString();
		}

		private void flatButtonAjouter_Click(object sender, EventArgs e)
		{
			if (!ChampsValides())
				return;

			int idArticle = flatListBoxArticle.IdSelected; // ne convient as à la modification (pas mis à jour vu que simple changement du texte)
			int sommeQuantite = Convert.ToInt32(flatTextBoxQuantite.Text);

			if (_modeEdition) // mode Modifier
			{
				flatDataGridView.UpdateRowAt(
					_associeArticleDbetDgv.IndexOf(idArticle),
					flatListBoxArticle.Text,
					sommeQuantite,
					Money.Round(_articles[idArticle].Prix),
					_imageEditer,
					_imageSupprimer
				);

				EnableEdit(false);
			}
			else // mode Ajouter
			{
				if (!_associeArticleDbetDgv.Contains(idArticle)) // si la dgv ne contient pas déjà le même article
				{
					_useGridView.Add(
						flatListBoxArticle.Text,
						sommeQuantite,
						Money.Round(_articles[idArticle].Prix),
						_imageEditer,
						_imageSupprimer
					);

					_associeArticleDbetDgv.Add(idArticle);
				}
				else // sinon on ajoute les quantités à celles déjà présentes
				{
					sommeQuantite += _articles[idArticle].Quantite;

					flatDataGridView.UpdateRowAt(
						_associeArticleDbetDgv.IndexOf(idArticle),
						flatListBoxArticle.Text,
						sommeQuantite,
						Money.Round(_articles[idArticle].Prix),
						_imageEditer,
						_imageSupprimer
					);
				}
			}

			_articles[idArticle].Quantite = sommeQuantite; // mets à jour la classe arguments

			// Actualisation du label montant
			flatDataGridView.DataSource = _useGridView.Liens; // ajout(liage) des colonnes à la gridview
			ActualiseMontant();
		}

		private void flatButtonConfirmer_Click(object sender, EventArgs e)
		{
			if (flatDataGridView.Rows.Count < 1)
			{
				Dialog.Show("Aucun article à commander !");
				return;
			}

			C_Stock stock = StockSuffisant();
			if (stock != null)
			{
				Dialog.Show(
					"L'article " +
					stock.nom +
					" n'est plus disponible en telle quantité !"
				);
				return;
			}

			// crée la commande
			int idCommande = new G_CommandesClients(Connexion).Ajouter(
				_clients[flatListBoxClient.IdSelected].Id,
				DateTime.Now
			);

			int quantite; // stocke la quantitée demandée
			// ajotue le détail
			for (int i = 0; i < flatDataGridView.Rows.Count; i++)
			{
				quantite = Convert.ToInt32(flatDataGridView.Get(i, 1));

				// crée la commande
				new G_DetailVente(Connexion).Ajouter(
					_articles[_associeArticleDbetDgv[i]].Id,
					_articles[_associeArticleDbetDgv[i]].Prix,
					quantite,
					idCommande
				);

				// met à jour le stock
				stock = new G_Stock(Connexion).Lire_ID(_articles[_associeArticleDbetDgv[i]].Id);

				new G_Stock(Connexion).Modifier(
					stock.id,
					stock.nom,
					stock.quantiteActuelle - quantite,
					stock.quentiteMin,
					stock.prix_achat,
					stock.prix_vente
				);
			}

			Dialog.Show("Commande du client " + flatListBoxClient.Text + " effectuée !");
		}

		private C_Stock StockSuffisant()
		{
			C_Stock stock;

			for (int i = 0; i < flatDataGridView.Rows.Count; i++) // parcours tous les enregistrements
			{
				stock = new G_Stock(Connexion).Lire_ID(_articles[_associeArticleDbetDgv[i]].Id); // trouve le stock demandé

				if (stock.quantiteActuelle < _articles[_associeArticleDbetDgv[i]].Quantite) // vérifie qu'on a une quantité suffisante
					return stock;
			}
			
			return null;
		}

		private bool ChampsValides()
		{
			bool resultat = true;
			string messageErreur = "";

			resultat &= flatListBoxArticle.Text != "" && flatTextBoxQuantite.Text != "";
			if (!resultat)
				messageErreur = "Veuillez remplir tous les champs !";

			resultat &= int.TryParse(flatTextBoxQuantite.Text, out _);
			if (!resultat)
				messageErreur = "Le champs Quantité ne contient pas un nombre !";

			if (!resultat)
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

		private class ClientEnregistrement
		{
			public ClientEnregistrement(int id, string nom, string prenom)
			{
				Id = id;
				Nom = nom;
				Prenom = prenom;
			}

			public int Id { get; set; }
			public string Nom { get; set; }
			public string Prenom { get; set; }
		}
	}
}
