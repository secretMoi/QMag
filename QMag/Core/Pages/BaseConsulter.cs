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

		protected virtual void AfterLoad()
		{
			_flatDataGridView.DataSource = _useGridView.Liens; // ajout(liage) des colonnes à la gridview

			_flatDataGridView.Column["Editer"].Width = 150;
			_flatDataGridView.Column["Supprimer"].Width = 200;

			//if ()
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
