// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

Console.Write("Enter minimum ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximum ");
int n = Convert.ToInt32(Console.ReadLine());


if (m > n) Console.WriteLine("First number must be lower than second one!");
if (n < 0) Console.WriteLine("Your maximum must be higher than zero!");
else Console.WriteLine("Sum of natural numbers from " + m + " to " + n + " is " + Sum(m, n));

int Sum(int arg1, int arg2)
{
    {
        int i = 1;
        if (arg1 > 1) i = arg1;

        int result = 0; 

        while (i <= arg2)
        {
            result = result + i;
            i++;
        }
        return result;

    }
}
