using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Controls;
using QMag.Controls.Buttons;

namespace QMag.Controls
{
	public partial class FlatListBox : UserControl
	{
		private bool _state;
		private int _vitesse;
		private readonly int _vitesseOrigine;

		private readonly Image _menuFerme;
		private readonly Image _menuOuvert;

		private const int _hauteurCase = 40;

		private readonly List<FlatButton> _elements;
		private int _nbElementsMax = 7;

		public FlatListBox()
		{
			InitializeComponent();

			_vitesse = _vitesseOrigine = 1;

			// désactive les barres de scroll mais rend le panel scrollable
			panelCorps.HorizontalScroll.Enabled = false;
			panelCorps.HorizontalScroll.Visible = false;
			panelCorps.HorizontalScroll.Maximum = 0;

			panelCorps.VerticalScroll.Enabled = false;
			panelCorps.VerticalScroll.Visible = false;
			panelCorps.VerticalScroll.Maximum = 0;
			panelCorps.AutoScroll = true;

			_elements = new List<FlatButton>();

			Size = new Size(Width, _hauteurCase);
			panelCorps.Size = new Size(Width, 0);

			flatButtonUp.Location = new Point(0,0);
			flatButtonDown.Location = new Point(0,0);

			try
			{
				_menuFerme = Image.FromFile("Ressources/Images/down-arrow.png");
				_menuOuvert = Image.FromFile("Ressources/Images/up-arrow.png");
			}
			catch { }

			pictureBox.Image = _menuFerme;
		}

		public void Add(string text, EventHandler click = null)
		{
			FlatButton flatButton = new FlatButton
			{
				Height = _hauteurCase,
				Text = @"   " + text,
				BackColor = Theme.Back,
				TextAlign = ContentAlignment.MiddleLeft,
				Width = panelCorps.Width, // fit la largeur du bouton au panel
				Location = new Point(0, (_elements.Count + 1) * _hauteurCase),
				AutoSize = true // agrandit le bouton pour afficher le texte si il est trop long
			};

			flatButton.Name = Name + "Sub" + _elements.Count;

			_elements.Add(flatButton);

			if(click != null)
				flatButton.Click += click; // abonne la fonction de retour à l'event click du bouton
			flatButton.Click += Click; // abonne la fonction de cette classe, permettant d'ouvrir/fermer le menu

			if (_elements.Count < _nbElementsMax) // évite que le menu n'aille trop bas
			{
				_vitesse += _vitesseOrigine; // augmente la vitesse à chaque création de bouton pour que le temps d'ouverture/fermeture reste le même

				panelCorps.MaximumSize = new Size(panelCorps.Width, panelCorps.MaximumSize.Height + _hauteurCase);
				MaximumSize = new Size(panelCorps.Width, MaximumSize.Height + _hauteurCase);
			}

			flatButtonDown.Location = new Point(0, (_elements.Count + 1) * _hauteurCase);


			panelCorps.Controls.Add(flatButton);
		}

		public void Add(string[] texts, EventHandler click = null)
		{
			foreach (string text in texts)
				Add(text, click);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (!_state) // si fermé à ouvert
			{
				panelCorps.Height += _vitesse;
				if (panelCorps.Size.Height == panelCorps.MaximumSize.Height)
				{
					timer.Stop();
					pictureBox.Image = _menuOuvert;
					_state = true;
				}
			}
			else // sinon ouvert à fermé
			{
				panelCorps.Height -= _vitesse;
				if (panelCorps.Size.Height == panelCorps.MinimumSize.Height)
				{
					timer.Stop();
					pictureBox.Image = _menuFerme;
					_state = false;
				}
			}
		}

		private void panelTitre_MouseDown(object sender, MouseEventArgs e)
		{
			timer.Start();
		}

		private new void Click(object sender, EventArgs e)
		{
			Text = ((FlatButton)sender).Text;
			timer.Start();
		}

		[Description("Text"), Category("Data"), Browsable(true)]
		public new string Text
		{
			get => labelTitre.Text;
			set => labelTitre.Text = value;
		}

		public int NombreElementsMax => _nbElementsMax;

		private void panelCorps_Paint(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder(e.Graphics, panelCorps.ClientRectangle, Theme.BackDark, ButtonBorderStyle.Solid);
		}
	}
}
