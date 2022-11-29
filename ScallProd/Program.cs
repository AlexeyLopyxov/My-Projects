using System;

class ScallProd
{
    static void Main()
    {
        int[] nums1 = new int[] { 1, 8 };
        int[] nums2 = new int[] { 3, 2 };
        int prod = 1;
        int sum = 0;

        for (int i = 0; i < nums1.Length; i++)
        {
            prod = nums1[i] * nums2[i];
            sum = sum + prod;
        }
        Console.WriteLine("Скалярное произведение двух векторов: " + sum);
    }
}