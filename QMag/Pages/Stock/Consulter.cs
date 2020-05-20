using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projet_magasin.Gestion;
using Projet_magasin.Classes;
using QMag.Core;
using QMag.Core.Pages;
using QMag.Fenetres;

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

		public override void Hydrate(params object[] args)
		{
			base.Hydrate(args);

			C_Stock stock = ArgumentsValides(typeof(C_Stock), args) as C_Stock;
			if (stock == null)
				return;

			Dialog.Show("L'article " + stock.nom + " a bien été supprimé.");
		}

		private void RempliColonnes()
		{
			foreach (C_Stock stock in _stocks)
			{
				_useGridView.Add(
					stock.nom,
					stock.quantiteActuelle,
					stock.quentiteMin,
					Money.Display(stock.prix_achat),
					Money.Display(stock.prix_vente),
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
			Reflection reflection = new Reflection(GetType());

			if (colonne == flatDataGridView1.Column["Editer"]?.DisplayIndex) // si la colonne cliquée correspond à l'édition
				LoadPage(reflection.LastItemNamespace + ".Ajouter",  _stocks[ligne]); // charge la page Ajouter

			else if (colonne == flatDataGridView1.Column["Supprimer"]?.DisplayIndex) // si la colonne cliquée correspond à la suppression
			{
				string question = "l'article " + _stocks[ligne].nom + " ?";
				if (DialogDelete(question) == DialogResult.Yes)
				{
					new G_Stock(Connexion).Supprimer(_stocks[ligne].id); // supprime l'enregistrement

					LoadPage(reflection.LastItemNamespace + ".Consulter", _stocks[ligne]); // rafraichit la page
				}

			}
		}

		private void flatButtonHtml_Click(object sender, EventArgs e)
		{
			HtmlView html = new HtmlView("Stock", 5);

			html.GenerateColumn(
				"Nom",
				"Quantité Actuelle",
				"Quantité minimale",
				"Prix d'achat",
				"Prix de vente"
			);

			foreach (DataGridViewRow row in flatDataGridView1.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					if(cell.ColumnIndex < 5)
						html.GenerateBody(cell.Value.ToString());
				}
			}

			html.SaveTo("test01");
		}
	}
}
