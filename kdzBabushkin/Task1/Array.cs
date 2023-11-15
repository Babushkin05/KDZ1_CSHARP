namespace Task1
{
	public class Array
	{

		public static void Init(int N, out double[][] A)
		{
			// Cоздаем константы для размеров массивов.
			const int minLen = 1;
			const int maxLen = 15;

			// Заполняем массив.
			A = new double[N][];
			int n = 1;
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
			{
				A[i] = new double[rnd.Next(maxLen - minLen)+1];
				for(int j = 0; j < A[i].Length; j++)
				{
					A[i][j] = Formula(n);
					n++;
				}
			}
		}

		private static double Formula(int n)
		{
			return Math.Sqrt(Math.Pow(n, 3) + 3.0) / (Math.Pow(n, 2) + 5.0);
		}

		public static void FillFile(ref double[][] A, string fileName)
		{
			// Создаем строку, которую запишем в файл.
			System.Text.StringBuilder dataToFile = new System.Text.StringBuilder();
			for(int i = 0; i < A.Length; i++)
			{
				for(int j = 0; j < A[i].Length; j++)
				{
					dataToFile.Append(Convert.ToString(Math.Round(A[i][j],3)) + "??");
				}
				dataToFile[^1] = '\n';
			}

			// Пишем в файл.
			File.WriteAllText(fileName, dataToFile.ToString());
		}
	}
}

