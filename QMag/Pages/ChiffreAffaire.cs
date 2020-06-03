using System;
using System.Collections.Generic;
using System.Linq;
using Controls;
using Core;
using Projet_magasin.Classes;
using Projet_magasin.Gestion;
using QMag.Core;
//todo dgv pour consulter les points
namespace QMag.Pages
{
	public partial class ChiffreAffaire : ThemePanel
	{
		private readonly Dictionary<DateTime, decimal> _points = new Dictionary<DateTime, decimal>();
		private DateTime _lastDate = DateTime.MinValue;
		private DateTime _firstDate = DateTime.MaxValue;

		public ChiffreAffaire()
		{
			InitializeComponent();

			Achats();
			Vente();

			SetLabels();

			ChargeGraphique();
		}

		private void SetLabels()
		{
			flatLabelDateDebut.ForeColor = Theme.BackDark;
			flatLabelDateFin.ForeColor = Theme.BackDark;
			flatLabelChiffreAffaires.ForeColor = Theme.BackDark;

			flatLabelDateDebut.Text += SetFirstDate();
			flatLabelDateFin.Text += FormatDate(_lastDate);

			flatLabelChiffreAffaires.Text += SetMontantFinal();
		}

		private string SetFirstDate()
		{
			_firstDate = _points.First().Key;
			return FormatDate(_firstDate);
		}

		private void SetLastDate(DateTime date)
		{
			if (date > _lastDate)
				_lastDate = date;
		}

		private string FormatDate(DateTime date)
		{
			return date.ToString("dd/MM/yyyy");
		}

		private string SetMontantFinal()
		{
			decimal montant = 0;

			foreach (KeyValuePair<DateTime, decimal> point in _points)
				montant += point.Value;

			return Money.Display(montant);
		}

		private void AjoutPoint(DateTime date, decimal montant)
		{
			date = new DateTime(date.Year, date.Month, date.Day);

			if (!_points.ContainsKey(date)) // si c'est une nouvelel datte
				_points.Add(date, montant); // on ajoute direct le point
			else
				_points[date] += montant; // on additionne les montants
		}

		private void Achats()
		{
			List<C_CommandesFournisseurs> commandeAchats = new G_CommandesFournisseurs(Connexion).Lire("id");
			List<C_DetailAchat> detailAchats = new G_DetailAchat(Connexion).Lire("id");

			SetLastDate(commandeAchats.Last().date);

			int dernierePos = 0; // permet de reprendre la boucle j là où on en était (optimisation)

			for (int i = 0; i < commandeAchats.Count; i++) // parcours les commandes
			{
				for (int j = dernierePos; j < detailAchats.Count; j++) // parcours les détails
				{
					if (detailAchats[j].id_commande == commandeAchats[i].id) // si le détail correspond à la commande
					{
						AjoutPoint(commandeAchats[i].date, -detailAchats[j].prix * detailAchats[j].quantite); // on ajoute le point

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
		}

		private void Vente()
		{
			List<C_CommandesClients> commandeVente = new G_CommandesClients(Connexion).Lire("id");
			List<C_DetailVente> detailVentes = new G_DetailVente(Connexion).Lire("id");

			SetLastDate(commandeVente.Last().date);

			int dernierePos = 0; // permet de repdnre la boucle j là où on en était (optimisation)

			for (int i = 0; i < commandeVente.Count; i++) // parcours les commandes
			{
				for (int j = dernierePos; j < detailVentes.Count; j++) // parcours les détails
				{
					if (detailVentes[j].id_commande == commandeVente[i].id) // si le détail correspond à la commande
					{
						AjoutPoint(commandeVente[i].date, detailVentes[j].prix * detailVentes[j].quantite); // on ajoute le point

						// si la prochaine commande n'est plus de cette commande
						if (j < detailVentes.Count - 1)
						{
							if (detailVentes[j + 1].id_commande != detailVentes[j].id_commande)
							{
								dernierePos = j;
								break;
							}
						}
					}
				}
			}
		}

		private void ChargeGraphique()
		{
			double differenceDays;
			Couple pointAffichable;

			foreach (KeyValuePair<DateTime, decimal> point in _points)
			{
				differenceDays = Math.Ceiling(-(_firstDate - point.Key).TotalDays);
				pointAffichable = new Couple((float) differenceDays, (float) point.Value);
				graphic.AjoutPoint(pointAffichable);
			}

			graphic.Rafraichir();
		}
	}
}
