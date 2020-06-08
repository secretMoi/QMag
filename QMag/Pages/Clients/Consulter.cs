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

			SetColonnes("Nom", "Prénom", "Naissance");
			EnableColumn("editer");

			RempliColonnes();

			AfterLoad();
		}

		private void RempliColonnes()
		{
			foreach (C_Clients client in _clients)
				_useGridView.Add(
					client.nom,
					client.prenom,
					client.naissance.ToString().Substring(0, 10),
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
				LoadPage(reflection.LastItemNamespace + ".Ajouter", _clients[ligne]); // charge la page Ajouter
		}
	}
}
