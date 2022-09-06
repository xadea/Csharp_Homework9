// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Clear();

Console.Write("Enter first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0 || number2 < 0) Console.WriteLine("Both numbers must not be negative!");
else Console.WriteLine("Akkerman for " + number1 + ", " + number2 + " is " + Akkerman(number1, number2));

int Akkerman(int m, int n)
{
    if (m == 0) return (n + 1);
    if (n == 0) return (Akkerman(m - 1, 1));
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
