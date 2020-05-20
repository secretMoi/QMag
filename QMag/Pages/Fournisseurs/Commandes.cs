using System;
using System.Collections.Generic;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core;
using QMag.Core.Pages;

namespace QMag.Pages.Fournisseurs
{
	public partial class Commandes : BaseConsulter
	{
		private readonly List<C_CommandesFournisseurs> _commandes;

		public Commandes()
		{
			InitializeComponent();

			_commandes = new G_CommandesFournisseurs(Connexion).Lire("id");
		}

		private void Commandes_Load(object sender, EventArgs e)
		{
			_flatDataGridView = flatDataGridView;

			SetColonnes("Fournisseur", "Montant", "Date");

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

				foreach (C_DetailAchat detailCommande in new G_DetailAchat(Connexion).Lire("id"))
					if (detailCommande.id_commande == commande.id)
						montant.Montant += detailCommande.prix * detailCommande.quantite;

				_useGridView.Add(
					fournisseur,
					montant.Montant,
					date
				);

				montant.Montant = 0;
			}
				
		}
	}
}
