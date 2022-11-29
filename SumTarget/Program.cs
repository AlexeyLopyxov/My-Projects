using System;

class ExSum
{
    static void Main()
    {
        int target = 11;

        int[] nums = new int[] { 2, 4, 7, 8, 9};
        Console.Write("Массив: [");
        for (int i=0; i<nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
            
        Console.WriteLine("]");

        for (int i = 0; i < nums.Length-1; i++)
        { 
            for (int j = i+1; j < nums.Length; j++)
                {
                if ((nums[i] + nums[j]) == target)
                Console.WriteLine($"Сумма членов массива [{i}, {j}] равна {target}");
                }
            }
    }
}