using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomething
{
	public abstract class Starter
	{
		public string GetClassName()
		{
			return GetType().ToString();
		}

		public abstract void Start();
	}
}
