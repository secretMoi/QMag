using System.Windows.Forms;
using Controls;

namespace QMag.Controls
{
	public partial class FlatDataGridView : ThemePanel
	{
		public FlatDataGridView()
		{
			InitializeComponent();

			dataGridView.GridColor = Theme.Back;
			dataGridView.ForeColor = Theme.BackDark;

			dataGridView.BorderStyle = BorderStyle.None;

			// désactive les bordures des titres
			dataGridView.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
			dataGridView.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
			dataGridView.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

			// mets en couleur les titres
			dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Theme.BackLight;
			dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Theme.Texte;
			dataGridView.EnableHeadersVisualStyles = false;

			// change l'élément sélectionné
			dataGridView.DefaultCellStyle.SelectionBackColor = Theme.BackLight;
			dataGridView.DefaultCellStyle.SelectionForeColor = Theme.Texte;

			// désactive la première colonne
			dataGridView.RowHeadersVisible = false;

			// change la hauteur des cellules
			dataGridView.RowTemplate.Height = 38;
		}

		public BindingSource DataSource
		{
			set => dataGridView.DataSource = value;
		}

		public DataGridViewColumnCollection Column => dataGridView.Columns;

		public bool FirstCellState
		{
			set => dataGridView.FirstDisplayedCell.Selected = value;
		}
	}
}
