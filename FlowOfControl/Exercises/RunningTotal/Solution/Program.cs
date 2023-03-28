﻿// Declare variables for user input and total
string input;
int total = 0;

// Print Title
Console.WriteLine("Running Total");
Console.WriteLine("=============");

// Loop until Q is entered
do
{
    // prompt user 
    Console.Write("Enter a number (Q to quit): ");
    input = Console.ReadLine().ToUpper();

    // if Q break loop
    if (input == "Q")
    {
        break;
    }

    // parse and add to total
    total += int.Parse(input);
    // same as total = total + int.Parse(input);
} while (true);

// print result
Console.WriteLine($"The sum of the numbers is {total}.");