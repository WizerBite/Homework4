    /*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4-> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33-> [6, 1, 33]
    */
void task25()
{
    Console.WriteLine("Введите число A: ");
    double A = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int B = int.Parse(Console.ReadLine());
    double ans = 1;
    if (B != 0)
        ans = A;

    if (B > 0)
        for (int i = 1; i < B; i++)
        {
            ans *= A;
        }
    else if (B < 0)
    {
        for (int i = -1; i > B; i--)
        {
            ans *= A;
        }
        Console.WriteLine(ans);
        ans = 1 / ans;
    }
    Console.WriteLine($"Число {A}, возведенное в степень {B} = {ans}");
}

void task27()
{
    Console.WriteLine("Введите число: ");
    int A = int.Parse(Console.ReadLine());
    int ans = 0;
    while (A*10/10 > 0)
    {
        ans += A%10;
        A /= 10;
    }
    Console.WriteLine($"Сумма чисел в этом числе = {ans}");
}

void task29()
{
    int[] arr = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 101);
        Console.WriteLine($"Элемент масива {i + 1} - {arr[i]}");
    }
}

while (true)
{ 
    Console.Write("Введите номер задачи: ");
    int num = int.Parse(Console.ReadLine());
    switch(num)
    {
        case 25:
            {
                task25();
                break;
            }
        case 27:
            {
                task27();
                break;
            }
        case 29:
            {
                task29();
                break;
            }
    }    
}
