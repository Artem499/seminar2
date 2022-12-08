// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 100;
int result1 = result /10;
if(number < 100 || number > 999)
{
    Console.WriteLine("Error! Enter three-digit number!");
}
else
{
    Console.WriteLine("result: " +result1);
}



