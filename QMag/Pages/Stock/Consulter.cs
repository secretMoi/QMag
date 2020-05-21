using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controls;
using Projet_magasin.Gestion;
using Projet_magasin.Classes;
using QMag.Core;
using QMag.Core.Pages;

namespace QMag.Pages.Stock
{
	public partial class Consulter : BaseConsulter
	{
		private readonly List<C_Stock> _stocks;
		private readonly List<int> _ligneStockInsuffisant;

		public Consulter()
		{
			InitializeComponent();

			_stocks = new G_Stock(Connexion).Lire("id");
			_ligneStockInsuffisant = new List<int>();
		}

		private void Consulter_Load(object sender, EventArgs e)
		{
			_flatDataGridView = flatDataGridView1;

			SetColonnes(
				"Nom",
				"Quantité Actuelle",
				"Quantité minimale",
				"Prix d'achat",
				"Prix de vente"
				);
			EnableColumn("editer");
			RempliColonnes();

			AfterLoad();

			foreach (int idLigne in _ligneStockInsuffisant)
			{
				flatDataGridView1.BackgroundColor(idLigne, Color.Tomato);
				flatDataGridView1.ForegroundColor(idLigne, Theme.Texte);
			}
		}

		private void RempliColonnes()
		{
			foreach (C_Stock stock in _stocks)
			{
				if (stock.quantiteActuelle < stock.quentiteMin)
					_ligneStockInsuffisant.Add(_useGridView.Count);

				_useGridView.Add(
					stock.nom,
					stock.quantiteActuelle,
					stock.quentiteMin,
					Money.Display(stock.prix_achat),
					Money.Display(stock.prix_vente),
					_imageEditer
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
		}

		private void flatButtonHtml_Click(object sender, EventArgs e)
		{
			int nombreColonnes = 5;

			object[] pageHtml = new string[
			2 + // nom & nb colonnes
			nombreColonnes + // les colonnes
			flatDataGridView1.Rows.Count * nombreColonnes // ligne * colonnes pour les données
			];

			pageHtml[0] = "Stock"; // titre
			pageHtml[1] = nombreColonnes.ToString(); // indique le nb de colonnes

			int position = 2;

			// rempli les colonnes
			for (int i = 0; i < nombreColonnes; i++)
			{
				pageHtml[position] = flatDataGridView1.Column[i].Name;
				position++;
			}

			// rempli les données
			for (int ligne = 0; ligne < flatDataGridView1.Rows.Count; ligne++)
			{
				for (int colonne = 0; colonne < nombreColonnes; colonne++)
				{
					pageHtml[position] = flatDataGridView1.Get(ligne, colonne);
					position++;
				}
			}

			// récupère le nom de la classe
			Reflection reflection = new Reflection(GetType());
			LoadPage(reflection.LastItemNamespace + ".VueHtml", pageHtml); // envoie les données à la page de visualisation
		}
	}
}
