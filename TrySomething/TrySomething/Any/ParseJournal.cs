using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrySomething
{
	public class ParseJournal : Starter
	{
		public override void Start()
		{
			List<string> strings = new List<string>{ "1f 17.01.18 11:58:05 Режим:стандартный ->нет переводаэг",
								"12217.01.18 11:37:58 dTmax 4 канал: 0.000050 -> 0.6481003r", 
								"v4 11.11.11 11:11:11:->32",
								"v4 11.11.11 11:11:111:1->132"};

			strings.ForEach(s => Parse(s));
		}

		private void Parse(string str) 
		{
			var outStr = new List<string>();

			var split = new string[5];

			var responseString = str;

			if (responseString.Length < 22) // 22 символа, минимальное количество = размер записи (3 символа) + дата (17 символов) + контрольная сумма (2 символа). Например: "A6 17.01.18 11:58:05§а" - итого 22 символа.
			{
				Console.WriteLine("Строка имела не верный формат");
				return;
			}

			// Избавляемся от лишней информации в начале и конце.
			responseString = responseString.Substring(3, responseString.Length - 5).Trim();

			split[0] = new Regex(@"^\d{1,2}.\d{1,2}.\d{1,4} \d{1,2}:\d{1,2}:\d{1,2}", RegexOptions.Compiled).Match(responseString).Value;

			if (split[0] == "")
			{
				Console.WriteLine("Строка имела не верный формат");
				return;
			}

			responseString = new Regex(@".+:.+->.+", RegexOptions.Compiled).Match(responseString.Substring(split[0].Length)).Value.Trim();

			if (responseString == "")
			{
				Console.WriteLine("Строка имела не верный формат");
				return;
			}

			string paramAndChannel = new string(responseString.TakeWhile(c => c != ':').ToArray());

			responseString = responseString.Substring(paramAndChannel.Length + 1);

			paramAndChannel = paramAndChannel.Trim();

			var channelStr = new Regex(@"\d{1,2}\s?канал", RegexOptions.Compiled | RegexOptions.IgnoreCase).Match(paramAndChannel).Value.Trim();
			if (channelStr != "")
			{
				channelStr = Regex.Replace(channelStr, "канал", "", RegexOptions.Compiled | RegexOptions.IgnoreCase).Trim();
			}
			else
			{
				channelStr = new Regex(@"\d{1,2}\s?$", RegexOptions.Compiled).Match(paramAndChannel).Value.Trim();
			}

			if (channelStr != "")
			{
				int index = paramAndChannel.IndexOf(channelStr);
				split[1] = paramAndChannel.Substring(0, index).Trim();
				split[2] = channelStr;
			}
			else
			{
				split[1] = paramAndChannel;
				split[2] = "";
			}

			int indexOfArrow = responseString.IndexOf("->");

			split[3] = responseString.Substring(0, indexOfArrow).Trim();
			split[4] = responseString.Substring(indexOfArrow + 2).Trim();

			string strOut = "";

			foreach (var s in split) 
			{
				strOut += string.Format("\'{0}\' ", s);
			}

			Console.WriteLine(strOut);

		}
	}
}
