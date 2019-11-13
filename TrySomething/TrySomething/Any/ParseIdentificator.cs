using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomething
{
	public class ParseIdentificator : Starter
	{
		public override void Start()
		{
			string highWord = "46400";
			string lowWord = "57840";

			Console.WriteLine(getIdentificator(highWord, lowWord));
		}

		private string getIdentificator(string highWord, string lowWord)
		{
			string str = "";

			uint highVal, lowVal;

			if (!UInt32.TryParse(highWord, out highVal) || !UInt32.TryParse(lowWord, out lowVal))
			{
				return "";
			}

			highVal <<= 16;

			uint dualWord = (highVal + lowVal) / 40;

			if (dualWord < 0 || dualWord > 99999999)
			{
				return "";
			}
			
			string sum = String.Format("{0:D2}.{1:D2}.{2:D2}.{3:D2}", 
				dualWord / 1000000, 
				dualWord / 10000 % 100, 
				dualWord / 100 % 100,
				dualWord % 100);

			str += "sum = " + sum;

			return str;
		}
	}
}
