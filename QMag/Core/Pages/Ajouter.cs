using System.Collections.Generic;
using System.Windows.Forms;
using Controls;
using QMag.Controls;

namespace QMag.Core.Pages
{
	public partial class Ajouter : ThemePanel
	{
		private readonly Dictionary<string, Control> _controls;


		public Ajouter()
		{
			InitializeComponent();

			_controls = new Dictionary<string, Control>();
		}

		public void Add(AjouterArguments.ControlList typeControl, string name)
		{
			_controls.Add(name, CreateControl(new AjouterArguments(typeControl, name)));
		}

		public void Display(Panel panel)
		{
			foreach (KeyValuePair<string, Control> control in _controls)
				panel.Controls.Add(control.Value);
		}

		public Control Get(string name)
		{
			return _controls[name];
		}

		/*public List<Control> CreateForm(List<AjouterArguments> controls)
		{
			List<Control> controlsList = new List<Control>(controls.Count);

			foreach (AjouterArguments control in controls)
				controlsList.Add(CreateControl(control));

			return controlsList;
		}*/

		// Crée un control
		private Control CreateControl(AjouterArguments form)
		{
			Control control = null;

			// définit le type du control
			if (form.Type == AjouterArguments.ControlList.FlatTextBox)
				control = new FlatTextBox();
			else if(form.Type == AjouterArguments.ControlList.FlatListBox)
				control = new FlatListBox();
			else if (form.Type == AjouterArguments.ControlList.FlatLabel)
				control = new FlatLabel
				{
					ForeColor = Theme.BackDark
				};

			// initialise certaines valeurs du control
			if (control != null)
				control.Name = form.Name;

			return control;
		}
	}
}
