using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
	class Program
	{
		static void Main(string[] args)
		{
			// Сформировать одномерный массив из нечет элементов двумерного,либо вывести сообщение "Таких элементов нету"
			int i, j, n, m, kol;
			Console.WriteLine("Введите количество строк");
			n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите количество столбцов");
			m = Convert.ToInt32(Console.ReadLine());
			int[,] arr = new int[n, m];
			Console.WriteLine("Введите элементы массива");
			for (i = 0; i < n; i++)
				for (j = 0; j < m; j++)
					arr[i, j] = Convert.ToInt32(Console.ReadLine());
			for (i = 0; i < n; i++)
			{
				Console.WriteLine();
				for (j = 0; j < m; j++)
					Console.Write(arr[i, j] + " ");
			}
			int[] arr1 = new int[n * m];
			kol = 0;
			for (i = 0; i < n; i++)
				for (j = 0; j < m; j++)
					if (arr[i,j]%2!=0)
					{
						arr1[kol] = arr[i, j];
						kol++;
					}
			if (kol == 0)
				Console.WriteLine("Таких элементов нету");
			else
				for (i = 0; i < kol; i++)
					Console.Write(arr1[i] + "");
					Console.ReadKey();
		}   
	}
}
