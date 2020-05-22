using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core;
using QMag.Core.Pages;
using QMag.Fenetres;

namespace QMag.Pages.Fournisseurs
{
	public partial class Consulter : BaseConsulter
	{
		private readonly List<C_Fournisseurs> _founisseurs;

		public Consulter()
		{
			InitializeComponent();

			_founisseurs = new G_Fournisseurs(Connexion).Lire("id");
		}

		private void Consulter_Load(object sender, EventArgs e)
		{
			_flatDataGridView = flatDataGridView;

			SetColonnes("Nom");
			EnableColumn("editer");

			RempliColonnes();

			AfterLoad();
		}

		private void RempliColonnes()
		{
			foreach (C_Fournisseurs founisseur in _founisseurs)
				_useGridView.Add(
					founisseur.nom,
					_imageEditer
				);
		}

		public override void EffetClic(object sender, DataGridViewCellMouseEventArgs e)
		{
			int colonne = e.ColumnIndex;
			int ligne = e.RowIndex;

			// récupère le nom de la classe
			Reflection reflection = new Reflection(GetType());

			if (colonne == flatDataGridView.Column["Editer"]?.DisplayIndex) // si la colonne cliquée correspond à l'édition
				LoadPage(reflection.LastItemNamespace + ".Ajouter", _founisseurs[ligne]); // charge la page Ajouter
		}
	}
}
