namespace Id4;
using System;

public class Id
{
    public static double Max(double number1, double number2)
    {
        double maxNum = Math.Max(number1, number2);
        Console.WriteLine("The max number between " + number1 + " and " + number2 + " is " + maxNum);
        return maxNum;
    }
}
