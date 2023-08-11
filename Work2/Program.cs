//напишите программу которая на вход приимаетдва числа и проверяет, является ли первое число квадратом второго
Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

if(number2 * number2 == number1)
{
Console.WriteLine($"Число {number1} являеется квадратом {number2}");
}
else
{
Console.WriteLine($"Число {number1} не являеется квадратом {number2}");
}