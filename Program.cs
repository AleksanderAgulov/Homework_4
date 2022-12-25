//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("Enter a namber A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number B: ");
int B = Convert.ToInt32(Console.ReadLine());


void Exponentiation(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"The number A to the power of B is equal to: {result}!");
}
Exponentiation(A,B);
*/
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.WriteLine("Enter a number");
int Number = Convert.ToInt32(Console.ReadLine());
int result = 0;
while(Number > 0)
{
    int remainder = Number % 10;
    Number = Number / 10;
    result = result + remainder;
}
Console.WriteLine($"The sum of all the numbers is equal to: {result}!");
*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int [] numbers = new int[8];

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write("[ " + numbers [i] + " ]");
 }
*/

