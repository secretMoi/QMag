using System;
using QMag.Controls;
using QMag.Controls.Buttons;

namespace QMag.Core.Pages
{
	public class AjouterArguments
	{
		public enum ControlList
		{
			FlatTextBox,
			FlatListBox,
			FlatLabel,
			FlatButton,
			Unknown
		};

		public AjouterArguments(ControlList type, string name, string texte = null)
		{
			Type = type;
			Name = name;

			if(texte != null)
				Text = texte;
		}

		/*public Type WhatIs(string name)
		{
			if (name.Contains("FlatTextBox"))
				return typeof(FlatTextBox);
			if (name.Contains("FlatLabel"))
				return typeof(FlatLabel);
			if (name.Contains("FlatButton"))
				return typeof(FlatButton);

			return null;
		}*/

		public static ControlList WhatIs(string name)
		{
			if (name.Contains("FlatTextBox"))
				return ControlList.FlatTextBox;
			if (name.Contains("FlatLabel"))
				return ControlList.FlatLabel;
			if (name.Contains("FlatButton"))
				return ControlList.FlatButton;

			return ControlList.Unknown;
		}

		public string Text { get; set; }
		public string Name { get; set; }
		public ControlList Type { get; set; }
	}
}
