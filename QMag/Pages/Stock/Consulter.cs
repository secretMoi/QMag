using System.Collections.Generic;
using Controls;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;

namespace QMag.Pages.Stock
{
	public partial class Consulter : ThemePanel
	{
		public Consulter()
		{
			InitializeComponent();

			List<C_Stock> stocks = new G_Stock(Connexion).Lire("nom");

			foreach (C_Stock stock in stocks)
			{
				
			}
		}
	}
}
