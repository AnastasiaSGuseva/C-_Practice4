// Задача 27
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int A = Convert.ToInt32(Console.ReadLine());
int summ = 0;
while( A != 0)
{
    int ost = A % 10;
    summ = summ + ost;
    A /= 10;
}

Console.WriteLine(summ);