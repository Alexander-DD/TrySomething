using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomething.Any
{
	public class DecimalPlace
	{
		public int? kWh;
		public int? MWh_Gcal;
		public int? Gj;
		public int? m3;
		public int? lhour;
		public int? m3hour;
		public int? kW;
		public int? MW;

		public DecimalPlace(int? kWh_, int? MWh_Gcal_, int? Gj_, int? m3_, int? lhour_, int? m3hour_, int? kW_, int? MW_)
		{
			this.kWh = kWh_;
			this.MWh_Gcal = MWh_Gcal_;
			this.Gj = Gj_;
			this.m3 = m3_;
			this.lhour = lhour_;
			this.m3hour = m3hour_;
			this.kW = kW_;
			this.MW = MW_;
		}

		public override string ToString()
		{
			return kWh + " " + MWh_Gcal + " " + Gj + " " + m3 + " " + lhour + " " + m3hour + " " + kW + " " + MW;
		}
	}
}
