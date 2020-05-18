using System;
using Core;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Controls;
using QMag.Controls.Buttons;
using QMag.Core.Pages;

namespace QMag.Pages.Fournisseurs
{
	public partial class Ajouter : BaseAjouter
	{
		public Ajouter()
		{
			InitializeComponent();

			_ajout = new Formulaire
			(
				"FlatLabelNom", "Nom",
				"FlatTextBoxNom", "",
				"FlatButtonAjouter", "Ajouter"
			);

			_ajout.Get("FlatButtonAjouter").Click += Ajouter_Click;

			PositionneControls();

			_ajout.Display(panelCorps);
		}

		public override void Hydrate(params object[] args)
		{
			base.Hydrate(args);

			if (args.Length < 1) // vérifie qu'il y a bien un argument
				return;

			C_Fournisseurs fournisseur = args[0] as C_Fournisseurs; // cast l'argument

			if (fournisseur == null)
				return;

			flatLabelTitre.Text = @"Modification du fournisseur " + fournisseur.nom;
			_ajout.Get("FlatButtonAjouter").Text = @"Modifier";

			// pré-rempli les champs
			_idModification = fournisseur.id;
			_ajout.Get("FlatTextBoxNom").Text = fournisseur.nom;
		}

		private void Ajouter_Click(object sender, EventArgs e)
		{
			if (!ChampsRemplis())
				return;

			string nom = _ajout.Get("FlatTextBoxNom").Text;

			if (_ajout.Get("FlatButtonAjouter").Text == @"Ajouter")
			{
				new G_Fournisseurs(Connexion).Ajouter(
					nom
				);

				flatLabelTitre.Text = @"Fournisseur ajouté";
			}
			else
			{
				new G_Fournisseurs(Connexion).Modifier(
					_idModification,
					nom
				);

				flatLabelTitre.Text = @"Fournisseur modifié";
			}
		}

		private void PositionneControls()
		{
			// Labels
			_ajout.LocateControlAt(typeof(FlatLabel), new Couple(50, 50)); // Positionne les labels

			// Textbox
			Couple dernierePosition = _ajout.LocateControlAt(typeof(FlatTextBox), new Couple(150, 50)); // Positionne les textbox

			// Bouton
			dernierePosition.Yi += 60;
			_ajout.LocateControlAt(typeof(FlatButton), dernierePosition); // Positionne le bouton

			_ajout.Get("FlatButtonAjouter").Size = _ajout.Get("FlatTextBoxNom").Size;
		}
	}
}
