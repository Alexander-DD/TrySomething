using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomething.Any
{
	public class MyComparer : Starter
	{
		protected Dictionary<string, DecimalPlace> DecimalPlaces66CDE = new Dictionary<string, DecimalPlace>();

		protected Dictionary<string, DecimalPlace> DecimalPlaces66B = new Dictionary<string, DecimalPlace>();



		private List<string> matches = new List<string>();

		private List<Tuple<string, string>> notMatches = new List<Tuple<string, string>>();

		private List<string> outs = new List<string>();

		public MyComparer()
		{
			DecimalPlaces66CDE["151"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["137"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["120"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["158"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(0), new int?());
			DecimalPlaces66CDE["170"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["147"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["171"] = new DecimalPlace(new int?(), new int?(0), -1, -1, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66CDE["172"] = new DecimalPlace(new int?(), new int?(0), -1, -1, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66CDE["178"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["179"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["180"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["181"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["182"] = new DecimalPlace(new int?(), new int?(0), -1, -1, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66CDE["184"] = new DecimalPlace(new int?(1), new int?(), 3, 3, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["107"] = new DecimalPlace(new int?(1), new int?(), 3, 3, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["138"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["183"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["185"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["186"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(2), new int?(0), new int?());
			DecimalPlaces66CDE["187"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["188"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["189"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["191"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66CDE["192"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66CDE["193"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66CDE["000"] = new DecimalPlace(new int?(), new int?(3), 2, 2, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["001"] = new DecimalPlace(new int?(), new int?(3), 2, 2, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["002"] = new DecimalPlace(new int?(), new int?(3), 2, 2, new int?(), new int?(1), new int?(), new int?(1));
			DecimalPlaces66CDE["003"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66CDE["004"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66CDE["005"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66CDE["006"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(0), new int?(), new int?(1));
			DecimalPlaces66CDE["007"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(0), new int?(), new int?(1));
			DecimalPlaces66CDE["008"] = new DecimalPlace(new int?(), new int?(3), 2, 2, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["009"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["147"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["148"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["166"] = new DecimalPlace(new int?(), new int?(0), -1, -1, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66CDE["167"] = new DecimalPlace(new int?(), new int?(0), -1, -1, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66CDE["175"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["176"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["177"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["108"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["109"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["110"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["111"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["112"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["113"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["114"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["115"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["116"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["117"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["118"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["119"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["121"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["122"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["123"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["124"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["125"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["126"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["127"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["128"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["129"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["130"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["131"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["132"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["133"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["134"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["135"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["136"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["139"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["140"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["141"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["142"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["143"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["144"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["145"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["146"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66CDE["152"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["153"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["156"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["157"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["163"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["164"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["165"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["168"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66CDE["169"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(0), new int?());
			DecimalPlaces66CDE["173"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(1), new int?(), new int?(2));

			DecimalPlaces66B["000"] = new DecimalPlace(new int?(), new int?(3), 2, 2, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66B["001"] = new DecimalPlace(new int?(), new int?(3), 2, 2, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66B["002"] = new DecimalPlace(new int?(), new int?(3), 2, 2, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66B["003"] = new DecimalPlace(new int?(), new int?(2), 2, 1, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66B["004"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66B["005"] = new DecimalPlace(new int?(), new int?(1), 1, 0, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66B["006"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(0), new int?(), new int?(1));
			DecimalPlaces66B["007"] = new DecimalPlace(new int?(), new int?(1), 1, 0, new int?(), new int?(0), new int?(), new int?(1));
			DecimalPlaces66B["008"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(0), new int?(), new int?(1));
			DecimalPlaces66B["009"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66B["108"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["109"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["110"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["111"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["112"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["113"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["114"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["115"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["116"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["117"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["118"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["119"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["120"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["121"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["122"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["123"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["124"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["125"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["126"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["127"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["129"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["130"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["131"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["132"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["133"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["134"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["135"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["136"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["137"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["139"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["140"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["141"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["142"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66B["143"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66B["144"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66B["145"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66B["146"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66B["147"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66B["148"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66B["151"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["152"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["153"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["156"] = new DecimalPlace(new int?(), new int?(2), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["157"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["157"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(0), new int?());
			DecimalPlaces66B["163"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["164"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["165"] = new DecimalPlace(new int?(0), new int?(3), 2, 2, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["166"] = new DecimalPlace(new int?(), new int?(0), -1, -1, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66B["167"] = new DecimalPlace(new int?(), new int?(0), -1, -1, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66B["168"] = new DecimalPlace(new int?(), new int?(2), 1, 1, new int?(0), new int?(), new int?(1), new int?());
			DecimalPlaces66B["169"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(0), new int?());
			DecimalPlaces66B["170"] = new DecimalPlace(new int?(), new int?(1), 0, 0, new int?(), new int?(2), new int?(), new int?(3));
			DecimalPlaces66B["171"] = new DecimalPlace(new int?(), new int?(0), -1, -1, new int?(), new int?(1), new int?(), new int?(2));
			DecimalPlaces66B["172"] = new DecimalPlace(new int?(), new int?(0), -1, -1, new int?(), new int?(1), new int?(), new int?(2));
		}

		public override void Start()
		{
			foreach(var dp66B in DecimalPlaces66B)
			{
				string dp66Bstr = dp66B.Value.ToString();

				DecimalPlace dp;
				if (DecimalPlaces66CDE.TryGetValue(dp66B.Key, out dp))
				{
					string dpstr = dp.ToString();

					if (dp66Bstr == dpstr)
					{
						matches.Add(dp66B.Key + ": " + dp.ToString());
					}
					else
					{
						notMatches.Add(new Tuple<string, string>(dp66B.Key + ": " + dp66Bstr, dpstr));
					}
				}
				else
				{
					outs.Add(dp66B.Key);
				}
			}

			Console.WriteLine("Совпали и ключи и значения:");
			foreach(var s in matches)
			{
				Console.WriteLine(s);
			}


			Console.WriteLine("Ключи совпали, значения нет:");
			foreach (var s in notMatches)
			{
				Console.WriteLine(s.Item1 + ", " + s.Item2);
			}

			Console.WriteLine("Ключ не найден");
			foreach (var s in outs)
			{
				Console.WriteLine(s);
			}
		}
	}
}
