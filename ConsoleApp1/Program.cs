using Game.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("輸入數字");
			string input = Console.ReadLine();
			if (string.IsNullOrEmpty(input)) Console.WriteLine("您沒輸入");
			string[] value = input.Split(null);
			bool isInt = int.TryParse(input, out int guessnumber);
			foreach (var item in value)
			{
				Console.Write(item);
			}

		}
	}
}
