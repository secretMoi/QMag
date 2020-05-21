using System;
using Controls;
using QMag.Core;

namespace QMag.Pages.Stock
{
	public partial class VueHtml : ThemePanel
	{
		private HtmlView _html; // code html de la page
		private string _titre; // titre de la page

		public VueHtml()
		{
			InitializeComponent();
		}

		public override void Hydrate(params object[] data)
		{
			_titre = data[0] as string; // nom de la page
			int nombreColonnes = Convert.ToInt32((string) data[1]); // nombre de colonnes
			int decalage = 2; // décalage dans les arguments
			string[] colonnes = new string[nombreColonnes]; // liste des noms de colonne

			for (int i = 0; i < nombreColonnes; i++) // récupère les noms de colonne
				colonnes[i] = data[i + decalage] as string;

			_html = new HtmlView(_titre, nombreColonnes);

			_html.GenerateColumn(colonnes); // génère les colonnes

			decalage += nombreColonnes;

			// rempli les colonnes
			for (int i = decalage; i < data.Length; i++)
				_html.GenerateBody(data[i] as string);

			webBrowser.DocumentText = _html.SourceCode; // envoie le code html
		}

		private void flatButtonHtml_Click(object sender, EventArgs e)
		{
			string date = DateTime.Now.ToString().Replace(':', '_');
			date = date.Replace('/', '_');
			_html.SaveTo(_titre + "_" + date);
		}
	}
}
