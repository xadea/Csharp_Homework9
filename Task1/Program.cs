// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();

Console.Write("Enter minimum ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximum ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n) Console.WriteLine("First number must be lower than second one!");
if (n < 0) Console.WriteLine("Your maximum must be higher than zero!");
else
{
    int i = 1;
    if (m > 0) i = m;

    Console.Write("\"");
    while (i < n)
    {
        Console.Write(i + ", ");
        i++;
    }
    Console.WriteLine(n + "\"");
}
