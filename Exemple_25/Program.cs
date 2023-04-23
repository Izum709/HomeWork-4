// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


    


int EnterData(string text)
{
    Console.WriteLine(text);
    return(int.Parse(Console.ReadLine()));
}

int a = EnterData("Введите число a: ");
int b = EnterData("Введите число b: ");
int degree = 1;
    for(int i = 1; i <= b; i++ )
    {
        degree = degree * a;
        
    }
    
Console.WriteLine($"{a}, {b} -> {degree}");