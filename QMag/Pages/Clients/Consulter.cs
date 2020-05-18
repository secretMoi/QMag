using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core;
using QMag.Core.Pages;
using QMag.Fenetres;

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

			AfterLoad();
		}

		public override void Hydrate(params object[] args)
		{
			base.Hydrate(args);

			C_Clients client = ArgumentsValides(typeof(C_Clients), args) as C_Clients;
			if (client == null)
				return;

			Dialog.Show("Le client " + client.nom + " " + client.prenom + " a bien été supprimé.");
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
				LoadPage(reflection.Class + ".Ajouter", _clients[ligne]); // charge la page Ajouter

			else if (colonne == flatDataGridView.Column["Supprimer"]?.DisplayIndex) // si la colonne cliquée correspond à la suppression
			{
				string question = "le client " + _clients[ligne].nom + " " + _clients[ligne].prenom + " ?";
				if (DialogDelete(question) == DialogResult.Yes)
				{
					new G_Clients(Connexion).Supprimer(_clients[ligne].id); // supprime l'enregistrement

					LoadPage(reflection.Class + ".Consulter", _clients[ligne]); // rafraichit la page
				}
				
			}
		}
	}
}
