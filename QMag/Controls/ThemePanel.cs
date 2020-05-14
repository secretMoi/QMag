using System;
using System.Windows.Forms;

namespace Controls
{
    public partial class ThemePanel : UserControl
    {
        protected static string Connexion;
        public ThemePanel()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
            AutoScaleMode = AutoScaleMode.Dpi;
            DoubleBuffered = true;
        }

        protected void Invoque(/*EventHandler<CommandEventArgs> listePartitions, object sender, CommandEventArgs e*/)
        {
            /*BeginInvoke((MethodInvoker)delegate
            {
                listePartitions(sender, e);
            });*/
        }

        public static void SetConnection(string connexion)
        {
            Connexion = connexion;
        }
    }
}
