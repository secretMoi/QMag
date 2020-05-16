using System;
using Core;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Controls;
using QMag.Controls.Buttons;
using QMag.Core.Pages;

namespace QMag.Pages.Clients
{
	public partial class Ajouter : BaseAjouter
	{ 
		public Ajouter()
		{
			InitializeComponent();

			/*//todo système intelligent détecte type formulaire avec le name
			_ajout = new Formulaire
			(
				AjouterArguments.ControlList.FlatLabel, "FlatLabelNom", "Nom",
				AjouterArguments.ControlList.FlatTextBox, "FlatTextBoxNom", "",
				AjouterArguments.ControlList.FlatLabel, "FlatLabelPrenom", "Prénom",
				AjouterArguments.ControlList.FlatTextBox, "FlatTextBoxPrenom", "",
				AjouterArguments.ControlList.FlatButton, "FlatButtonAjouter", "Ajouter"
			);*/

			_ajout = new Formulaire
			(
				"FlatLabelNom", "Nom",
				"FlatTextBoxNom", "",
				"FlatLabelPrenom", "Prénom",
				"FlatTextBoxPrenom", "",
				"FlatButtonAjouter", "Ajouter"
			);

			_ajout.Get("FlatButtonAjouter").Click += Ajouter_Click;

			PositionneControls();

			_ajout.Display(panel2);
		}

		public override void Hydrate(params object[] args)
		{
			base.Hydrate(args);

			if (args.Length < 1) // vérifie qu'il y a bien un argument
				return;

			C_Clients client = args[0] as C_Clients; // cast l'argument

			if (client == null)
				return;

			flatLabelTitre.Text = @"Modification du client " + client.nom + " " + client.prenom;
			_ajout.Get("FlatButtonAjouter").Text = @"Modifier";

			// pré-rempli les champs
			_idModification = client.id;
			_ajout.Get("FlatTextBoxNom").Text = client.nom;
			_ajout.Get("FlatTextBoxPrenom").Text = client.prenom;
		}

		private void Ajouter_Click(object sender, EventArgs e)
		{
			if (!ChampsRemplis(flatLabelTitre))
				return;

			string nom = _ajout.Get("FlatTextBoxNom").Text;
			string prenom = _ajout.Get("FlatTextBoxPrenom").Text;

			if (_ajout.Get("FlatButtonAjouter").Text == @"Ajouter")
			{
				new G_Clients(Connexion).Ajouter(
					nom,
					prenom
				);

				flatLabelTitre.Text = @"Client ajouté";
			}
			else
			{
				new G_Clients(Connexion).Modifier(
					_idModification,
					nom,
					prenom
				);

				flatLabelTitre.Text = @"Client modifié";
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
