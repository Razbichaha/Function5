using System;

namespace Function5
{
    //Реализуйте функцию Shuffle, которая перемешивает элементы массива в случайном порядке.
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 10;
            int[] array = new int[arrayLength];

            for(int i=0;i<array.Length;i++)
            {
                array[i] = i;
                Console.Write(i + " ");
            }

            array = Shuffle(array);
            Console.WriteLine(" Начальный массив");

            foreach(int i in array)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" Перемешанный массив");
            Console.ReadKey();
        }

        static int[] Shuffle(int[] array)
        {
            int[] tempArray = array;

            Random random = new Random();

            for (int i = array.Length - 1; i >= 1; i--)
            {
                int randomValue = random.Next(i + 1);
                int tempValue = array[randomValue];
                array[randomValue] = array[i];
                array[i] = tempValue;
            }

            return tempArray;
        }
    }
}
