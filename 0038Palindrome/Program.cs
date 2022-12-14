﻿int number = 0;
int palindrom = 0;
int digit;
bool NumberValid = number <= 0 && number % 1 != 0;

do
{
    Console.Write("Enter a number: ");
    number = int.Parse(Console.ReadLine()!);
    if (number <= 0 || number % 1 != 0)
    {
        System.Console.WriteLine("Invalid");
    }
}
while (!NumberValid);

int number1 = number;

while (number1 != 0)
{ 
    digit = number1 % 10;
    palindrom = palindrom * 10 + digit;
    number1 = number1 / 10;
}

if (palindrom == number)
{
    System.Console.WriteLine("The number is a palindrom");
}
else
{
    System.Console.WriteLine("The number is not a palindrom");
}

System.Console.WriteLine();
System.Console.WriteLine("Press any key to exit");
Console.ReadKey();
Console.Clear();