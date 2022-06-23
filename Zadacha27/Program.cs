//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12;

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Summa(a);
void Summa (int currentA)
{
    int b = 0;
    for (int c = a; c > 0; c = c/10)
    {
        b = b += c%10;
    }
    Console.WriteLine($"Сумма всех цифр числа {a} равна {b}");
}
