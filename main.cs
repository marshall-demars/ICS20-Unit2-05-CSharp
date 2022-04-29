// Created by: Marshall Demars
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        const float HST = 0.13F;
        int hourlyRate;
        int hoursWorked;
        float money;

        // input
        Console.WriteLine("This program finds your income");
        Console.WriteLine("");

        Console.Write("Enter your hourly rate: ");
        hourlyRate = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your hours worked: ");
        hoursWorked = Convert.ToInt32(Console.ReadLine());

        // process
        money = (1 - HST);
        // calculations

        // output
        Console.WriteLine("");
        Console.WriteLine("Your income is, $" + hoursWorked * hourlyRate * (money));
        Console.WriteLine("The government will take, $" + hoursWorked * hourlyRate * HST);

        Console.WriteLine("\nDone.");
    }
}
