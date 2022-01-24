using System;

namespace HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            var index = Console.ReadLine();
            var result = int.TryParse(index, out var number);
            if (result == true)
            {
                Console.WriteLine("You entered a number");
            }

            if (result == false)
            {
                Console.WriteLine("The program will not start executing until a number is entered.");
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

            var oddArr = new int?[arr.Length];
            var evenArr = new int?[arr.Length];
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[length] = arr[i];

                    length++;
                }
                else
                {
                    oddArr[oddindex] = arr[i];
                    oddindex++;
                }
            }

            Console.WriteLine("Array with even values");
            foreach (var item in evenArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Array with odd values");
            foreach (var item in oddArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Change numbers to letters");
            var strArr1 = string.Empty;
            foreach (var item in evenArr)
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

            Console.WriteLine("even letters");
            foreach (var item in strArr1)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            Console.WriteLine("odd letters");
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
            Console.WriteLine("Display even letters with uppercase characters");
            Console.WriteLine(strArr1);

            strArr2 = strArr2.Replace('a', 'A');
            strArr2 = strArr2.Replace('e', 'E');
            strArr2 = strArr2.Replace('i', 'I');
            Console.WriteLine("Display odd letters with uppercase characters");
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

            Console.WriteLine("Output an array with more uppercase characters ");
            if (value1 > value2)
            {
                Console.WriteLine("Even array");
                Console.WriteLine(strArr1);
            }

            if (value1 < value2)
            {
                Console.WriteLine("odd array");
                Console.WriteLine(strArr2);
            }

            if (value1 == value2)
            {
                Console.WriteLine("the number of uppercase characters is the same");
                Console.WriteLine(strArr1);
                Console.WriteLine(strArr2);
            }
        }
    }
}
