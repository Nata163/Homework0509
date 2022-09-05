Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int max = number1;
if (number2 > number1)
{
    max = number2;
    Console.Write(number2);
}
else
{
    Console.Write(number1);
}