using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySomething.Any
{
	public class TextMagic : Starter
	{
		#region Описание
		// Смеха ради, в одну строку, решил задачу поиска предложения, в котором больше всего встречается слов из другой строки.
		#endregion
		public override void Start()
		{
			string text = "Не следует, однако, забывать о том, что реализация намеченного плана развития играет важную роль в формировании системы масштабного изменения ряда параметров! Разнообразный и богатый опыт сложившаяся структура организации требует определения и уточнения соответствующих условий активизации. Соображения высшего порядка, а также повышение уровня гражданского сознания представляет собой интересный эксперимент проверки направлений прогрессивного развития. Равным образом реализация намеченного плана развития требует от нас системного анализа позиций, занимаемых участниками в отношении поставленных задач? Повседневная практика показывает, что повышение уровня гражданского сознания требует от нас системного анализа существующих финансовых и административных условий!Соображения высшего порядка, а также сложившаяся структура организации требует определения и уточнения системы масштабного изменения ряда параметров.Разнообразный и богатый опыт постоянный количественный рост и сфера нашей активности в значительной степени обуславливает создание позиций, занимаемых участниками в отношении поставленных задач.";
			string targetSentence = "Соображения требует уточнения системы";

			Console.WriteLine("GetMostSimilar4Fun:" + Environment.NewLine + GetMostSimilar4Fun(text, targetSentence));
			Console.WriteLine();
			Console.WriteLine("GetMostSimilar:" + Environment.NewLine + GetMostSimilar(text, targetSentence));
		}

		// 4Fun сделал 
		private string GetMostSimilar4Fun(string text, string targetSentence)
		{
			return text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)[text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(s => s.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)).Select(words => words.Intersect(targetSentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)).Count()).ToList().FindIndex(item => item == text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(s => s.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)).Select(words => words.Intersect(targetSentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)).Count()).Max())];
		}

		private string GetMostSimilar(string text, string targetSentence)
		{
			var sentences = text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

			var sentencesWords = sentences.ToList().Select(s => s.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries));

			var targetSentenceWords = targetSentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

			var intersectCount = sentencesWords.Select(words => words.Intersect(targetSentenceWords).Count());

			int index = intersectCount.ToList().FindIndex(item => item == intersectCount.Max());

			string result = sentences[index];

			return result;
		}
	}
}
