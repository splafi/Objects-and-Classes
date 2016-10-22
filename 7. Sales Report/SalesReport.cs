using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            string[,] arr = new string[rows, 4];

            for (int row = 0; row < rows; row++)
            {
                string[] cells = Console.ReadLine().Split(' ').ToArray();

                for (int col = 0; col < 4; col++)
                {
                    arr[row, col] = cells[col];
                }
            }

            List<string> towns = new List<string>();

            towns.Add(arr[0, 0]);

            for (int i = 1; i < rows; i++)
            {
                if (!towns.Contains(arr[i, 0]))
                {
                    towns.Add(arr[i, 0]);
                }
            }
            towns.Sort();
            for (int i = 0; i < towns.Count; i++)
            {
                Console.Write(towns[i]);
                double tempResult = 0;
                double result = 0;
                for (int j = 0; j < rows; j++)
                {
                    if (arr[j, 0] == towns[i])
                    {
                        tempResult = double.Parse(arr[j, 2]) * double.Parse(arr[j, 3]);
                        result += tempResult;
                    }

                }
                Console.WriteLine(" -> {0:f2}", result);
            }

        }
    }
}


