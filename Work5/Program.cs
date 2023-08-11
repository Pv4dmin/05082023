Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
int thirdDigit = number %10;
int secondDigit = number / 10 %10;
int firstDigit = number / 100; 
Console.WriteLine($"Первая цифра числа {number} равна {firstDigit}");
Console.WriteLine($"Вторая цифра числа {number} равна {secondDigit}");
Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}");
