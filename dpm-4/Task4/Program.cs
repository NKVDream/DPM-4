using System;
class Task4
{
    static void Main()
    {
        int[] RanNums = new int[10];
        Random random = new Random();
        for (int i = 0; i < RanNums.Length; i++)
        {
            RanNums[i] = random.Next(-100, 100);
        }
        foreach (int i in RanNums)
        {
            Console.Write($"{i}\t");
        }
        Task4.Pur(RanNums);
    }
    static void Pur(int[] array)
    {
        for (int i = 0; i < array.Length; i += 2) // Проходим только по четным индексам
        {
            if (array[i] >= 0)
            {
                Console.WriteLine($"{array[i]}");
            }
        }
    }
}