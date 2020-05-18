using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controls;
using Core;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Controls;
using QMag.Controls.Buttons;
using QMag.Core.Pages;

namespace QMag.Pages.Fournisseurs
{
	public partial class Reapprovisionner : BaseAjouter
	{
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

		private void Ajouter_Click(object sender, EventArgs e)
		{
			
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
}
