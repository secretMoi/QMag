using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core;
using QMag.Core.Pages;

namespace QMag.Pages.Clients
{
	public partial class Consulter : BaseConsulter
	{
		private readonly List<C_Clients> _clients;

		public Consulter()
		{
			InitializeComponent();

			_clients = new G_Clients(Connexion).Lire("id");
		}
		
		private void Consulter_Load(object sender, EventArgs e)
		{
			_flatDataGridView = flatDataGridView;

			SetColonnes("Nom", "Prénom");
			EnableColumn("editer", "supprimer");

			RempliColonnes();

			flatDataGridView.AddClickMethod(EffetClic); // s'inscrit aux event de clic dans la dgv

			AfterLoad();
		}

		private void RempliColonnes()
		{
			foreach (C_Clients client in _clients)
				_useGridView.Add(
					client.nom,
					client.prenom,
					_imageEditer,
					_imageSupprimer
					);
		}

		public override void EffetClic(object sender, DataGridViewCellMouseEventArgs e)
		{
			int colonne = e.ColumnIndex;
			int ligne = e.RowIndex;

			// récupère le nom de la classe
			Reflection reflection = new Reflection(GetType());

			if (colonne == flatDataGridView.Column["Editer"]?.DisplayIndex) // si la colonne cliquée correspond à l'édition
				LoadPage(reflection.GetClass + ".Ajouter", _clients[ligne]); // charge la page Ajouter

			else if (colonne == flatDataGridView.Column["Supprimer"]?.DisplayIndex) // si la colonne cliquée correspond à la suppression
			{
				new G_Clients(Connexion).Supprimer(_clients[ligne].id); // supprime l'enregistrement

				LoadPage(reflection.GetClass + ".Consulter"); // rafraichit la page
			}
		}
	}
}
