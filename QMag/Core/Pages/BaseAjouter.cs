using System.Windows.Forms;
using Controls;
using QMag.Controls;

namespace QMag.Core.Pages
{
	public partial class BaseAjouter : ThemePanel
	{
		protected Formulaire _ajout;

		public BaseAjouter()
		{
			InitializeComponent();
		}

		protected bool ChampsRemplis(FlatLabel titre)
		{
			bool result = true;

			foreach (Control flatTextBox in _ajout.Being(typeof(FlatTextBox)))
				if (flatTextBox.Text == "")
					result = false;

			return result;
		}
	}
}
