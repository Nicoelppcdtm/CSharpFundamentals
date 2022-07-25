// declare two string variables
string firstName;
string lastName;

// prompt for first name using Write() to keep it on the same line
Console.Write("Enter First Name: ");
firstName = Console.ReadLine();

// same for last name
Console.Write("Enter Last Name: ");
lastName = Console.ReadLine();

// print message in format specified by the exercise
Console.WriteLine("You have entered the name " + lastName + ", " + firstName + ".");