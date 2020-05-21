﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Controls;
using Core;

namespace QMag.Controls
{
	public partial class FlatDataGridView : ThemePanel
	{
		private readonly List<int> _colonnesCliquables;
		private readonly Dictionary<int, object> _colonnesMasquees;

		public FlatDataGridView()
		{
			InitializeComponent();

			_colonnesCliquables = new List<int>();
			_colonnesMasquees = new Dictionary<int, object>();

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

			// active le double buffer pour rendre le redimensionnement plus fluide
			Type dgvType = dataGridView.GetType();
			PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
				BindingFlags.Instance | BindingFlags.NonPublic);
			pi.SetValue(dataGridView, true, null);
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

		public void SetDataMasquee(int positionColonne, object data)
		{
			_colonnesMasquees[positionColonne] = data;
		}

		public void UpdateDataMasquee(int positionColonne, object data)
		{
			_colonnesMasquees[positionColonne] = data;
		}

		public object GetDataMasquee(int positionColonne)
		{
			return _colonnesMasquees[positionColonne];
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

		public string Get(int x, int y)
		{
			return Get(new Couple(x, y));
		}

		// code exécuté après le chargement de la dgv
		private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if(dataGridView.Rows.Count > 0) // vérifie qu'il y a bien des cellules pour ne pas provoquer de bug
				dataGridView.FirstDisplayedCell.Selected = false; // désactive la sélection automatique
		}

		// supprime une ligne à une position donnée
		public void RemoveRowAt(int ligne)
		{
			DataGridViewRow dgvDelRow = dataGridView.Rows[ligne];
			dataGridView.Rows.Remove(dgvDelRow);
		}

		// modifie une ligne à une position donnée
		public void UpdateRowAt(int ligne, params object[] newData)
		{
			DataGridViewRow nouvelleLigne = dataGridView.Rows[ligne];

			for (int colonne = 0; colonne < dataGridView.ColumnCount; colonne++)
				nouvelleLigne.Cells[colonne].Value = newData[colonne];
		}

		// retourne une collection des lignes
		public DataGridViewRowCollection Rows => dataGridView.Rows;
		public int SelectedRow => dataGridView.CurrentCell.RowIndex;
	}
}
