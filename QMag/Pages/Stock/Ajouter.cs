using System;
using System.Drawing;
using Controls;
using Projet_magasin.Gestion;

namespace QMag.Pages.Stock
{
	public partial class Ajouter : ThemePanel
	{
		public Ajouter()
		{
			InitializeComponent();

			flatLabelNom.ForeColor = Theme.BackDark;
			flatLabelPrixAchat.ForeColor = Theme.BackDark;
			flatLabelPrixVente.ForeColor = Theme.BackDark;
			flatLabelQuantiteActuelle.ForeColor = Theme.BackDark;
			flatLabelQuantiteMin.ForeColor = Theme.BackDark;
		}

		private void flatButtonAjouter_Click(object sender, System.EventArgs e)
		{
			if (!ChampsRemplis())
			{
				flatLabelTitre.Text = @"Veuillez remplir tous les champs !";
				flatLabelTitre.ForeColor = Color.Crimson;
				return;
			}

			int quantiteActuelle = Convert.ToInt32(flatTextBoxQuantiteActuelle.Texte);
			int quantiteMin = Convert.ToInt32(flatTextBoxQuantiteMin.Texte);
			decimal prixAchat = Convert.ToInt32(flatTextBoxPrixAchat.Texte);
			decimal prixVente = Convert.ToInt32(flatTextBoxPrixVente.Texte);

			new G_Stock(Connexion).Ajouter(
				flatTextBoxNom.Text,
				quantiteActuelle,
				quantiteMin,
				prixAchat,
				prixVente
			);

			flatLabelTitre.Text = @"Stock ajouté";
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
