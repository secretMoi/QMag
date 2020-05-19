using System.Collections.Generic;
using System.Windows.Forms;
using Controls;
using Core;

namespace QMag.Controls
{
	public partial class FlatDataGridView : ThemePanel
	{
		private readonly List<int> _colonnesCliquables;
		private readonly Dictionary<string, List<object>> _colonnesMasquees;

		public FlatDataGridView()
		{
			InitializeComponent();

			_colonnesCliquables = new List<int>();
			_colonnesMasquees = new Dictionary<string, List<object>>();

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

			dataGridView.CellMouseEnter += Cliquable; // event lorsque le curseur entre dans une cellule
		}

		// permet de subscribe une méthode à l'event
		public void AddClickMethod(DataGridViewCellMouseEventHandler methode)
		{
			dataGridView.CellMouseClick += methode;
		}

		private void Cliquable(object sender, DataGridViewCellEventArgs e)
		{
			// vérifie que la case sélectionnée est valide
			if (e.ColumnIndex < 0 || e.RowIndex < 0)
				return;

			if(_colonnesCliquables.Contains(e.ColumnIndex))
				dataGridView.Cursor = Cursors.Hand;
			else
				dataGridView.Cursor = Cursors.Default;
		}

		public void SetColonnesCliquables(params int[] colonnes)
		{
			foreach (int colonne in colonnes)
				_colonnesCliquables.Add(colonne);
		}

		public void SetColonnesMasquees(params string[] colonnes)
		{
			foreach (string colonne in colonnes)
				_colonnesMasquees.Add(colonne, null);
		}

		public void SetDataMasquee(string nomColonne, int positionColonne, object data)
		{
			_colonnesMasquees[nomColonne][positionColonne] = data;
		}

		public object GetDataMasquee(string nomColonne, int positionColonne)
		{
			return _colonnesMasquees[nomColonne][positionColonne];
		}

		public BindingSource DataSource
		{
			set => dataGridView.DataSource = value;
		}

		public DataGridViewColumnCollection Column => dataGridView.Columns;

		public string Get(Couple coordonnees)
		{
			if(dataGridView.Rows.Count > coordonnees.Xi && dataGridView.ColumnCount > coordonnees.Yi)
				return dataGridView.Rows[coordonnees.Xi].Cells[coordonnees.Yi].Value.ToString();

			return null;
		}

		// code exécuté après le chargement de la dgv
		private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if(dataGridView.Rows.Count > 0)
				dataGridView.FirstDisplayedCell.Selected = false; // désactive la sélection automatique
		}

		public void RemoveRowAt(int ligne)
		{
			DataGridViewRow dgvDelRow = dataGridView.Rows[ligne];
			dataGridView.Rows.Remove(dgvDelRow);
		}

		public void UpdateRowAt(int ligne, params object[] newData)
		{
			DataGridViewRow nouvelleLigne = dataGridView.Rows[ligne];

			for (int colonne = 0; colonne < dataGridView.ColumnCount; colonne++)
				nouvelleLigne.Cells[colonne].Value = newData[colonne];
		}

		public DataGridViewRowCollection Rows => dataGridView.Rows;
		public int SelectedRow => dataGridView.CurrentCell.RowIndex;


	}
}
