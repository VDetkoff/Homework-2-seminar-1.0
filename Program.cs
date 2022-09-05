/*
int FindBiggerDigit(int number)
{
    int ed = number % 10;
    int dec = number /10;

    int result;
    if(ed > dec) result = ed;
    else result = dec;

    return result; 
}

int randNumber = new Random().Next(10, 1000);
int biggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($"Bigger digit of {randNumber} is {biggerDigit}");
*/

static void Main(string[] args)
{
    int n = 534534623;
    int d = GetSecondDigit(n);
    Console.WriteLine(d);
    Console.ReadKey();
}