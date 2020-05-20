using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core;
using QMag.Core.Pages;

namespace QMag.Pages.Fournisseurs
{
	public partial class Commandes : BaseConsulter
	{
		private readonly List<C_CommandesFournisseurs> _commandes;
		private readonly List<int> _id;

		public Commandes()
		{
			InitializeComponent();

			_commandes = new G_CommandesFournisseurs(Connexion).Lire("id");
			_id = new List<int>(_commandes.Count);
		}

		private void Commandes_Load(object sender, EventArgs e)
		{
			_flatDataGridView = flatDataGridView;

			SetColonnes("Fournisseur", "Montant", "Date");
			EnableColumn("voir");

			RempliColonnes();

			AfterLoad();
		}

		private void RempliColonnes()
		{
			string fournisseur;
			Money montant = new Money();
			DateTime date;
			foreach (C_CommandesFournisseurs commande in _commandes)
			{
				fournisseur = new G_Fournisseurs(Connexion).Lire_ID(commande.id_fournisseur).nom;
				date = commande.date;

				// somme les montants de chaque article
				foreach (C_DetailAchat detailCommande in new G_DetailAchat(Connexion).Lire("id"))
					if (detailCommande.id_commande == commande.id)
						montant.Montant += detailCommande.prix * detailCommande.quantite;

				// ajoute les champs à la dgv
				_useGridView.Add(
					fournisseur,
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

			if (colonne == flatDataGridView.Column["Voir"]?.DisplayIndex) // si la colonne cliquée correspond à l'édition
				LoadPage(reflection.LastItemNamespace + ".ConsulterDetailAchat", _id[ligne]); // charge la page Ajouter
		}
	}
}
