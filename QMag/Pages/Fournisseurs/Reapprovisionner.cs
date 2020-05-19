using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controls;
using Core;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core;
using QMag.Fenetres;

namespace QMag.Pages.Fournisseurs
{
	public partial class Reapprovisionner : ThemePanel
	{
		private UseGridView _useGridView;
		private readonly Image _imageSupprimer = Image.FromFile("Ressources/Images/supprimer.png");
		private readonly Image _imageEditer = Image.FromFile("Ressources/Images/editer.png");

		private bool _modeEdition = false;

		public Reapprovisionner()
		{
			InitializeComponent();

			List<C_Stock> liste = new G_Stock(Connexion).Lire("id");
			foreach (C_Stock article in liste)
				flatListBoxArticle.Add(article.nom);

			flatListBoxArticle.Text = liste[0].nom;
		}

		private void Reapprovisionner_Load(object sender, EventArgs e)
		{
			SetColonnes();

			flatDataGridView.AddClickMethod(EffetClic); // s'inscrit aux event de clic dans la dgv

			flatDataGridView.DataSource = _useGridView.Liens; // ajout(liage) des colonnes à la gridview

			if(flatDataGridView.Rows.Count > 0)
				flatDataGridView.Column["Supprimer"].Width = 200;
		}

		private void EffetClic(object sender, DataGridViewCellMouseEventArgs e)
		{
			int colonne = e.ColumnIndex;
			int ligne = e.RowIndex;

			int colonneNom = 0;
			int colonneQuantite = 1;

			if (colonne == flatDataGridView.Column["Editer"]?.DisplayIndex) // si la colonne cliquée correspond à l'édition
			{
				flatListBoxArticle.Text = GetInDataGridView(ligne, colonneNom);
				flatTextBoxQuantite.Text = GetInDataGridView(ligne, colonneQuantite);
				EnableEdit(true);
			}

			else if (colonne == flatDataGridView.Column["Supprimer"]?.DisplayIndex) // si la colonne cliquée correspond à la suppression
			{
				DialogResult question = Dialog.ShowYesNo("Voulez-vous vraiment supprimer l'article " + GetInDataGridView(ligne, colonneNom) + " de la commande ?");
				if (question == DialogResult.Yes)
					flatDataGridView.RemoveRowAt(ligne);
			}
		}

		private string GetInDataGridView(int x, int y)
		{
			return flatDataGridView.Get(new Couple(x, y));
		}

		protected void SetColonnes(params string[] titres)
		{
			_useGridView = new UseGridView("Article", "Quantité", "Coût");

			flatDataGridView.SetColonnesCliquables(
				_useGridView.CreateImageColumn("Editer", "Supprimer")
			);
		}

		private void Ajouter_Click(object sender, EventArgs e)
		{
			if (_modeEdition)
			{
				flatDataGridView.UpdateRowAt(
					flatDataGridView.SelectedRow,
					flatListBoxArticle.Text,
					flatTextBoxQuantite.Text,
					"5",
					_imageEditer,
					_imageSupprimer
					);

				EnableEdit(false);
			}
			else
			{
				_useGridView.Add(
					flatListBoxArticle.Text,
					flatTextBoxQuantite.Text,
					5,
					_imageEditer,
					_imageSupprimer
				);
			}
			
			flatDataGridView.DataSource = _useGridView.Liens; // ajout(liage) des colonnes à la gridview
		}

		private void EnableEdit(bool state)
		{
			if (state)
			{
				_modeEdition = true;
				flatButtonAjouter.Text = @"Modifier";
			}
			else
			{
				_modeEdition = false;
				flatButtonAjouter.Text = @"Ajouter";
			}
		}
	}
}
