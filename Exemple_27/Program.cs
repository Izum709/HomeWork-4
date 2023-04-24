
// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int EnterData(string text)
{
    Console.WriteLine(text);
    return(int.Parse(Console.ReadLine()));
}

int b = EnterData("Введите число a: ");
int a = b;
int i = 0;
while (a>0)
{
    a = a/10;
    i++;
}
Console.WriteLine(i);
int sum = 0;
int c=0;
a=b;
while ( c<=i )
{
    sum = sum + a%10; 
    a /= 10;
    c++;
}
Console.WriteLine(sum);
