using System.Globalization;
using System.Windows.Forms;
using Controls;
using Core;
using QMag.Core.Graphique;

namespace QMag.Pages
{
	public partial class ChiffreAffaire : ThemePanel
	{
		private Graphique _graphique;
		private Spirographe _spirographe;

		public ChiffreAffaire()
		{
			InitializeComponent();
			ChargeGraphique();
		}

		private void ChargeGraphique()
		{
			// parcourt la liste de points
			/*foreach (Couple point in _spirographe.Points.Liste())
			{
				colonnes[0] = "Point " + compteur; // colonne Nom
				colonnes[1] = point.X.ToString(CultureInfo.CurrentCulture); // colonne X
				colonnes[2] = point.Y.ToString(CultureInfo.CurrentCulture); // colonne Y

				listViewPoints.Items.Add(new ListViewItem(colonnes)); // Ajoute l'item

				compteur++;
			}

			userControl11.Rafraichir();*/
		}
	}
}
