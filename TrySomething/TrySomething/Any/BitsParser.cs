using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomething
{
	public class BitsParser : Starter
	{
		public override void Start()
		{
			int format = 86;//1207766;//2097151;//2147483647;//4095;

			var stages = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 };
	
			Console.WriteLine("orig => " + Convert.ToString(format, 2));

			stages.ForEach(s => Console.WriteLine(IsHavingNextArchive(format, s) + " readcode: " + getNextReadCode(format, s)));
		}

		private int getNextReadCode(int format, int stage) 
		{
			int readCode = 0;
			if (GetOffsetByStage(format, stage, out readCode)) 
			{
				return readCode;
			}
			return -1;
		}

		private bool IsHavingNextArchive(int format, int stage)
		{
			int offset;
			return GetOffsetByStage(format, stage, out offset);
		}
		

		private bool GetOffsetByStage(int format, int stage, out int offset) 
		{
			offset = 0;
			while (stage >= 0)
			{
				if (!HaveNext(format, offset))
				{
					return false;
				}

				offset = FindNextArchiveByOffset(format, offset);
				stage--;
				if (stage >= 0)
				{
					offset++;
				}
			}
			return true;
		}		
		
		private int FindNextArchiveByOffset(int format, int offset) 
		{
			while (((format >> offset) & 1) == 0)
			{
				offset++;
			}
			return offset;
		}

		private bool HaveNext(int format, int offset)
		{
			return format >> offset != 0;
		}
	}
}
