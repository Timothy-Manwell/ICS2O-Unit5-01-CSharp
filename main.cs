// Created by: Timothy Manwell
// Created on: Nov 2022
//
// This program converts Fahrenheit to Celsius
using System;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int randomNum = random.Next(1, 7);
        int guess;

        Console.WriteLine("Welcome to the number guessing game!");
        Console.WriteLine("\nYou will need to guess a number between 1 and 6.");
        Console.WriteLine("\nGuess the number correct and you win!");
        Console.Write("\nGuess a number: ");
        guess = Convert.ToInt32(Console.ReadLine());

        if (randomNum == guess) {
            Console.WriteLine("\nThe number was " + randomNum + " you got it!");
        }

        if (randomNum != guess) {
            Console.WriteLine("\nThe number was " + randomNum + "." + " Good luck next time.");
        }
    }
}