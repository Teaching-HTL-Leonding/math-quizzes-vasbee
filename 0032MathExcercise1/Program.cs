double first_number = 0;
double second_number = 0;
double result = 0;

Console.Write("First number: ");
first_number  = int.Parse(Console.ReadLine()!);

Console.Write("Second number: ");
second_number = int.Parse(Console.ReadLine()!);

Console.Write("Result: ");
result = double.Parse(Console.ReadLine()!);




if (Math.Round(first_number + second_number , 2) == result || Math.Round (second_number + first_number , 2) == result)
{ 
    Console.Write("Operator: Plus"); 
}
else if (Math.Round(first_number - second_number , 2) == result || Math.Round (second_number - first_number , 2) == result)
{
    Console.Write("Operator: Minus"); 
}
else if (Math.Round(first_number * second_number , 2) == result || Math.Round (second_number * first_number , 2) == result)
{
    Console.WriteLine("Operator: Multiply");
}
else if  (Math.Round(first_number / second_number , 2) == result || Math.Round (second_number / first_number , 2) == result)
{
    Console.Write("Operator: Divide");
}
else if  (Math.Round(first_number % second_number , 2) == result || Math.Round (second_number % first_number , 2) == result)
{
    Console.Write("Operator: Modulo");
}
else if  (Math.Pow(first_number , second_number) == result || Math.Pow (second_number, first_number) == result)
{
    Console.Write("Operator: Exponentiation");
}