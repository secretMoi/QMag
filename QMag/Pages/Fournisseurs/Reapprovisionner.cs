﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controls;
using Core;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Controls;
using QMag.Controls.Buttons;
using QMag.Core;
using QMag.Core.Pages;
using QMag.Fenetres;

namespace QMag.Pages.Fournisseurs
{
	public partial class Reapprovisionner : BaseAjouter
	{
		protected UseGridView _useGridView;
		protected Image _imageSupprimer = Image.FromFile("Ressources/Images/supprimer.png");
		protected Image _imageEditer = Image.FromFile("Ressources/Images/editer.png");

		public Reapprovisionner()
		{
			InitializeComponent();

			_ajout = new Formulaire
			(
				"FlatLabelArticle", "Article",
				"FlatListBoxArticle", "",
				"FlatLabelQuantite", "Quantité",
				"FlatTextBoxQuantite", "",
				"FlatButtonAjouter", "Ajouter",
				"FlatButtonCommander", "Commander",
				"FlatListArticles", "Liste des articles"
			);

			_ajout.Get("FlatButtonAjouter").Click += Ajouter_Click;

			PositionneControls();

			_ajout.Display(panelCorps);
		}

		private void Reapprovisionner_Load(object sender, EventArgs e)
		{
			SetColonnes();

			flatDataGridView.AddClickMethod(EffetClic); // s'inscrit aux event de clic dans la dgv

			flatDataGridView.DataSource = _useGridView.Liens; // ajout(liage) des colonnes à la gridview

			if(flatDataGridView.Rows.Count > 0)
				flatDataGridView.Column["Supprimer"].Width = 200;
		}

		private void EffetClic(object sender, DataGridViewCellMouseEventArgs e)
		{
			int colonne = e.ColumnIndex;
			int ligne = e.RowIndex;

			int colonneNom = 0;
			int colonneQuantite = 1;

			// récupère le nom de la classe
			Reflection reflection = new Reflection(GetType());

			if (colonne == flatDataGridView.Column["Editer"]?.DisplayIndex) // si la colonne cliquée correspond à l'édition
			{
				ReaprovisionnerArguments arguments = new ReaprovisionnerArguments(
					"Editer",
					GetInDataGridView(ligne, colonneNom),
					Convert.ToInt32(GetInDataGridView(ligne, colonneQuantite))
				);
				LoadPage(this.ToString(), arguments); // charge la page Ajouter
			}

			else if (colonne == flatDataGridView.Column["Supprimer"]?.DisplayIndex) // si la colonne cliquée correspond à la suppression
			{
				ReaprovisionnerArguments arguments = new ReaprovisionnerArguments(
					"Supprimer",
					GetInDataGridView(ligne, colonneNom),
					Convert.ToInt32(GetInDataGridView(ligne, colonneQuantite))
				);
				DialogResult question = Dialog.ShowYesNo("Voulez-vous vraiment supprimer l'article " + GetInDataGridView(ligne, colonneNom) + " de la commande ?");
				if (question == DialogResult.Yes)
					LoadPage(this.ToString(), arguments); // rafraichit la page
			}
		}

		private string GetInDataGridView(int x, int y)
		{
			return flatDataGridView.Get(new Couple(x, y));
		}

		public override void Hydrate(params object[] args)
		{
			base.Hydrate(args);

			/*ReaprovisionnerArguments arguments = args as ReaprovisionnerArguments;

			C_Fournisseurs fournisseur = ArgumentsValides(typeof(C_Fournisseurs), args) as C_Fournisseurs;
			if (fournisseur == null)
				return;

			Dialog.Show("Le fournisseur " + fournisseur.nom + " a bien été supprimé.");*/
		}

		protected void SetColonnes(params string[] titres)
		{
			_useGridView = new UseGridView("Article", "Quantité", "Coût");

			flatDataGridView.SetColonnesCliquables(
				_useGridView.CreateImageColumn("Editer", "Supprimer")
			);
		}

		private void Ajouter_Click(object sender, EventArgs e)
		{
			_useGridView.Add(
				((FlatListBox)_ajout.Get("FlatListBoxArticle")).Text,
				_ajout.Get("FlatTextBoxQuantite").Text,
				5,
				_imageEditer,
				_imageSupprimer
				);

			flatDataGridView.DataSource = _useGridView.Liens; // ajout(liage) des colonnes à la gridview
		}

		private void PositionneControls()
		{
			FlatListBox listBoxArticle = (FlatListBox) _ajout.Get("FlatListBoxArticle");
			FlatList listeArticles = (FlatList)_ajout.Get("FlatListArticles");

			// Labels
			_ajout.LocateControlAt(typeof(FlatLabel), new Couple(50, 50)); // Positionne les labels

			// ListBox
			Couple dernierePosition = _ajout.LocateControlAt(typeof(FlatListBox), new Couple(150, 50));
			listBoxArticle.Text = "Sélection article";

			List<C_Stock> liste = new G_Stock(Connexion).Lire("id");
			foreach (C_Stock article in liste)
				((FlatListBox) _ajout.Get("FlatListBoxArticle")).Add(article.nom);

			// Quantité
			dernierePosition.Yi += 60;

			dernierePosition.Xi = listBoxArticle.Left;
			dernierePosition = _ajout.LocateControlAt(typeof(FlatTextBox), dernierePosition); // Positionne les textbox

			// Bouton Ajouter
			dernierePosition.Yi += 60;
			_ajout.LocateControlAt(typeof(FlatButton), dernierePosition); // Positionne le bouton

			_ajout.Get("FlatButtonAjouter").Size = _ajout.Get("FlatTextBoxQuantite").Size;
			_ajout.Get("FlatButtonCommander").Size = _ajout.Get("FlatTextBoxQuantite").Size;

			// Bouton Commander
			_ajout.Get("FlatButtonCommander").Top = _ajout.Get("FlatButtonCommander").Bottom +310;

			_ajout.Get("FlatButtonCommander").Anchor = AnchorStyles.None;
			_ajout.Get("FlatButtonCommander").Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

			// Liste des articles
			listeArticles.Location = new Point(
				listBoxArticle.Left + listBoxArticle.Width + 50,
				listBoxArticle.Top
				);
		}
	}

	public class ReaprovisionnerArguments
	{
		public ReaprovisionnerArguments(string mode, string article, int quantite)
		{
			Mode = mode;
			Article = article;
			Quantite = quantite;
		}

		public string Article { get; set; }
		public int Quantite { get; set; }
		public string Mode { get; set; }
	}
}
