using System.Drawing;
using System.Windows.Forms;
using Controls;
using Core;
using QMag.Controls;
using QMag.Controls.Buttons;
using QMag.Core.Pages;

namespace QMag.Pages.Clients
{
	public partial class Ajouter : ThemePanel
	{
		private readonly Core.Pages.Ajouter _ajout;

		public Ajouter()
		{
			InitializeComponent();

			_ajout = new Core.Pages.Ajouter
			(
				AjouterArguments.ControlList.FlatLabel, "FlatLabelNom", "Nom",
				AjouterArguments.ControlList.FlatTextBox, "FlatTextBoxNom", "",
				AjouterArguments.ControlList.FlatLabel, "FlatLabelPrenom", "Prénom",
				AjouterArguments.ControlList.FlatTextBox, "FlatTextBoxPrenom", "",
				AjouterArguments.ControlList.FlatButton, "FlatButtonAjouter", "Ajouter"
			);

			PositionneControls();

			_ajout.Display(panel2);
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
