//Программа которая на вход дает три числа и выдает максимальное из этих чисел

Console.WriteLine("Введите число 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3");
int c = int.Parse(Console.ReadLine());
if (a > b)
    {
        if (a > c)
            {
                Console.WriteLine($"максимальное из этих чисел является {a}");
            }
       else 
            {
                Console.WriteLine($"максимальное из этих чисел является {c}");
            }
    }
else 
    {
        if (b > c)
            {
                Console.WriteLine($"максимальное из этих чисел является {b}");
            }
        else 
            {
                Console.WriteLine($"максимальное из этих чисел является {c}");
            }
    }