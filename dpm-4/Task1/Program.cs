using System;
class Task1
{
    static void Main()
    {
        int[] RanNums = new int [10];
        Random rnd = new Random();
        for (int i = 0; i < RanNums.Length; i++)
        {
            RanNums[i] = rnd.Next(-100, 100);
        }
        Task1.RNC(RanNums);
    }
    static void RNC(int[] RanNums)
    {
        int PosCount = 0;
        int NegCount = 0;
        for (int i = 0; i < RanNums.Length; i++)
        {
            if (RanNums[i] > 0)
            {
                PosCount+=1;
            }
            else if(RanNums[i] < 0)
            {
                NegCount+=1;
            }
        }
        Console.WriteLine($"negative = {NegCount}\n posetive = {PosCount}");
    }
}