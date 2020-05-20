using System;
using System.Drawing;
using Controls;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core;

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
			flatTextBoxNom.Text = stock.nom;
			flatTextBoxQuantiteActuelle.Text = stock.quantiteActuelle.ToString();
			flatTextBoxQuantiteMin.Text = stock.quentiteMin.ToString();
			flatTextBoxPrixAchat.Text = Money.Round(stock.prix_achat).ToString();
			flatTextBoxPrixVente.Text = Money.Round(stock.prix_vente).ToString();
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
			string nom = flatTextBoxNom.Text;
			int quantiteActuelle = Convert.ToInt32(flatTextBoxQuantiteActuelle.Text);
			int quantiteMin = Convert.ToInt32(flatTextBoxQuantiteMin.Text);
			decimal prixAchat = Convert.ToDecimal(flatTextBoxPrixAchat.Text);
			decimal prixVente = Convert.ToDecimal(flatTextBoxPrixVente.Text);

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
			return flatTextBoxNom.Text != "" &&
			       flatTextBoxPrixAchat.Text != "" &&
			       flatTextBoxPrixVente.Text != "" &&
			       flatTextBoxQuantiteActuelle.Text != "" &&
			       flatTextBoxQuantiteMin.Text != ""
				;
		}
	}
}
