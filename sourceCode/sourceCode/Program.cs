//tinh tong cac phan tu trong mang

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
Console.Write("--------------------------------------------------------------------------");

// tinh tong chan cua mang
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
            int tongChan = sumOfEven(array);
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + " ");               
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cua mang la: {tongChan}");
            Console.ReadKey();
        }
        static int sumOfEven (int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] %2 == 0)
                {
                    sum += array[i];
                }
                
            }
            return sum;
        }
    }
}

Console.Write("-------------------------------------------------------------------");

// tinh tong le cua mang

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace tinhSoLeCuaMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap phan tu cua mang a[{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int tongLe = sumOfOdd(array);
            Console.WriteLine($"Tong le cua mang la: {tongLe} ");
            Console.ReadKey();
        }
        static int sumOfOdd(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++ )
            {
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}

Console.Write("-----------------------------------------------------------------------------------");



