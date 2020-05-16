using System.Collections.Generic;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core.Pages;

namespace QMag.Pages.Clients
{
	public partial class Consulter : BaseConsulter
	{
		private List<C_Clients> _clients;

		public Consulter()
		{
			InitializeComponent();

			_clients = new G_Clients(Connexion).Lire("id");
		}

		private void Consulter_Load(object sender, System.EventArgs e)
		{
			_flatDataGridView = flatDataGridView;

			SetColonnes("Nom", "Prénom");
			SetColonnesCliquables("Editer", "Supprimer");
			RempliColonnes();

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

		protected override void AfterLoad()
		{
			base.AfterLoad();

			flatDataGridView.Column["Editer"].Width = 150;
			flatDataGridView.Column["Supprimer"].Width = 200;
		}
	}
}
