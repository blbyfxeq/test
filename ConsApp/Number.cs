using System;

public class Number
{
	public Number()
	{
        Console.WriteLine("Введите два числа: ");

        double a = Convert.ToInt32(Console.ReadLine());
        double b = Convert.ToInt32(Console.ReadLine());
        var c = Math.Truncate(a / b);
        Console.WriteLine(c);
        Console.ReadLine();
    }
}
