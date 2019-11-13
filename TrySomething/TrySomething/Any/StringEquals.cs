using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomething.Any
{
	public class StringEquals : Starter
	{
		public override void Start()
		{
			List<string> strs = new List<string> { "10", "11", "01", "00", "0", "1" , "00000001"};
			string val;
			for (int i =0; i< strs.Count; i++)
			{
				for (int j = 0; j < strs.Count; j++)
				{
					var heat1Flows = new List<int> { i, j };
					val = heat1Flows.Select(h => strs[h]).Min();
					Console.WriteLine(strs[i] + " vs " + strs[j] + " ? => " + val);
				}
			}
		}
	}
}
