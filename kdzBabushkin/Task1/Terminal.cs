namespace Task1
{
	public class Terminal
	{
		public static void Input(out int N)
		{
			Console.Clear();

			//Заводим константы для сравнения с введеным значением.
			const int minValue = 1;
			const int maxValue = 20;
			//Принимаем число N.
			do
			{
				Console.Write($"Введите N от {minValue} до {maxValue} включительно ::  ");
			} while (!int.TryParse(Console.ReadLine(), out N) || N < minValue || N > maxValue);
		}

		public static void Output(ref double[][] A, out bool isContinue)
		{
			// Принимаем имя файла.
			bool isRepeat;
			string fileName;
			do
			{
				isRepeat = false;
                Console.Write("Введите имя файла, для сохранения массива ::  ");
				fileName = Console.ReadLine() + ".txt";

				char[] invalidChars = Path.GetInvalidFileNameChars();
				foreach( char chr in fileName)
				{
					if (invalidChars.Contains(chr))
					{
						isRepeat = true;
					}
				}
            } while (isRepeat || fileName == ".txt");

            // Создаем файл.
            Array.FillFile(ref A, "../../../../"+fileName);

            // Принимаем решение о продолжении.
            Console.WriteLine("Файл создан. Напишите 'yes' чтобы продолжить и любую другую строку для завершения программы");

			isContinue = (Console.ReadLine()?.ToLower() == "yes");
		}
	}
}

