using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controls;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core;
using QMag.Core.Pages;

namespace QMag.Pages.Clients
{
	public partial class Historique : BaseConsulter
	{
		private readonly List<C_CommandesClients> _commandes; // liste des commandes
		private readonly List<int> _id; // associe id bdd et id dgv

		public Historique()
		{
			InitializeComponent();

			_commandes = new G_CommandesClients(Connexion).Lire("id");
			_id = new List<int>(_commandes.Count);
		}

		private void Historique_Load(object sender, System.EventArgs e)
		{
			_flatDataGridView = flatDataGridView;

			SetColonnes("Client", "Montant", "Date");
			EnableColumn("voir");

			RempliColonnes();

			AfterLoad();
		}

		private void RempliColonnes()
		{
			string client;
			Money montant = new Money();
			DateTime date;
			foreach (C_CommandesClients commande in _commandes)
			{
				client = new G_Clients(Connexion).Lire_ID(commande.id_client).nom;
				date = commande.date;

				// somme les montants de chaque article
				foreach (C_DetailVente detailCommande in new G_DetailVente(Connexion).Lire("id"))
					if (detailCommande.id_commande == commande.id)
						montant.Montant += detailCommande.prix * detailCommande.quantite;

				// ajoute les champs à la dgv
				_useGridView.Add(
					client,
					Money.Display(montant.Montant),
					date,
					_imageVoir
				);

				_id.Add(commande.id); // ajout l'id pour associer la ligne de la dgv à la bdd

				montant.Montant = 0; // remet le montant à 0
			}
		}

		public override void EffetClic(object sender, DataGridViewCellMouseEventArgs e)
		{
			int colonne = e.ColumnIndex;
			int ligne = e.RowIndex;

			// récupère le nom de la classe
			Reflection reflection = new Reflection(GetType());

			if (colonne == flatDataGridView.Column["Voir"]?.DisplayIndex) // si la colonne cliquée correspond
				LoadPage(reflection.LastItemNamespace + ".ConsulterDetailVente", _id[ligne]); // charge la page de détail
		}
	}
}
