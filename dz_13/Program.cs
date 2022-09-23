// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int b = int.Parse(Convert.ToString(a)[2].ToString());
    Console.WriteLine($"третья цифра {b}");
}