// //Возведение в квадрат введенного числа
// Console.Write("Введите число: ");
// string num = Console.ReadLine()!;
// int number = int.Parse(num);
// int square = number * number;
// Console.WriteLine("Квадрат числа " + number + " равен " + square); //либо
// Console.WriteLine($"Квадрат числа {number} равен {square}");

Console.Write("Введите число: ");
// string num = Console.ReadLine()!; // "456"
// int number = int.Parse(num); // 456

int number = int.Parse(Console.ReadLine()!);

int square = number * number;
Console.WriteLine("Квадрат числа " + number + " равен " + square);
Console.WriteLine($"Квадрат числа {number} равен {square}");