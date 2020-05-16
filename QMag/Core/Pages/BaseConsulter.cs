using System.Drawing;
using System.Windows.Forms;
using Controls;
using QMag.Controls;

namespace QMag.Core.Pages
{
	public partial class BaseConsulter : ThemePanel
	{
		protected UseGridView _useGridView;
		protected FlatDataGridView _flatDataGridView;

		protected Image _imageEditer;
		protected Image _imageSupprimer;

		//protected static readonly Image _imageEditer = Image.FromFile("Ressurces/Images/editer.png");
		///protected static readonly Image _imageSupprimer = Image.FromFile("Ressources/Images/supprimer.png");

		public BaseConsulter()
		{
			InitializeComponent();

			try
			{
				_imageEditer = Image.FromFile("Ressources/Images/editer.png");
				_imageSupprimer = Image.FromFile("Ressources/Images/supprimer.png");
			}
			catch {}
		}

		private void BaseConsulter_Load(object sender, System.EventArgs e)
		{
			//AfterLoad();
		}

		protected virtual void AfterLoad()
		{
			// désactive le cochage de case au lancement
			//_flatDataGridView.FirstCellState = false;

			_flatDataGridView.DataSource = _useGridView.Liens; // ajout(liage) des colonnes à la gridview
		}

		protected void SetColonnes(params string[] titres)
		{
			_useGridView = new UseGridView(titres);
		}

		protected void SetColonnesCliquables(params string[] titres)
		{
			_flatDataGridView.SetColonnesCliquables(
				_useGridView.CreateImageColumn(titres)
			);
		}
	}
}
