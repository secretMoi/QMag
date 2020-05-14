using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Controls;
using Projet_magasin.Gestion;
using Projet_magasin.Classes;
using QMag.Core;

namespace QMag.Pages.Stock
{
	public partial class Consulter : ThemePanel
	{
		public Consulter()
		{
			InitializeComponent();

			UseGridView useGridView = new UseGridView(
				"Nom",
				"Quantité Actuelle",
				"Quantité minimale",
				"Prix d'achat",
				"Prix de vente"
			);

			List<C_Stock> stocks = new G_Stock(Connexion).Lire("nom");

			foreach (C_Stock stock in stocks)
			{
				useGridView.Add(
					stock.nom,
					stock.quantiteActuelle,
					stock.quentiteMin,
					stock.prix_achat,
					stock.prix_vente
				);
			}

			dataGridView.DataSource = useGridView.Liens;
		}
	}
}
