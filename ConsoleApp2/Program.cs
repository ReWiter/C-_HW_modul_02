using System;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            double[,] B = new double[3, 4];
            int max = 0;
            int min = 100;
            int tsum = 0;
            int chsum = 0;
            int tdou = 1;
            double tmax = 0;
            double tmin = 100;
            double sum = 0;
            double tchsum = 0;
            double dou = 1;
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rand.Next(0, 100);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" {0} ", A[i]);
                tsum += A[i];
                tdou *= A[i];
                if (A[i] > max)
                {
                    max = A[i];
                }
                if (A[i] < min)
                {
                    min = A[i];
                }
                if (A[i] % 2 == 0)
                {
                    chsum += A[i];
                }
            }
            Console.WriteLine($"MAX = {max}, MIN = {min}, SUMM = {tsum}, PROIZ = {tdou}, SUMMCH = {chsum}");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0} ", B[i, j]);
                    sum += B[i, j];
                    dou *= B[i, j];
                    if (B[i, j] > max)
                    {
                        tmax = B[i, j];
                    }
                    if (B[i, j] < min)
                    {
                        tmin = B[i, j];
                    }
                    if (B[i, j] % 2 != 0)
                    {
                        tchsum += B[i, j];
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine($"MAX = {tmax}, MIN = {tmin}, SUMM = {sum}, PROIZ = {dou}, SUMMCH = {tchsum}");
        }
    }
} // №1
namespace ConsoleApp2
{
    class Prog
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] arr = new int[5, 5];
            int max = -100;
            int min = 100;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" {0} ", arr[i, j]);
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] > min && arr[i, j] < max)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумма в диапазоне {min} - {max} = {sum}");
        }
    }
}  // №2
namespace ConsoleApp3
{
    class Prog
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            var alf = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            var allalf = alf + alf.ToLower();
            int let = allalf.Length;
            var vari = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = allalf.IndexOf(c);
                if (index < 0)
                {
                    vari += c.ToString();
                }
                else
                {
                    var CodeIndex = (let + index + k) % let;
                    vari += allalf[CodeIndex];
                }

            }
            Console.WriteLine(vari);
        }
    }
} // №3
namespace ConsoleApp4
{
    class Prog
    {
        static void Print(int[,] arr)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" {0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[5, 5];
            int[,] arr2 = new int[5, 5];
            int[,] arr3 = new int[5, 5];
            int[,] arr4 = new int[5, 5];
            int[,] arr5 = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(0, 100);
                }
            }
            Print(arr);
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr2[i, j] = rand.Next(0, 100);
                }
            }
            Print(arr2);
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr3[i, j] = arr[i, j] * a;
                }
            }
            Print(arr3);
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr4[i, j] = arr[i, j] + arr2[i, j];
                }
            }
            Print(arr4);
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr5[i, j] = arr[i, j] * arr2[i, j];
                }
            }
            Print(arr5);
            Console.WriteLine();
        }
    }
} //№4
namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите арифметическое выражение (числа и операции через пробел): ");
            string ff = Console.ReadLine();
            string[] numbers = ff.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int res = 0, num1 = 0;
            bool plus = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out num1))
                {
                    if (plus)
                    {
                        res = res + num1;
                    }
                    else
                    {
                        res = res - num1;
                    }
                }
                else
                {
                    if (numbers[i] == "+")
                    {
                        plus = true;
                    }
                    else
                    {
                        plus = false;
                    }
                }
            }
            Console.WriteLine(res);
        }
    }
}  //№5
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(str[0].ToString().ToUpper());
            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]) && char.IsWhiteSpace(str[i - 1]) && ".!?".IndexOf(str[i - 2]) != -1)
                {
                    stringBuilder.Append(str[i].ToString().ToUpper());
                }
                else
                {
                    stringBuilder.Append(str[i]);
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
} // №6
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] st = str.Split(new char[] { ' ', ',', ':', ';' });
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == "die")
                {
                    st[i] = "***";
                }
                else
                {
                    st[i] = st[i];
                }
            }
            for (int i = 0; i < st.Length; i++)
            {
                Console.Write("{0} ", st[i]);
            }
        }
    }
}// №7