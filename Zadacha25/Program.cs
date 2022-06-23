// Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243
// 2, 4 -> 16;

Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
Stepen (a);
void Stepen (int currentStepen)
{
    int ab = a;
    for (int c = 2; c <= b; c++)
    {
       ab = ab * a;
    }
    Console.WriteLine($"Число {a} в степени {b} равно {ab}");
}