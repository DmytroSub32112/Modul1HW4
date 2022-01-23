using System;

namespace HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var index = Console.ReadLine();
            var result = int.TryParse(index, out var number);
            if (result == true)
            {
                Console.WriteLine("Вы ввели число");
            }

            if (result == false)
            {
                Console.WriteLine("Програма не начнет свое выполнение,пока не будет введено число");
            }

            Console.WriteLine("-------------------------");
            var str = " abcdefghijklmnopqrstuvwxyz";
            var length = 0;
            var oddindex = 0;
            var arr = new int[number];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1, 26);
            }

            var oddArr = new int[arr.Length];
            var honestArr = new int[arr.Length];
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    honestArr[length] = arr[i];

                    length++;
                }
                else
                {
                    oddArr[oddindex] = arr[i];
                    oddindex++;
                }
            }

            Console.WriteLine("Масив c четными значениями");
            foreach (var item in honestArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Масив c нечетными значениями");
            foreach (var item in oddArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Меняем цифры на буквы");
            var strArr1 = string.Empty;
            foreach (var item in honestArr)
            {
                for (var i = 0; i < str.Length; i++)
                {
                    if (item == i)
                    {
                        strArr1 += str[i];
                        i++;
                    }
                }
            }

            Console.WriteLine("четные буквы");
            foreach (var item in strArr1)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            Console.WriteLine("нечетные буквы");
            var strArr2 = string.Empty;
            foreach (var item in oddArr)
            {
                for (var i = 0; i < str.Length; i++)
                {
                    if (item == i)
                    {
                        strArr2 += str[i];
                        i++;
                    }
                }
            }

            foreach (var item in strArr2)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            Console.WriteLine("-------------------");
            strArr1 = strArr1.Replace('d', 'D');
            strArr1 = strArr1.Replace('h', 'H');
            strArr1 = strArr1.Replace('j', 'J');
            Console.WriteLine("Выводим четные буквы с символами в верхнем регистре");
            Console.WriteLine(strArr1);

            strArr2 = strArr2.Replace('a', 'A');
            strArr2 = strArr2.Replace('e', 'E');
            strArr2 = strArr2.Replace('i', 'I');
            Console.WriteLine("Выводим нечетные буквы с символами в верхнем регистре");
            Console.WriteLine(strArr2);
            var value1 = 0;
            var value2 = 0;
            foreach (var item in strArr1)
            {
                if (item.ToString().Contains("D") || item.ToString().Contains("H") || item.ToString().Contains("J"))
                {
                    value1++;
                }
            }

            foreach (var item in strArr2)
            {
                if (item.ToString().Contains("A") || item.ToString().Contains("E") || item.ToString().Contains("I"))
                {
                    value2++;
                }
            }

            Console.WriteLine("Выводим масив  с большем количеством символов в верхнем регистре ");
            if (value1 > value2)
            {
                Console.WriteLine("Четный масив");
                Console.WriteLine(strArr1);
            }

            if (value1 < value2)
            {
                Console.WriteLine("Нечетный масив");
                Console.WriteLine(strArr2);
            }

            if (value1 == value2)
            {
                Console.WriteLine("количество символов в верхнем регистре одинаково");
                Console.WriteLine(strArr1);
                Console.WriteLine(strArr2);
            }
        }
    }
}
