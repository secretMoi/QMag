using System.IO;
using System.Text;
using Controls;

namespace QMag.Core
{
	class HtmlView
	{
		private StringBuilder _htmlCode;
		private int _nombreColonnes;

		public HtmlView(string titre, int nombreColonnes)
		{
			_nombreColonnes = nombreColonnes;
			GenerateHead(titre);
		}

		private void GenerateHead(string titre)
		{
			_htmlCode = new StringBuilder();

			_htmlCode.Append(
				@"<!doctype html>" +
				"<html lang=\"fr\">" +
				"<head>" +
				"<meta charset=\"utf-8\">" +
				"<title>" + titre + "</title>" +
				"</head>" +
				"<body>" +
				"<h1 align='center'>" + titre + "</h1>" +
				"<table align='center' style='border: 1px solid " + Theme.BackDark + ";'>"
			);
		}

		public void GenerateBody(string[] data)
		{
			if(data.Length % _nombreColonnes != 0) return;

			for (int colonne = 0; colonne < data.Length; colonne++)
			{
				if (colonne % _nombreColonnes == 0)
					_htmlCode.Append("<tr>");

				_htmlCode.Append(
					"<th>" + data[colonne] + "</th>"
				);

				if (colonne % _nombreColonnes == 0)
					_htmlCode.Append("</tr>");
			}
		}

		public void SaveTo(string file)
		{
			File.WriteAllText(file + ".html", _htmlCode.ToString());
		}

		public int NombreColonnes
		{
			get => _nombreColonnes;
			set => _nombreColonnes = value;
		}
	}
}
