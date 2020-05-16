using System;
using Core;
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

			_ajout = new Formulaire
			(
				AjouterArguments.ControlList.FlatLabel, "FlatLabelNom", "Nom",
				AjouterArguments.ControlList.FlatTextBox, "FlatTextBoxNom", "",
				AjouterArguments.ControlList.FlatLabel, "FlatLabelPrenom", "Prénom",
				AjouterArguments.ControlList.FlatTextBox, "FlatTextBoxPrenom", "",
				AjouterArguments.ControlList.FlatButton, "FlatButtonAjouter", "Ajouter"
			);

			_ajout.Get("FlatButtonAjouter").Click += Ajouter_Click;

			PositionneControls();

			_ajout.Display(panel2);
		}

		private void Ajouter_Click(object sender, EventArgs e)
		{
			if (!ChampsRemplis(flatLabelTitre))
				return;


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
