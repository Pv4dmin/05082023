//программа, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int start = 1;
while (start < num)
{
    int number = start % 2;
    if (number == 0)
        {
            Console.Write($"{start}; ");
        }
    start++;
}