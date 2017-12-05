using System;

namespace CrazyCStasks
{
    class Program
    {
        static float GetAverage (int[] array)
        {
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum = sum + array[i];

            return sum/array.Length;
        }

        static int GetMult (int[] array)
        {
            int mult = 1;
            for (int i = 0; i < array.Length; i++)
                mult = mult*array[i];

            return mult;
        }
        
        static void Main(string[] args)
        {
            int [] newArray;
            //1. Задана послідовність А[N].
            //Знайти середнє арифметичне значень елементів послідовності
            Console.WriteLine("1. Задана послідовність А[N].\nЗнайти середнє арифметичне значень елементів послідовності:");

            newArray = new int [5] {5, 6, 3, 8, 2};

            Console.WriteLine ("GetAverage(newArray): {0}", GetAverage(newArray));
            Console.WriteLine();

            //2. Задана послідовність А[N].
            //Знайти добуток елементів послідовності
            Console.WriteLine("2. Задана послідовність А[N].\nЗнайти добуток елементів послідовності:");

            newArray = new int [5] {5, 6, 3, 8, 2};

            Console.WriteLine ("GetMult(newArray): {0}", GetMult(newArray));
            Console.WriteLine();

            //3. Задана послідовність А[N].
            //Знайти нову послідовність, збільшивши кожне число вдвічі
            Console.WriteLine("3. Задана послідовність А[N].\nЗнайти нову послідовність, збільшивши кожне число вдвічі:");
            newArray = new int [5] {5, 6, 3, 8, 2};

            for (int i=0; i < newArray.Length; i++)
                newArray[i] = newArray[i]*2;

            foreach (int el in newArray)
                Console.Write ("{0} ", el);
            Console.WriteLine();
            Console.WriteLine();

            //4. Задана послідовність А[N].
            //Знайти нову послідовність, збільшивши кожне число на суму елементів послідовності
            Console.WriteLine("4. Задана послідовність А[N].\nЗнайти нову послідовність, збільшивши кожне число на суму елементів послідовності:");
            newArray = new int [5] {5, 6, 3, 8, 2};
            int sum = 0;

            for (int k = 0; k < newArray.Length; k++)
                sum = sum + newArray[k];

            for (int i = 0; i< newArray.Length; i++)
                newArray[i] = newArray[i]*sum;

            foreach (int el in newArray)
                Console.Write ("{0} ", el);
            Console.WriteLine();
            Console.WriteLine();

            //5. Задана послідовність чисел А[N] і деяке число, не рівне нулю. 
            //Знайти нову послідовність, розділивши кожен елемент заданої послідовності на задане число
            Console.WriteLine("5. Задана послідовність чисел А[N] і деяке число, не рівне нулю.\nЗнайти нову послідовність, розділивши кожен елемент заданої послідовності на задане число:");
            float div = 2;
            float [] floatArray = new float [5];
            for (int i = 0; i< floatArray.Length; i++)
                floatArray[i] = newArray[i]/div;

            foreach (float el in floatArray)
                Console.Write ("{0} ", el);
            Console.WriteLine();
            Console.WriteLine();

            //6. Задана послідовність чисел А[N], не рівних нулю, і деяке число.
            //Знайти нову послідовність, розділивши задане число на кожний елемент заданої послідовності
            Console.WriteLine("6. Задана послідовність чисел А[N], не рівних нулю, і деяке число.\nЗнайти нову послідовність, розділивши задане число на кожний елемент заданої послідовності");
            float divider = 100;
            float [] newFlArr = new float [5];
            for (int i = 0; i < newFlArr.Length; i++)
                newFlArr[i] = divider/newArray[i];

            foreach (float el in floatArray)
                Console.Write ("{0} ", el);
            Console.WriteLine();
            Console.WriteLine();

            //7. Задана послідовність чисел А[N].
            //Перемістити елементи послідовності у такому порядку:
            //перший елемент на останню позицію послідовності,
            //останній елемент на першу позицію в послідовності,
            //другій елемент на передостанню позицію послідовності,
            //передостанній елемент на другу позицію, і т.д.
            Console.WriteLine("7. Задана послідовність чисел А[N].\nПеремістити елементи послідовності у такому порядку:\nперший елемент на останню позицію послідовності,\nостанній елемент на першу позицію в послідовності,\nдругій елемент на передостанню позицію послідовності,\nпередостанній елемент на другу позицію, і т.д.:");
            newArray = new int [5] {5, 6, 3, 8, 2};
            for (int i = 0; i < newArray.Length/2; i++)
            {
                int buffer = 0;
                buffer = newArray[newArray.Length - i - 1];
                newArray[newArray.Length - i - 1] = newArray[i];
                newArray[i] = buffer;
            }
            foreach (int el in newArray)
                Console.Write ("{0} ", el);
            Console.WriteLine();
            Console.WriteLine();

            //8. Задана послідовність чисел А[N] і деяке число.
            //Знайти номер входження числа в послідовність
            Console.WriteLine("8. Задана послідовність чисел А[N] і деяке число.\nЗнайти номер входження числа в послідовність");
            newArray = new int [10] {2, 4, 5, 7, 2, 10, 16, 45, 10, 45};
            int searchedNumber = 10;
            int firstEnter = -1;
            for (int i = 0; i < newArray.Length;i++)
            {
                if (newArray[i] == searchedNumber)
                {
                    firstEnter = i;
                    break;
                }
            }
            Console.WriteLine (firstEnter);
            Console.WriteLine ();

            //9. Задана послідовність чисел А[N] і деяке число.
            //Знайти кількість всіх входжень числа в послідовність
            Console.WriteLine("9. Задана послідовність чисел А[N] і деяке число.\nЗнайти кількість всіх входжень числа в послідовність:");
            newArray = new int [10] {2, 4, 5, 7, 2, 10, 16, 45, 10, 45};
            int count = 0;
            for (int i = 0; i < newArray.Length;i++)
                if (newArray[i] == searchedNumber)
                    count = count +1;
            Console.WriteLine (count);
            Console.WriteLine ();

            //10. Задана послідовність чисел А[N].
            //Знайти кількість від’ємних значень в послідовності
            Console.WriteLine("10. Задана послідовність чисел А[N].\nЗнайти кількість від’ємних значень в послідовності");
            newArray = new int [10] {2, 4, 5, 7, 2, 10, 16, 45, 10, 45};
            int countNegative = 0;
            for (int i = 0; i < newArray.Length;i++)
                if (newArray[i] < 0)
                    countNegative = countNegative +1;

            Console.WriteLine (countNegative);
            Console.WriteLine ();
        }
    }
}
