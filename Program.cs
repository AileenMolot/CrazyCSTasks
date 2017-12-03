using System;

namespace CrazyCStasks
{
    class Program
    {
        static float GetAverage (int[] array)
        {
            float sum = 0;
            for (int i = 0; i< array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum/array.Length;
        }
        static int GetMult (int[] array)
        {
            int mult = 1;
            for (int i = 0; i< array.Length; i++)
            {
                mult = mult*array[i];
            }
            return mult;
        }
        static void Main(string[] args)
        {
            // 1 Задана послідовність А[N]. Знайти середнє арифметичне значень
            //елементів послідовності

            int [] newArray = new int [5] {5, 6, 3, 8, 2};
            //Console.WriteLine (GetAverage(newArray));

            // 2 Задана послідовність А[N]. Знайти добуток елементів послідовності

            //Console.WriteLine (GetMult(newArray));

            // 3 Задана послідовність А[N]. Знайти нову послідовність, збільшивши
            //кожне число вдвічі
            
            //  for (int i=0; i < newArray.Length; i++)
            //     {
            //         newArray[i] = newArray[i]*2;
            //         Console.WriteLine (newArray[i]);
            //     }

            // 4 Задана послідовність А[N]. Знайти нову послідовність, збільшивши
            //кожне число на суму елементів послідовності

            // int sum = 0;

            // for (int k = 0; k< newArray.Length; k++)
            //     sum = sum+ newArray[k];

            // for (int i = 0; i< newArray.Length; i++)
            // {
            //     newArray[i] = newArray[i]* sum;
            //     Console.WriteLine (newArray[i]);
            // }

            // 5 Задана послідовність чисел А[N] і деяке число, не рівне нулю.
            //Знайти нову послідовність, розділивши кожен елемент заданої
            //послідовності на задане число

            // float div = 2;
            // float [] floatArray = new float [5];
            // for (int i = 0; i< floatArray.Length; i++)
            // {
            //     floatArray[i] = newArray[i]/div;
            //     Console.WriteLine(floatArray[i]);
            // }

            // 6 Задана послідовність чисел А[N], не рівних нулю, і деяке число.
            //Знайти нову послідовність, розділивши задане число на кожний елемент
            //заданої послідовності

            // float divider = 100;
            // float [] newFlArr = new float [5];
            // for (int i = 0; i < newFlArr.Length; i++)
            //     {
            //         newFlArr[i] = divider/newArray[i];
            //         Console.WriteLine (newFlArr[i]);
            //     }

            // 7 Задана послідовність чисел А[N]. Перемістити елементи
            //послідовності у такому порядку: перший елемент на останню позицію
            //послідовності, останній елемент на першу позицію в послідовності,
            //другій елемент на передостанню позицію послідовності, передостанній
            //елемент на другу позицію, і т.д.

            // int buffer = 0;
            // for (int i = 0; i< newArray.Length/2; i++)
            // {
            //     buffer = newArray[newArray.Length - i - 1];
            //     newArray[newArray.Length - i - 1] = newArray[i];
            //     newArray[i] = buffer;
            // }
            // foreach (int el in newArray)
            //     Console.WriteLine (el);

            // 8 Задана послідовність чисел А[N] і деяке число. Знайти номер
            //входження числа в послідовність

            int [] array2 = new int [10] {2, 4, 5, 7, 2, 10, 16, 45, 10, 45};
            // int searchedNumber = 10;
            //int firstEnter = -1;
            // for (int i = 0; i < array2.Length;i++)
            // {
            //     if (array2[i] == searchedNumber)
            //         {
            //             firstEnter = i;
            //             break;
            //         }
            // }
            // Console.WriteLine (firstEnter);

            // 9 Задана послідовність чисел А[N] і деяке число. Знайти кількість
            //всіх входжень числа в послідовність

            // int count = 0;
            // for (int i = 0; i < array2.Length;i++)
            // {
            //     if (array2[i] == searchedNumber)
            //         {
            //             count = count +1;
            //         }
            // }
            // Console.WriteLine (count);

            // 10 Задана послідовність чисел А[N]. Знайти кількість від’ємних
            //значень в послідовності

            int countNegative = 0;
            for (int i = 0; i < array2.Length;i++)
            {
                if (array2[i] < 0)
                    {
                        countNegative = countNegative +1;
                    }
            }
            Console.WriteLine (countNegative);
        }
    }
}
