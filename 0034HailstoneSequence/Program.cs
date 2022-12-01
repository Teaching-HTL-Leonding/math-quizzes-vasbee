System.Console.Write("Please enter the first positive number: ");
int n = int.Parse(Console.ReadLine()!);

System.Console.Write("Please enter the second positive number: ");
int n1 = int.Parse(Console.ReadLine()!);

int tries = 0;

while (n > 1)
{

    if (n % 2 == 0)
    {
        n = n / 2;
    }
    else
    {
        n = n * 3 + 1;
    }

    tries++;

}

int tries1 = 0;
while (n1 > 1)
{

    if (n1 % 2 == 0)
    {
        n1 = n1 / 2;
    }
    else
    {
        n1 = n1 * 3 + 1;
    }

    tries1++;

}

if (tries > tries1)
{
    Console.Write("The first Hailstone sequence  is longer.");
}
else if (tries1 > tries)
{
    Console.Write("The second Hailstone sequence  is longer.");
}

