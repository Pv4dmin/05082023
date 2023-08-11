Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
int thirdDigit = number %10;
int secondDigit = number / 10 %10;
int firstDigit = number / 100; 
Console.WriteLine($"Первой цифрой из числа {number} является {firstDigit} потом {secondDigit} и последняя {thirdDigit}");