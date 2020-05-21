using System.Collections.Generic;
using System.Drawing;
using Controls;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core;

namespace QMag.Pages
{
    public partial class Accueil : ThemePanel
    {
	    private readonly List<C_Stock> _stocks;

        public Accueil()
        {
            InitializeComponent();

            _stocks = new G_Stock(Connexion).Lire("id");

            VerifieAlerte();
		}

        private void VerifieAlerte()
        {
	        bool alerte = false;

	        foreach (C_Stock stock in _stocks)
	        {
		        if (stock.quantiteActuelle < stock.quentiteMin)
		        {
			        alerte = true;
                    break;
		        }
	        }

	        if (alerte) // si il y a au moins un article en quantité insuffisante
	        {
		        panelAlerte.BackColor = Color.Tomato;
		        flatLabelAlerte.ForeColor = Theme.Texte;
	        }
	        else
		        panelAlerte.Size = new Size(panelAlerte.Width, 0);
        }

		private void panelAlerte_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			LoadPage("Stock.Consulter"); // charge la page Consulter
		}

		private void flatLabelAlerte_Click(object sender, System.EventArgs e)
		{
			panelAlerte_MouseClick(null, null);
		}
	}
}
