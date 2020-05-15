using System;
using System.Drawing;
using System.Windows.Forms;
using Controls;
using QMag.Pages;

// todo système de maj avec dernier client sur nas
namespace QMag.Fenetres
{
    public partial class Form1 : FormBdd
    {
        private bool _isResizing;
        private Point _anciennePositionCurseur;
        private Size _ancienneTailleFenetre;

        private Panel _subMenuPanelToHide;
        private Panel _subMenuPanelToShow;
        public Form1()
        {
            InitializeComponent();

            Resize += Form1_Resize;

            ThemePanel.SetConnection(Connexion);
            Accueil accueil = new Accueil();

            panelContainer.Controls.Add(accueil);

            SetSubMenus();
        }

        private void SetSubMenus()
        {
            panelSousMenuStock.Size = new Size(panelSousMenuStock.Size.Width, 0);
            panelSousMenuClients.Size = new Size(panelSousMenuClients.Size.Width, 0);
        }

        private void HideSubMenu()
        {
            if (panelSousMenuStock.Size.Height == panelSousMenuStock.MaximumSize.Height && panelSousMenuStock != _subMenuPanelToShow)
                _subMenuPanelToHide = panelSousMenuStock;

            else if (panelSousMenuClients.Size.Height == panelSousMenuClients.MaximumSize.Height && panelSousMenuClients != _subMenuPanelToShow)
	            _subMenuPanelToHide = panelSousMenuClients;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (panelSousMenuStock.Size.Height == panelSousMenuStock.MinimumSize.Height)
            {
	            _subMenuPanelToShow = subMenu;
                HideSubMenu(); // cache les autres sous-menus
                
            }
            else if(panelSousMenuClients.Size.Height == panelSousMenuClients.MinimumSize.Height)
            {
	            _subMenuPanelToShow = subMenu;
                HideSubMenu(); // cache les autres sous-menus
	            
            }
            else
                _subMenuPanelToHide = subMenu;

            timerMenuDeroulant.Start();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            string nom = ((Button)sender).Name; // récupère le nom du controle appelant
            string[] chaine = nom.Split('_'); // scinde le nom pour avoir les 2 parties

            String espaceNom = typeof(Form1).Namespace;
            string[] espaceNoms = espaceNom?.Split('.');
            espaceNom = espaceNoms?[0];

            string @namespace, @class;

            if (chaine.Length == 3) // si c'est un bouton de sous-menu
            {
                @namespace = espaceNom + ".Pages." + chaine[1];
                @class = chaine[2];
            }
            else // si c'est un bouton de menu
            {
                @namespace = espaceNom + ".Pages";
                @class = chaine[1];

                // trouve le panel correspondant
                Control[] panel = Controls.Find("PanelSousMenu" + chaine[1], true);
                if(panel.Length > 0) // si un panel existe
                    ShowSubMenu((Panel)panel[0]);
            }

            LoadPage(@namespace + "." + @class);
        }

        public void LoadPage(string cheminPage, params object[] arguments)
        {
	        Type typeClasse = Type.GetType(cheminPage); // trouve la classe
	        if (typeClasse == null) return; // quitte si la classe est introuvable

	        if (!(Activator.CreateInstance(typeClasse) is ThemePanel page)) return;
	        panelContainer.Controls.Clear();
	        panelContainer.Controls.Add(page);

	        page.Hydrate(arguments);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*Ssh.ClearEvents();
            Ssh.Disconnect();
            Ssh.Dispose();*/
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxReduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                panelHeader.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int wmNclbuttondown = 0x00A1;
                const int htcaption = 2;
                Message msg =
                    Message.Create(Handle, wmNclbuttondown,
                        new IntPtr(htcaption), IntPtr.Zero);
                DefWndProc(ref msg);
            }
        }

        private void pictureBoxResize_MouseDown(object sender, MouseEventArgs e)
        {
            _isResizing = true;
            _anciennePositionCurseur = MousePosition;
            _ancienneTailleFenetre = Size;
        }

        private void pictureBoxResize_MouseUp(object sender, MouseEventArgs e)
        {
            _isResizing = false;
        }

        private void pictureBoxResize_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isResizing)
            {
                Width = MousePosition.X - _anciennePositionCurseur.X + _ancienneTailleFenetre.Width;
                Height = MousePosition.Y - _anciennePositionCurseur.Y + _ancienneTailleFenetre.Height;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Update();
        }

        private void timerMenuDeroulant_Tick(object sender, EventArgs e)
        {
            if (_subMenuPanelToShow != null)
            {
                _subMenuPanelToShow.Height += 10;
                if (_subMenuPanelToShow.Size.Height == _subMenuPanelToShow.MaximumSize.Height)
                {
                    timerMenuDeroulant.Stop();
                    _subMenuPanelToShow = null;
                }
            }
            if (_subMenuPanelToHide != null)
            {
                _subMenuPanelToHide.Height -= 10;
                if (_subMenuPanelToHide.Size.Height == _subMenuPanelToHide.MinimumSize.Height)
                {
                    timerMenuDeroulant.Stop();
                    _subMenuPanelToHide = null;
                }
            }
        }

        private void pictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            Zoom(pictureBoxClose, 48);
        }

        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            Zoom(pictureBoxClose, 32);
        }

        private void pictureBoxReduce_MouseEnter(object sender, EventArgs e)
        {
            Zoom(pictureBoxReduce, 48);
        }

        private void pictureBoxReduce_MouseLeave(object sender, EventArgs e)
        {
            Zoom(pictureBoxReduce, 32);
        }

        private void Zoom(Control control, int taille)
        {
            int sensZoom = 1;

            Size ancienneTaille = control.Size;

            if (taille > ancienneTaille.Width)
                sensZoom = -1;

            Point nouvellePosition = new Point(
                control.Location.X + sensZoom * Math.Abs(taille - ancienneTaille.Width) / 2,
                control.Location.Y + sensZoom * Math.Abs(taille - ancienneTaille.Height) / 2
            );
            control.Location = nouvellePosition;
            control.Size = new Size(taille, taille);
        }
    }
}