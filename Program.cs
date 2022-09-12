
/*
// Домашняя работа 1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int SpecifySecondDigit(int num)
{
    int num1,  res;

    num1 = (num % 100)/10;
    res = num1;
    return  res;
}

Console.Write("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int specifySecond = SpecifySecondDigit(num);
Console.WriteLine($"The second digit of a three-digit number: {specifySecond}");

*/
//Домашняя работа 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void WorkingDay(int num)
{
   
    if(num < 6 & num < 7) 
    {
        Console.WriteLine("Working day");
    }
    else 
    {
        Console.WriteLine("Weekend");
    }
   
}

    Console.Write("Day of the week: ");
    int num = Convert.ToInt32(Console.ReadLine());
    WorkingDay(num);
    