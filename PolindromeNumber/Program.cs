using System;

class Polindrom
{
    static void Main()
    {
        Console.Write("Input an integer number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0, temp;
        int x = 0;

        temp = num;

        Console.WriteLine("Число: " + num);

        while (num>0)
        {
            x = num % 10;
            num = num / 10;
            sum = sum * 10 + x;
        }
        Console.WriteLine("Число наоборот: " + sum);
        
        if (temp == sum)
            Console.WriteLine("Polindrome");
        else 
            Console.WriteLine("No polindrome");
    }
}
