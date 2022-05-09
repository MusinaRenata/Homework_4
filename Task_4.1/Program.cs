// напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

 Console.Clear();
int GetValue(string text)
{
    Console.Write($"{text} ");
string GetValueStr=Console.ReadLine()!;
int value=Convert.ToInt32(GetValueStr);
return value;
}
int A=GetValue("Число A= ");
int B=GetValue("Степень B= ");
int result=1;

 for (int i = 1; i <= B; i++)
 {
      result=result*A;
     
 }   

Console.Write("A в степени B= ");
Console.WriteLine(result);;


