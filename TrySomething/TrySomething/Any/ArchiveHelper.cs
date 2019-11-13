using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomething
{
	class ArchiveHelper : Starter
	{
		// Словарь соотношения символов в заголовках архивных полей Eng - Rus
		public static ReadOnlyDictionary<char, char> LetterDublers;

		static ArchiveHelper()
		{
			Dictionary<char, char> letterDublers = new Dictionary<char, char>();
			letterDublers.Add('A', 'А');
			letterDublers.Add('B', 'В');
			letterDublers.Add('C', 'С');
			letterDublers.Add('E', 'Е');
			letterDublers.Add('H', 'Н');
			letterDublers.Add('K', 'К');
			letterDublers.Add('M', 'М');
			letterDublers.Add('O', 'О');
			letterDublers.Add('P', 'Р');
			letterDublers.Add('T', 'Т');
			letterDublers.Add('X', 'Х');
			letterDublers.Add('Y', 'У');
			letterDublers.Add('a', 'а');
			letterDublers.Add('c', 'с');
			letterDublers.Add('e', 'е');
			letterDublers.Add('k', 'к');
			letterDublers.Add('o', 'о');
			letterDublers.Add('p', 'р');
			letterDublers.Add('x', 'х');
			LetterDublers = new ReadOnlyDictionary<char, char>(letterDublers);
		}

		/// <summary>
		/// Процедура сравнения с точностью до изображения
		/// </summary>
		public static bool EqualFieldNames(string fieldName1, string fieldName2)
		{
			if (fieldName1 == fieldName2) return true;

			if (fieldName1.Length == fieldName2.Length)
			{
				char tempChar;

				for (int i = 0; i < fieldName1.Length; i++)
				{
					if (fieldName1[i] != fieldName2[i])
					{
						// Символы разные
						if (!((LetterDublers.TryGetValue(fieldName1[i], out tempChar) && fieldName2[i] == tempChar) || (LetterDublers.TryGetValue(fieldName2[i], out tempChar) && fieldName1[i] == tempChar)))
						{
							// Пары найти не удалось, значит точно разные
							return false;
						}
					}
				}

				return true;
			}

			return false;
		}

		public override void Start()
		{
			var fields = new List<Tuple<string, string>>();
			fields.Add(new Tuple<string, string>("АБРАКАДАБРА", "AБРAKАДАБРA"));
			fields.Add(new Tuple<string, string>("", ""));
			fields.Add(new Tuple<string, string>("АБРАКАДАБРА", ""));

			foreach (var field in fields)
			{
				Console.WriteLine("\"" + field.Item1 + "\" vs \"" + field.Item2 + "\"" + (EqualFieldNames(field.Item1, field.Item2) ? " - Equal" : " - Not Equal"));
			}
		}
	}
}
