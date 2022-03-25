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
        int hourlyRate;
        int hoursWorked;

        Console.WriteLine("This program finds your income");
        Console.WriteLine("");

        Console.Write("Enter your hourly rate: ");
        hourlyRate = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your hours worked: ");
        hoursWorked = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Your income is, " + hoursWorked * hourlyRate * (1.00 - 0.18 ));

taxes = (hours x rate) x  0.18
        Console.WriteLine("\nDone.");
    }
}
