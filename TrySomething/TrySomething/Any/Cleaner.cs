using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrySomething
{
	public class Cleaner : Starter
	{
		public override void Start()
		{
			string[] cleaned = Cleaner.GetCleaned();

			foreach (var s in cleaned)
			{
				Console.WriteLine(s);
			}
		}

		private static string[] GetCleaned()
		{
			var names = new List<string[]>
			{
				new string[]{ "", "Cкорость (0) включения (1) коррекции (11) вязкости,,,", "", "" },
				new string[]{ "", "Задержка прибора, Бод.", "Задержка", "" },
				new string[]{ "", " Задержка прибора, Бод.", "Задержка", "" },
                new string[]{ "", "Обнуление глобальных объемов по ModBus, у.е.", "", "" },
                new string[]{ "", "Схема уcтановки датчиков (для ModBus) ОСН.ПАРАМ. 1 канал (0), бод", "", "" },
				new string[]{ "", "Флаг включения коррекции вязкости, у.е. ОБРАБ.РЕЗ. 1 канал (0)", "", "м3" },
				new string[]{ "", "Флаг включения коррекции плотности у.е. ОБРАБ. РЕЗ. 2 канал (111)", "", "" },
				new string[]{ "", "Флаг включения коррекции плотности Δ Δ Δ Δ Δ у.е. ОБРАБ. Р. 2 канал (111)", "", "" },
				new string[]{ "", "Диапазон работы токового выхода, мА ТОКОВЫЙ ВЫХОД 1 (0)", "", "мА" },
				new string[]{ "", "Нижняя граница универсального выхода, м3/ч УНИВЕРС. ВЫХОД 0 (0)", "", "" },
				new string[]{ "", "Скорость УЗ в стенке, км/с Сст. 0 (0)", "Cст", "" }, //Сст. Ccт
				new string[]{ "", "Вязкость, cCт η 0 (0)", "η", "" },
				new string[]{ "", "Cкорость обмена по RS232 Первичника м/с, Бод.", "Скорость", "м/с" },
			};


			return names.Select(n =>
			{
				string measureUnit = GetMeasureUnit(n[1], n[3]);
				return CleanName(n[1], PrepareStringCaption(n[2]), measureUnit);
			}).ToArray();
		}

		private static string CleanName(string nameField, string nameInDevice, string measureUnit)
		{
			string ye_pattern = @",?\s?[YyУу]\.[EeЕе]\.";
			string bod_pattern = @",?\s?[Бб][Оо][Дд]\.?";
			string upperCaseRussianAndDots = @"\b[А-Я]{3,}\b\.?\s?(\b[А-Я]{1,}\b\.?)?\s?(\b[А-Я]{1,}\b\.?)?";
			string numberInBrackets = @"[(]\d{1,}[)]";

			Match channelMatch = Regex.Match(nameField, numberInBrackets);
			string channelStr = Regex.Match(channelMatch.Value, @"\d").Value;

			var allPatterns = new List<string>()
			{
				ye_pattern,
				bod_pattern,
				upperCaseRussianAndDots,
				numberInBrackets
			};

			nameField = ReplaceAll(nameField, " ", allPatterns);

			if (measureUnit != "")
			{
				string measurePattern = @"\s\b" + Regex.Escape(measureUnit) + @"\b\s";
				Regex r = new Regex(measurePattern, RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
				nameField = r.Replace(nameField, "");
			}

			if (nameInDevice != "")
			{
				string nameInDevicePattern = @".{1}\b" + Regex.Escape(nameInDevice) + @"\b\.?";
				Regex r = new Regex(nameInDevicePattern, RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
				nameField = r.Replace(nameField, "");
			}

			nameField = Regex.Replace(nameField, "Δ", "delta");
			string comma_pattern = @"\,{1,}$";
			nameField = Regex.Replace(nameField, comma_pattern, "");
			string doubleSpaces_pattern = @"\s{2,}";
			nameField = Regex.Replace(nameField, doubleSpaces_pattern, " ");

			return nameField + " " + channelStr;
		}

		private static string GetMeasureUnit(string nameField, string measureUnit)
		{
			if (measureUnit != "") return PrepareStringCaption(measureUnit);

			return PrepareStringCaption(measureUnit);
		}

		public static string PrepareStringCaption(string caption)
		{
			return caption.RemoveSpaces();
		}
		
		private static string ReplaceAll(string input, string replacement, List<string> patterns)
		{
			return patterns.Aggregate(input, (outValue, next) => Regex.Replace(outValue, next, replacement));
		}

		//private static string ConvertToRus(string input)
		//{
		//	input.Where.ToCharArray()
		//}
	}

	internal static class CleanerExt
	{
		public static string RemoveSpaces(this string input)
		{
			return new string(input
				.Where(c => !Char.IsWhiteSpace(c) && (c != '_'))
				.ToArray());
		}
	}
}
