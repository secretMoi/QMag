using System.Drawing;
using System.Windows.Forms;
using Controls;
using QMag.Controls;

namespace QMag.Core.Pages
{
	public partial class BaseAjouter : ThemePanel
	{
		protected Formulaire _ajout;
		protected int _idModification;

		public BaseAjouter()
		{
			InitializeComponent();
		}

		protected bool ChampsRemplis(FlatLabel titre)
		{
			bool result = true;

			foreach (Control flatTextBox in _ajout.Being(typeof(FlatTextBox)))
				if (flatTextBox.Text == "") // si un des champs est vide
					result = false;

			if (!result)
			{
				titre.Text = @"Veuillez remplir tous les champs !";
				titre.ForeColor = Color.Crimson;
			}

			return result;
		}
	}
}
