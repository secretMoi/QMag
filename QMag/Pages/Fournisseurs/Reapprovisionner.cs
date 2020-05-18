using System.Collections.Generic;
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
				"FlatButtonAjouter", "Ajouter"
			);

			//_ajout.Get("FlatButtonAjouter").Click += Ajouter_Click;

			PositionneControls();

			_ajout.Display(panelCorps);
		}

		private void PositionneControls()
		{
			// Labels
			_ajout.LocateControlAt(typeof(FlatLabel), new Couple(50, 50)); // Positionne les labels

			// ListBox
			Couple dernierePosition = _ajout.LocateControlAt(typeof(FlatListBox), new Couple(150, 50)); // Positionne les textbox

			List<C_Stock> liste = new G_Stock(Connexion).Lire("id");
			foreach (C_Stock article in liste)
				((FlatListBox) _ajout.Get("FlatListBoxArticle")).Add(article.nom);

			// Textbox
			dernierePosition.Yi += 60;
			_ajout.LocateControlAt(typeof(FlatTextBox), dernierePosition); // Positionne les textbox

			// Bouton
			dernierePosition.Yi += 60;
			_ajout.LocateControlAt(typeof(FlatButton), dernierePosition); // Positionne le bouton

			_ajout.Get("FlatButtonAjouter").Size = _ajout.Get("FlatTextBoxQuantite").Size;
		}
	}
}
