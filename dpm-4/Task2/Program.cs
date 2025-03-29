using System;
class Task2
{
    static void Main()
    {
        int[] RanNum = new int[10];
        Random random = new Random();
        for (int i = 0; i < RanNum.Length; i++)
        {
            RanNum[i] = random.Next(-100, 100);
        }
        foreach(int i in RanNum)
        {
            Console.Write($"{i}\t");
        }
        Task2.Reverse(RanNum);
    }
    static void Reverse(int[]array)
    {

        int n = array.Length; // длина массива
        int k = n / 2;          // середина массива
        int temp;               // вспомогательный элемент для обмена значениями
        for (int i = 0; i < k; i++)
        {
            temp = array[i];
            array[i] = array[n - i - 1];
            array[n - i - 1] = temp;
        }
        foreach (int i in array)
        {
            Console.Write($"{i} \t");
        }
    }
}
