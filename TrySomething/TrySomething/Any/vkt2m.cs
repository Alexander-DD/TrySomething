using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomething
{
	public class Vkt2m : Starter
	{
		public override void Start()
		{
			byte[] bytes = {0x78, 0x13, 0x30, 0x56};
			//byte buffer = 0x54;

			int buffer = BitConverter.ToInt32(bytes, 0);

			int offset = 12;
			int size = 10;

			int fswf32 = Convert.ToInt32(Math.Pow(2, size));

			buffer = buffer >> offset;
			buffer = buffer & (Convert.ToInt32(Math.Pow(2, size)) - 1);
			
			Console.WriteLine(buffer);
		}
	}
}
