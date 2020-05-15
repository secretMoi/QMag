using System.Collections.Generic;
using System.Drawing;
using Controls;
using Projet_magasin.Gestion;
using Projet_magasin.Classes;
using QMag.Core;

namespace QMag.Pages.Stock
{
	public partial class Consulter : ThemePanel
	{
		private UseGridView _useGridView;
		private static readonly Image _imageEditer = Image.FromFile("Ressources/Images/editer.png");
		private static readonly Image _imageSupprimer = Image.FromFile("Ressources/Images/supprimer.png");

		public Consulter()
		{
			InitializeComponent();

			SetColonnes();

			List<C_Stock> stocks = new G_Stock(Connexion).Lire("nom");

			RempliColonnes(stocks);

			flatDataGridView1.DataSource = _useGridView.Liens; // ajout(liage) des colonnes à la gridview
		}

		private void Consulter_Load(object sender, System.EventArgs e)
		{
			// désactive le cochage de case au lancement
			flatDataGridView1.FirstCellState = false;

			flatDataGridView1.Column["Editer"].Width = 150;
			flatDataGridView1.Column["Supprimer"].Width = 200;
		}

		private void SetColonnes()
		{
			_useGridView = new UseGridView(
				"Nom",
				"Quantité Actuelle",
				"Quantité minimale",
				"Prix d'achat",
				"Prix de vente"
			);

			
			flatDataGridView1.SetColonnesCliquables(
				_useGridView.CreateImageColumn("Editer", "Supprimer")
				);
		}

		private void RempliColonnes(List<C_Stock> stocks)
		{
			foreach (C_Stock stock in stocks)
			{
				_useGridView.Add(
					stock.nom,
					stock.quantiteActuelle,
					stock.quentiteMin,
					stock.prix_achat,
					stock.prix_vente,
					_imageEditer,
					_imageSupprimer
				);
			}
		}
	}
}
