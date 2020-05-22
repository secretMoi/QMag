using System.Globalization;
using System.Windows.Forms;
using Controls;
using Core;
using QMag.Core.Graphique;

namespace QMag.Pages
{
	public partial class ChiffreAffaire : ThemePanel
	{
		public ChiffreAffaire()
		{
			InitializeComponent();
			ChargeGraphique();
		}

		private void ChargeGraphique()
		{
			Couple couple = new Couple(5,5);

			graphic1.AjoutPoint(couple);

			graphic1.Rafraichir();
		}
	}
}
