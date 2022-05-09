//напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();

int GetValue(string text)
{
    Console.Write($"{text} ");
string GetValueStr=Console.ReadLine()!;
int value=Convert.ToInt32(GetValueStr);
return value;
}

double GetSum(int a)
{ 
    double sum = 0;
    while (a != 0)
    {
        sum += a % 10;
        a = a / 10;
    }
    return sum;
}


int N = GetValue("N= ");

double result= GetSum(N);
Console.WriteLine(result);