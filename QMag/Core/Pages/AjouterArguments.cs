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

		public string Text { get; set; }
		public string Name { get; set; }
		public ControlList Type { get; set; }
	}
}
