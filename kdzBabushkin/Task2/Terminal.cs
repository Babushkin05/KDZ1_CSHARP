namespace Task2
{
	public class Terminal
	{
        /// <summary>
        /// Принимает имя файла и проверяет на корректность.
        /// </summary>
        /// <returns></returns>
		private static string FileName()
		{
			Console.Clear();

            string fileName;
            bool correctPath;
            do
            {
                Console.Write("Введите имя файла, для чтения данных (без формата '.txt') ::  ");
                fileName = Console.ReadLine() + ".txt";

                correctPath = File.Exists(fileName);

                if (!correctPath)
                    Console.WriteLine("ОШИБКА!!! Попробуйте снова.");
            } while (!correctPath);

            return "../../../../"+fileName;
        }
        /// <summary>
        /// Возвращает считанный массив их файла.
        /// </summary>
        /// <returns></returns>
        public static double[][] GetArray()
        {
            double[][] B;
            bool isContinue;
            do
            {
                string fileName = FileName();
                isContinue = ReadFile.ParseArray(fileName, out B);
                if(!isContinue)
                    Console.WriteLine("ОШИБКА!!! Попробуйте снова.");

            } while (!isContinue);
            return B;
        }

        /// <summary>
        /// Выводит измененный массив и возвращает желание польхзователя возвращать.
        /// </summary>
        /// <param name="B">массив для изменения</param>
        /// <param name="isRepeat">повтор программы</param>
        public static void ReadChangedArray(ref double[][] B, ref bool isRepeat)
        {
            int k;
            bool isContinue;
            do
            {
                Console.Write("Введите сдвиг ::  ");
                isContinue = int.TryParse(Console.ReadLine(), out k) && k>=0;
                if (!isContinue)
                    Console.WriteLine("ОШИБКА!!! Попробуйте снова.");
            } while (!isContinue);

            double[][] C;
            Array.ChangedArray(k, ref B,out C);

            Console.WriteLine("Данные до:");
            Array.PrintArray(ref B);
            Console.WriteLine("Данные после:");
            Array.PrintArray(ref C);

            Console.WriteLine("Напишите 'yes' чтобы повторить программу и любую другую строку чтобы завершть");
            isRepeat = (Console.ReadLine()?.ToLower() == "yes");
        }
	}
}

