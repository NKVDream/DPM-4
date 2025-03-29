using System;
class Task3
{
    static void Main()
    {
        Random random = new Random();
        int[] RanNums = new int[10];
        for (int i = 0; i < RanNums.Length; i++)
        {
            RanNums[i] = random.Next(-100, 100);
        }
        foreach (int i in RanNums)
        {
            Console.WriteLine(i);
        }
        Task3.Con(RanNums);
    }
    static void Con(int[]array)
    {
        int MaxVal = 0;
        int MinVal = 0;
        int AverVal = array.Sum() / array.Length;
        foreach(int i in array)
        {
            if (i == array.Max())
            {
                MaxVal = i;
                continue;
            }
            else if (i == array.Min())
            {
                MinVal = i;
            }
        }
        Console.WriteLine($"{MinVal}, {MaxVal}, {AverVal}");
    }
}