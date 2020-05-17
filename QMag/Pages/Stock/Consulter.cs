using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projet_magasin.Gestion;
using Projet_magasin.Classes;
using QMag.Core.Pages;

namespace QMag.Pages.Stock
{
	public partial class Consulter : BaseConsulter
	{
		private readonly List<C_Stock> _stocks;

		public Consulter()
		{
			InitializeComponent();

			_stocks = new G_Stock(Connexion).Lire("id");
		}

		private void Consulter_Load(object sender, System.EventArgs e)
		{
			_flatDataGridView = flatDataGridView1;

			SetColonnes(
				"Nom",
				"Quantité Actuelle",
				"Quantité minimale",
				"Prix d'achat",
				"Prix de vente"
				);
			EnableColumn("editer", "supprimer");
			RempliColonnes();

			AfterLoad();
		}

		private void RempliColonnes()
		{
			foreach (C_Stock stock in _stocks)
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

		public override void EffetClic(object sender, DataGridViewCellMouseEventArgs e)
		{
			int colonne = e.ColumnIndex;
			int ligne = e.RowIndex;

			// récupère le nom de la classe
			Type myType = GetType();
			string @namespace = myType.Namespace;
			string[] @class = @namespace?.Split('.');
			string @className = @class?[@class.Length - 1];

			if (colonne == flatDataGridView1.Column["Editer"]?.DisplayIndex) // si la colonne cliquée correspond à l'édition
				LoadPage(@className + ".Ajouter",  _stocks[ligne]); // charge la page Ajouter

			else if (colonne == flatDataGridView1.Column["Supprimer"]?.DisplayIndex) // si la colonne cliquée correspond à la suppression
			{
				new G_Stock(Connexion).Supprimer(_stocks[ligne].id); // supprime l'enregistrement

				LoadPage(@className + ".Consulter"); // rafraichit la page
			}
		}
	}
}
