using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controls;
using QMag.Controls;
using QMag.Controls.Buttons;

namespace QMag.Core.Pages
{
	public partial class Ajouter : ThemePanel
	{
		private readonly Dictionary<string, Control> _controls;

		public Ajouter(params object[] tuples)
		{
			InitializeComponent();

			_controls = new Dictionary<string, Control>();

			AjouterArguments.ControlList control = AjouterArguments.ControlList.Unknown;
			string name = null;
			for (int compteur = 0; compteur < tuples.Length; compteur++)
			{
				if (control == AjouterArguments.ControlList.Unknown)
					control = (AjouterArguments.ControlList) tuples[compteur];
				else
				{
					name = tuples[compteur] as string;
					Add(control, name);

					control = AjouterArguments.ControlList.Unknown;
					name = null;
				}
			}
		}

		// crée un control
		public void Add(AjouterArguments.ControlList typeControl, string name)
		{
			_controls.Add(name, CreateControl(new AjouterArguments(typeControl, name)));
		}

		// affiche les controls dans un panel définit
		public void Display(Panel panel)
		{
			foreach (KeyValuePair<string, Control> control in _controls)
				panel.Controls.Add(control.Value);
		}

		// récupère un control particulier via son nom
		public Control Get(string name)
		{
			if(_controls.ContainsKey(name))
				return _controls[name];

			return null;
		}

		// retourne une liste du type de control désiré
		public List<Control> Being(Type controlAsked)
		{
			List<Control> controls = new List<Control>();

			foreach (KeyValuePair<string, Control> control in _controls)
			{
				if(control.Value.GetType() == controlAsked)
					controls.Add(control.Value);
			}

			return controls;
		}

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
				control = new FlatLabel(){
					ForeColor = Theme.BackDark
				};
			else if (form.Type == AjouterArguments.ControlList.FlatButton)
				control = new FlatButton();

			// initialise certaines valeurs du control
			if (control != null)
				control.Name = form.Name;

			return control;
		}
	}
}
