using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomething
{
	public class PrimeNumbers : Starter
	{
		private static Random rand = new Random();
		private int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

		public override void Start()
		{
			var all = GetRandomNumberMassives(10, 5);

			List<int>[] aaa = 
			{
				new List<int> {1,2,3},
				new List<int> {1,2,3},
				new List<int> {4,3,7},
				new List<int> {5,8,2}
			};

			for (int i = 1; i < all.Length; i++) 
			{
				for (int j = 0; j < i; j++)
				{
					if (!all[j].EqualsMy(all[i]))
					{							
						Console.WriteLine("Not success");
					} 
				}
			}

			//if (aaa.GroupBy(list => list).Any(g => g.Count() > 1))
			//{
				
			//}

			var converted = all.AsEnumerable().Select(a => Convert(a));

			foreach(var ct in converted)
				Console.WriteLine(ct);

			var duples = converted
				.GroupBy(item => item)
				.Any(g => g.Count() > 1);

			if(duples)
			{
				Console.WriteLine("Having Duples!!!!!!!!!!!!!!!!!!!!!");
			}
		}
		
		private List<int>[] GetRandomNumberMassives(int countMassives, int countNumbers) 
		{
			var mass = new List<int>[countMassives];

			for (int i = 0; i < countMassives; i++) 
			{
				mass[i] = new List<int> (GetRandomNumbers(countNumbers));
			}
			return mass;
		}

		private List<int> GetRandomNumbers(int countNumbers)
		{
			var mass = new List<int>();
			
			for (int i = 0; i < countNumbers; i++) 
				mass.Add(rand.Next(1, 101));
			return mass;
		}

		private int Convert(List<int> targetNumbers) 
		{
			int sum = 0;
			for (int i = 0; i < targetNumbers.Count; i++) 
			{
				sum += targetNumbers[i] * primes[i];
			}
			return sum;
		}

		private List<int> Deconvert(int targetNumbers)
		{
			throw new Exception();
		}

	}

	internal static class ListExt	
	{
		public static bool EqualsMy(this List<int> list1, List<int> list2)
		{
			bool res = true;
			for (int i = 0; i < list1.Count; i++)
			{
				if (list1[i] != list2[i]){
					return false;
				}
			}
			return res;
		}
	
	}
}
