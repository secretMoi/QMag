using System.Collections.Generic;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core;
using QMag.Core.Pages;

namespace QMag.Pages.Clients
{
	public partial class ConsulterDetailVente : BaseConsulter
	{
		private readonly List<C_DetailVente> _ventetBd;

		public ConsulterDetailVente()
		{
			InitializeComponent();

			_ventetBd = new G_DetailVente(Connexion).Lire("id");
		}

		private void ConsulterDetailVente_Load(object sender, System.EventArgs e)
		{
			_flatDataGridView = flatDataGridView;

			SetColonnes("Article", "Prix", "Quantité");
		}

		public override void Hydrate(params object[] args)
		{
			base.Hydrate(args);

			int id = (int)args[0]; // trouve l'id passé en argument

			// trouve tous les enregistrements lié à la commande
			RempliColonnes(id);

			AfterLoad();
		}

		private void RempliColonnes(int id)
		{
			string article;

			foreach (C_DetailVente achat in _ventetBd)
				if (achat.id_commande == id)
				{
					article = new G_Stock(Connexion).Lire_ID(achat.id_stock).nom; // trouve le nom de l'article

					// ajoute les champs à la dgv
					_useGridView.Add(
						article,
						Money.Display(achat.prix),
						achat.quantite
					);
				}
		}
	}
}
