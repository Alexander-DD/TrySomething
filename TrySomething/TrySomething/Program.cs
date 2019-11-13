using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrySomething.Any;

namespace TrySomething
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			var starters = new List<Starter>();

			starters.Add(new Vkt2m());
			starters.Add(new ParseSoftwareVersionTem104());
			starters.Add(new ByteToInt());
			starters.Add(new Ifelse());
			starters.Add(new ParseIdentificator());
			starters.Add(new ParseJournal());
			starters.Add(new PrimeNumbers());
			starters.Add(new Cleaner());
			starters.Add(new StringEquals());
			starters.Add(new BitsParser());
			starters.Add(new MyComparer());
			starters.Add(new ArchiveHelper());
			starters.Add(new TextMagic());
			starters.Add(new DeleteStrings());
			starters.Add(new MyEnumAttribute());
			//starters.Add();

			while (true)
			{
				Console.WriteLine("Menu:");

				for (int i = 0; i < starters.Count; i++)
				{
					Console.WriteLine(i + ") " + starters[i].GetClassName());
				}

				Console.Write("Enter any number, or 'q' to quit: ");

				string str = Console.ReadLine();

				if (str == "q") return;

				if (int.TryParse(str, out int index))
				{
					Console.WriteLine(Environment.NewLine + "*Start " + starters[index].GetClassName() + "*");
					starters[index].Start();
					Console.WriteLine("*End " + starters[index].GetClassName() + "*" + Environment.NewLine);
				}
			}
		}
	}


}
