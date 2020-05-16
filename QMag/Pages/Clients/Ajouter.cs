using System.Drawing;
using System.Windows.Forms;
using Controls;
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
				AjouterArguments.ControlList.FlatLabel, "FlatLabelNom",
				AjouterArguments.ControlList.FlatTextBox, "FlatTextBoxNom",
				AjouterArguments.ControlList.FlatLabel, "FlatLabelPrenom",
				AjouterArguments.ControlList.FlatTextBox, "FlatTextBoxPrenom",
				AjouterArguments.ControlList.FlatButton, "FlatButtonAjouter"
			);

			PositionneControls();

			_ajout.Display(panel2);
		}

		private void PositionneControls()
		{
			int compteur = 0;

			// Positionne les labels


			foreach (Control control in _ajout.Being(typeof(FlatLabel)))
			{
				FlatLabel flatLabel = (FlatLabel)control;
				flatLabel.Text = @"coucou";
				flatLabel.Left = 50;
				flatLabel.Top = 50 + 60 * compteur;
				compteur++;
			}

			compteur = 0;

			// Positionne les textbox
			foreach (Control control in _ajout.Being(typeof(FlatTextBox)))
			{
				FlatTextBox flatTextBox = (FlatTextBox)control;
				flatTextBox.Left = 150;
				flatTextBox.Top = 50 + 60 * compteur - 5;
				compteur++;
			}

			// Positionne le bouton
			foreach (Control control in _ajout.Being(typeof(FlatButton)))
			{
				FlatButton flatButton = (FlatButton)control;
				flatButton.Text = @"Ajouter";
				flatButton.Font = new Font(flatButton.Font, FontStyle.Bold);
				flatButton.Left = 150;
				flatButton.Top = 50 + 60 * compteur;
				flatButton.Size = new Size(150, _ajout.Get("FlatTextBoxNom").Height);
			}
		}
	}
}
