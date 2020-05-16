using Controls;
using QMag.Core.Pages;

namespace QMag.Pages.Clients
{
	public partial class Ajouter : ThemePanel
	{
		private readonly Core.Pages.Ajouter _ajout;

		public Ajouter()
		{
			InitializeComponent();

			_ajout = new Core.Pages.Ajouter();
				
			_ajout.Add(AjouterArguments.ControlList.FlatTextBox, "lbl1");
			_ajout.Add(AjouterArguments.ControlList.FlatTextBox, "lbl2");
			_ajout.Add(AjouterArguments.ControlList.FlatTextBox, "lbl3");

			_ajout.Get("lbl3").Top = 100;
			_ajout.Get("lbl2").Left = 200;

			_ajout.Display(panel2);
		}
	}
}
