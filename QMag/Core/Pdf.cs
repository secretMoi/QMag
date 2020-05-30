using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Controls;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace QMag.Core
{
	public class Pdf
	{
		private readonly Document _document;

		private Image _logo;
		private Paragraph _rightColumn;
		private Paragraph _title;

		private Table _table;
		private List<Cell> _cells;

		public Pdf(string path)
		{
			PdfWriter writer = new PdfWriter( // création du fichier pdf
				path + ".pdf"
			);


			PdfDocument pdf = new PdfDocument(writer); // permet de manipuler un document pdf
			_document = new Document(pdf); // permet de s'abstraire aux limites pdf
		}

		public void Logo(string name)
		{
			_logo = new Image(ImageDataFactory.Create(
					@"Ressources/Images/" + name + ".png"
				))
				.SetHeight(100)
				.SetWidth(100)
				.SetTextAlignment(TextAlignment.LEFT);
		}

		public void RightColumn(StringBuilder text)
		{
			_rightColumn = new Paragraph(text.ToString())
				.SetMarginLeft(400)
				.SetMarginBottom(10)
				.SetTextAlignment(TextAlignment.LEFT)
				.SetFontSize(12);
		}

		public void Title(string title)
		{
			_title = new Paragraph(title)
				.SetMarginBottom(10)
				.SetTextAlignment(TextAlignment.CENTER)
				.SetFontSize(16);
		}

		public void MakeTable(int columnNumber)
		{
			_table = new Table(columnNumber, false).UseAllAvailableWidth();
		}

		public void MakeTableHeader(string header)
		{
			if(_cells == null) _cells = new List<Cell>();

			Cell cell = new Cell(1, 1)
				.SetBackgroundColor(new DeviceRgb(Theme.BackDark)) // couleur arrière-plan
				.SetFontColor(new DeviceRgb(Theme.Texte)) // couleur texte
				.Add(new Paragraph(header)); // texte

			_table.AddCell(cell);
		}

		public void MakeTableData(string data)
		{
			Cell cell = new Cell(1, 1)
				.SetFontColor(new DeviceRgb(Theme.BackDark)) // couleur texte
				.Add(new Paragraph(data)); // texte

			_table.AddCell(cell);
		}

		public void Close()
		{
			//todo list elemnt (object ?)
			if (_logo != null) _document.Add(_logo);
			if (_rightColumn != null) _document.Add(_rightColumn);
			if (_title != null) _document.Add(_title);
			if (_table != null) _document.Add(_table);

			_document.Close();
		}

		public static void DirectoryAvailable(string directory)
		{
			if (!System.IO.Directory.Exists(directory))
				System.IO.Directory.CreateDirectory(directory);
		}

		public static string SetDate()
		{
			string date = DateTime.Now.ToString(CultureInfo.InvariantCulture).Replace(':', '_');
			return date.Replace('/', '_');
		}
	}
}
