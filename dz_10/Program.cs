// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int b = ( a / 10 ) % 10;
if (a > 999)
{
    Console.WriteLine("неверное число");
}
else if (a < 100)
{
    Console.WriteLine("неверное число");
}
else
{
   Console.WriteLine($"вторая цифра {b}");
}