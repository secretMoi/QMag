using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMag.Core
{
	public class Reflection
	{
		private Type _type;

		public Reflection(Type type)
		{
			_type = type;
		}

		public string GetNamespace => _type.Namespace;

		public string FirstNamespace => _type.Namespace?.Split('.')[0];

		public string GetClass
		{
			get
			{
				string @namespace = _type.Namespace;
				string[] @class = @namespace?.Split('.');
				return @class?[@class.Length - 1];
			}
		}

		public Type Type
		{
			get => _type;
			set => _type = value;
		}
	}

	
}
