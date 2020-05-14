using System.Data;
using System.Windows.Forms;

namespace QMag.Core
{
	class UseGridView
	{
		private readonly DataTable _table;
		private readonly BindingSource _liens;

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

		public void Add(params object[] record)
		{
			_table.Rows.Add(record);

			_liens.DataSource = _table;
		}

		public BindingSource Liens => _liens;
	}
}
