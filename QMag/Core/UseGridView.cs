using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QMag.Controls;

namespace QMag.Core
{
	class UseGridView
	{
		private readonly DataTable _table;
		private readonly BindingSource _liens;
		private FlatDataGridView _flatDataGridView;

		public UseGridView()
		{
			_table = new DataTable();
			_liens = new BindingSource();
		}

		public UseGridView(params string[] titles) : this()
		{
			CreateColumns(titles);
		}

		public void CreateColumns(params string[] titles)
		{
			foreach (string title in titles)
				_table.Columns.Add(new DataColumn(title));
		}

		public void CreateImageColumn(params string[] titles)
		{
			foreach (string title in titles)
			{
				_table.Columns.Add(title, typeof(Bitmap));
			}
		}

		public void Add(params object[] records)
		{
			_table.Rows.Add(records);
			_liens.DataSource = _table;
		}

		public BindingSource Liens => _liens;

		public FlatDataGridView SetFlatDataGridView
		{
			set => _flatDataGridView = value;
		}

		public int ColumnCount => _flatDataGridView.Column.Count;
	}
}
