using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core.Pages;

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
			EnableColumn("editer", "supprimer");

			RempliColonnes();

			flatDataGridView.AddClickMethod(EffetClic); // s'inscrit aux event de clic dans la dgv

			AfterLoad();
		}

		private void RempliColonnes()
		{
			foreach (C_Fournisseurs founisseur in _founisseurs)
				_useGridView.Add(
					founisseur.nom,
					_imageEditer,
					_imageSupprimer
				);
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

			if (colonne == flatDataGridView.Column["Editer"]?.DisplayIndex) // si la colonne cliquée correspond à l'édition
				LoadPage(@className + ".Ajouter", _founisseurs[ligne]); // charge la page Ajouter

			else if (colonne == flatDataGridView.Column["Supprimer"]?.DisplayIndex) // si la colonne cliquée correspond à la suppression
			{
				new G_Fournisseurs(Connexion).Supprimer(_founisseurs[ligne].id); // supprime l'enregistrement

				LoadPage(@className + ".Consulter"); // rafraichit la page
			}
		}
	}
}
