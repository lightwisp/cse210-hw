using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions fractions = new Fractions();

        //step 6 for verification
        fractions.SetTop(1);
        fractions.SetBottom(1);
        Console.WriteLine(fractions.GetFractionString());
        Console.WriteLine(fractions.GetDecimalValue());

        Console.WriteLine("");
        fractions.SetTop(5);
        fractions.SetBottom(1);
        Console.WriteLine(fractions.GetFractionString());
        Console.WriteLine(fractions.GetDecimalValue());

        Console.WriteLine("");
        fractions.SetTop(3);
        fractions.SetBottom(4);
        Console.WriteLine(fractions.GetFractionString());
        Console.WriteLine(fractions.GetDecimalValue());


        Console.WriteLine("");
        fractions.SetTop(1);
        fractions.SetBottom(3);
        Console.WriteLine(fractions.GetFractionString());
        Console.WriteLine(fractions.GetDecimalValue());
    }
}