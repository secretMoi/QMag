using System;
using System.Collections.Generic;
using System.Linq;
using Controls;
using Core;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;

//todo graphique achat + vente au jour le jour, désactiver points ?
namespace QMag.Pages
{
	public partial class ChiffreAffaire : ThemePanel
	{
		//readonly List<KeyValuePair<DateTime, decimal>> _points = new List<KeyValuePair<DateTime, decimal>>();
		private readonly Dictionary<DateTime, decimal> _points = new Dictionary<DateTime, decimal>();

		public ChiffreAffaire()
		{
			InitializeComponent();
			Achats();
			ChargeGraphique();
		}

		private void AjoutPoint(DateTime date, decimal montant)
		{
			if (!_points.ContainsKey(date))
				_points.Add(date, montant);
			else
				_points[date] += montant;
		}

		private void Achats()
		{
			List<C_CommandesFournisseurs> commandeAchats = new G_CommandesFournisseurs(Connexion).Lire("id");
			List<C_DetailAchat> detailAchats = new G_DetailAchat(Connexion).Lire("id");

			List<Couple> pointsRetour = new List<Couple>();

			int dernierePos = 0; // permet de repdnre la boucle j là où on en était (optimisation)

			for (int i = 0; i < commandeAchats.Count; i++) // parcours les commandes
			{
				for (int j = dernierePos; j < detailAchats.Count; j++) // parcours les détails
				{
					if (detailAchats[j].id_commande == commandeAchats[i].id) // si le détail correspond à la commande
					{
						AjoutPoint(commandeAchats[i].date, -detailAchats[j].prix); // on ajoute le point

						// si la prochaine commande n'est plus de cette commande
						if (j < detailAchats.Count - 1)
						{
							if (detailAchats[j + 1].id_commande != detailAchats[j].id_commande)
							{
								dernierePos = j;
								break;
							}
						}
					}
				}
			}
			//DateTime oneTwentyDaysAgo = DateTime.Today.AddDays(-120);
		}

		private void ChargeGraphique()
		{
			DateTime today = DateTime.Now;
			//DateTime firstDay = _points.Keys.First();
			double differenceDays;
			Couple pointAffichable;

			foreach (KeyValuePair<DateTime, decimal> point in _points)
			{
				differenceDays = Math.Ceiling((today - point.Key).TotalDays);
				pointAffichable = new Couple((float) differenceDays, (float) point.Value);
				graphic.AjoutPoint(pointAffichable);
			}

			graphic.Rafraichir();
		}
	}
}
