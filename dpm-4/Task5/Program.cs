using System;
class Task5
{
    static void Main()
    {
        int[] RanNums = new int[10];
        Random random = new Random();
        for (int i = 0; i < RanNums.Length; i++)
        {
            RanNums[i] = random.Next();
        }
        Task5.NC(RanNums);
    }
    static void NC(int[] array)
    {
        foreach (int i in array)
        {
            if (i < 0)
            {
                array[i] = 0;
                continue;
            }
        }
    }
}
