using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks in Pre: ");
        int marksPre = Convert.ToInt32(Console.ReadLine());

        if (marksPre > 60)
        {
            Console.Write("Enter marks in Final: ");
            int marksFinal = Convert.ToInt32(Console.ReadLine());

            if (marksFinal > 55)
            {
                Console.WriteLine("Selected");
            }
            else
            {
                Console.WriteLine("Fail in Final");
            }
        }
        else if (marksPre <= 60)
        {
            Console.WriteLine("Fail in Pre");
        }

        Console.ReadLine();
    }
}