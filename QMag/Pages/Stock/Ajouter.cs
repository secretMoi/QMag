using System;
using System.Drawing;
using Controls;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;

namespace QMag.Pages.Stock
{
	public partial class Ajouter : ThemePanel
	{
		private int _idStock;

		public Ajouter()
		{
			InitializeComponent();

			flatLabelNom.ForeColor = Theme.BackDark;
			flatLabelPrixAchat.ForeColor = Theme.BackDark;
			flatLabelPrixVente.ForeColor = Theme.BackDark;
			flatLabelQuantiteActuelle.ForeColor = Theme.BackDark;
			flatLabelQuantiteMin.ForeColor = Theme.BackDark;
		}

		public override void Hydrate(params object[] args)
		{
			base.Hydrate(args);

			if(args.Length < 1) // vérifie qu'il y a bien un argument
				return;

			C_Stock stock = args[0] as C_Stock; // cast l'argument

			if(stock == null)
				return;

			flatLabelTitre.Text = @"Modification de l'article " + stock.nom;
			flatButtonAjouter.Text = @"Modifier";

			// pré-rempli les champs
			_idStock = stock.id;
			flatTextBoxNom.Texte = stock.nom;
			flatTextBoxQuantiteActuelle.Texte = stock.quantiteActuelle.ToString();
			flatTextBoxQuantiteMin.Texte = stock.quentiteMin.ToString();
			flatTextBoxPrixAchat.Texte = stock.prix_achat.ToString();
			flatTextBoxPrixVente.Texte = stock.prix_vente.ToString();
		}

		private void flatButtonAjouter_Click(object sender, EventArgs e)
		{
			if (!ChampsRemplis()) // si tous les champs ne sont pas remplis
			{
				flatLabelTitre.Text = @"Veuillez remplir tous les champs !";
				flatLabelTitre.ForeColor = Color.Crimson;
				return;
			}

			// récupère les valeurs des champs
			string nom = flatTextBoxNom.Texte;
			int quantiteActuelle = Convert.ToInt32(flatTextBoxQuantiteActuelle.Texte);
			int quantiteMin = Convert.ToInt32(flatTextBoxQuantiteMin.Texte);
			decimal prixAchat = Convert.ToDecimal(flatTextBoxPrixAchat.Texte);
			decimal prixVente = Convert.ToDecimal(flatTextBoxPrixVente.Texte);

			if (flatButtonAjouter.Text == @"Ajouter") // si on est en mode insert
			{
				new G_Stock(Connexion).Ajouter(
					nom,
					quantiteActuelle,
					quantiteMin,
					prixAchat,
					prixVente
				);

				flatLabelTitre.Text = @"Stock ajouté";
			}
			else // sinon mode update
			{
				new G_Stock(Connexion).Modifier(
					_idStock,
					nom,
					quantiteActuelle,
					quantiteMin,
					prixAchat,
					prixVente
				);

				flatLabelTitre.Text = @"Stock modifié";
			}
			
			flatLabelTitre.ForeColor = Theme.Texte;
		}

		private bool ChampsRemplis()
		{
			return (flatTextBoxNom.Texte != "" &&
			        flatTextBoxPrixAchat.Texte != "" &&
			        flatTextBoxPrixVente.Texte != "" &&
			        flatTextBoxQuantiteActuelle.Texte != "" &&
			        flatTextBoxQuantiteMin.Texte != ""
				);
		}
	}
}
