using System;
namespace Task2
{
	public class Array
	{
		/// <summary>
		/// Заполняет переданный массив данным в ТЗ способом.
		/// </summary>
		/// <param name="k">сдвиг</param>
		/// <param name="B">переданный массив</param>
		/// <param name="C">измененный массив.</param>
		public static void ChangedArray(int k, ref double[][] B, out double[][] C)
		{
			C = new double[B.Length][];
			for(int i =0; i< B.Length; i++)
			{
				C[i] = new double[B[i].Length];
				for(int j = 0; j < B[i].Length; j++)
				{
					C[i][j] = B[i][(j + k) % B[i].Length];
				}
			}
		}
		/// <summary>
		/// Выводит массив в терминал.
		/// </summary>
		/// <param name="A">массив.</param>
		public static void PrintArray(ref double[][] A)
		{
			for(int i = 0; i < A.Length; i++) 
			{
				for(int j = 0; j < A[i].Length; j++)
				{
					Console.Write($"{A[i][j]} ");
				}
			}
			Console.WriteLine();
		}
	}
}

