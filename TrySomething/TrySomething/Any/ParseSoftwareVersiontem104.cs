using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomething
{
	class ParseSoftwareVersionTem104 : Starter
	{
		public override void Start()
		{
			List<string> strings = new List<string>{ "v3A.10",
								"V3A.50", 
								"v3t.02"};

			strings.ForEach(s => Parse(s));
		}

		private void Parse(string value)
		{
			var versionParts = System.Text.RegularExpressions.Regex.Replace(value, @"[^0-9|\.]+", "").Split(new Char[] { '.', ',' });

			int integerPart, fractionPart;
			if (Int32.TryParse(versionParts[0], out integerPart) && Int32.TryParse(versionParts[1], out fractionPart))
			{
				Console.WriteLine((integerPart + fractionPart / 100.0).ToString());
			}

			//Console.WriteLine(tempVers.Aggregate((s, n) => s + " . " + n));
		}
	}
}
