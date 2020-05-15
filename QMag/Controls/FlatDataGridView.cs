﻿using System.Collections.Generic;
using System.Windows.Forms;
using Controls;

namespace QMag.Controls
{
	public partial class FlatDataGridView : ThemePanel
	{
		private readonly List<int> _colonnesCliquables;

		public FlatDataGridView()
		{
			InitializeComponent();

			_colonnesCliquables = new List<int>();

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
