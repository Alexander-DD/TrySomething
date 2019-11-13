using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrySomething
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Clear_Click(object sender, EventArgs e)
		{
			string text = textBox1.Text;
			string[] lines = text.Split(new[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
			lines = lines.Where(line => line.Contains("Закончился таймаут ожидания ответа прибора") || line.Contains("Посылаем запрос:") || line.Contains("Обработка данных:")).ToArray();

			textBox1.Text = string.Join("\r\n", lines);
		}

	}
}
