﻿using NumericAlgorithms;
using TestAlgoritms.Types;

namespace TestAlgoritms {
	public class Program
	{
		static void Main(string[] args)
		{
			ChooseNumericalAlgoritms();
		}

		private static void ChooseNumericalAlgoritms()
		{
			Console.WriteLine("Choose numerical algorithm:\n" +
				"1. Greatest common divisor\n" +
				"2. Fast power");

			var selection = ReadSelection();
			if (Enum.TryParse(selection.ToString(), false, out NumericAlgorithmsEnum result))
			//TODO Нужна фабрика по вызову метода выбранного алгоритма.
				

			if (selection == -1)
				return;
		}

		/// <summary>
		/// Method trying to read users selection
		/// </summary>
		/// <returns>Number of selection, or -1 if "Escape" key pressed</returns>
		private static int ReadSelection()
		{
			var input = Console.ReadLine();

			if (!int.TryParse(input, out int selection))
			{
				Console.WriteLine("Wrong input! Please enter right value.\nIf you want to close application enter ESC");

				var key = Console.ReadKey();
				if (key.Key != ConsoleKey.Escape)
					ReadSelection();
				else
					return -1;
			}

			return selection;
		}
	}
}