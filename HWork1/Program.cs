//Программа которая на вход принимает два числа и выдает какое число большее, а какое меньшее

Console.WriteLine("Введите число 1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = int.Parse(Console.ReadLine());
if(number1 > number2)
{
Console.WriteLine($"Число {number1} больше числа {number2}");
}
else
{
Console.WriteLine($"Число {number2} больше числа {number1}");
}