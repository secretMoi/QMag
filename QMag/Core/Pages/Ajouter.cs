using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controls;
using Core;
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

			AjouterArguments.ControlList control = AjouterArguments.ControlList.Unknown; // set comme default
			string name = null;
			string texte;
			foreach (object tuple in tuples)
			{
				if (control == AjouterArguments.ControlList.Unknown) // si c'est le premier paramètre
					control = (AjouterArguments.ControlList) tuple;
				else if(control != AjouterArguments.ControlList.Unknown && name == null) // si c'est le deuxieme
				{
					name = tuple as string;
				}
				else // sinon c'est le troisième
				{
					texte = tuple as string;

					//Add(control, name); // ajoute le control
					Add(new AjouterArguments(control, name, texte)); // ajoute le control

					control = AjouterArguments.ControlList.Unknown; // reset le premier pour repasser dans le if
					name = null;
				}
			}
		}

		// crée un control
		public void Add(AjouterArguments arguments)
		{
			_controls.Add(arguments.Name, CreateControl(arguments));
		}

		// affiche les controls dans un panel définit
		public void Display(Panel panel)
		{
			foreach (KeyValuePair<string, Control> control in _controls)
				panel.Controls.Add(control.Value);
		}

		public Couple LocateControlAt(Type controlAsked, Couple position)
		{
			int compteur = 0;
			Couple lastLocation = new Couple();

			foreach (Control control in Being(controlAsked))
			{
				control.Left = position.Xi;
				control.Top = position.Yi + 60 * compteur;
				compteur++;

				lastLocation = new Couple(control.Location);
			}

			return lastLocation;
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
				control = new FlatButton()
				{
					Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
				};

			// initialise certaines valeurs du control
			if (control != null)
			{
				control.Name = form.Name;
				control.Text = form.Text;
			}

			return control;
		}
	}
}
