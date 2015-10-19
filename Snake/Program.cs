using System;

namespace Snake
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int x1 = 1;
			int y1 = 5;
			char sym1 = '*';

			Draw(1,3,'*');
			Draw(2,6,'#');

			Console.ReadKey();
		}

		static void Draw (int x, int y, char sym)
		{
			Console.SetCursorPosition (x, y);
			Console.Write (sym);
		}
	}
}
