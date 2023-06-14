// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа:");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int max = number1;
int min = number2;
if (number1 > number2)
{
     max = number1;
     min = number2;
     Console.Write("Максимальное значение:");
     Console.WriteLine(max);
     Console.Write("Минимальное значение:");
     Console.WriteLine(min);
}
else
{
    max = number2;
    min = number1;
    Console.Write("Максимальное значение:");
    Console.WriteLine(max);
    Console.Write("Минимальное значение:");
    Console.WriteLine(min);
}