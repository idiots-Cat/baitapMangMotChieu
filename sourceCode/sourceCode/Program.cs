using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sourceCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap mang Array[{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int tong = sumArray(array);
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + " ");               
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cua mang la: {tong}");
            Console.ReadKey();
        }
        static int sumArray (int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
