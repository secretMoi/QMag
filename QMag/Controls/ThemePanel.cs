using System.Collections.Generic;
using System.Windows.Forms;

namespace Controls
{
    public partial class ThemePanel : UserControl
    {
        protected static string Connexion;
        protected List<object> _arguments;

        public ThemePanel()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
            AutoScaleMode = AutoScaleMode.Dpi;
            DoubleBuffered = true;

            _arguments = new List<object>();
        }

        public virtual void Hydrate(params object[] args)
        {
	        foreach (object arg in args)
		        _arguments.Add(arg);
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
