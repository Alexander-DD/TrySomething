using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomething
{
	public class Ifelse : Starter
	{
		public override void Start()
		{
			int count = 0;
			int haha = 0;

			for (int index = 0; index < 4; haha = ++index)
			{
				Console.WriteLine("1haha " + haha);
				Console.WriteLine("1i " + index);
				count++;
			}

			for (int index = 0; index < 4; haha = index++)
			{
				Console.WriteLine("2haha " + haha);
				Console.WriteLine("2i " + index);
				count++;
			}


			Console.WriteLine("count " + count);
		}
	}
}
