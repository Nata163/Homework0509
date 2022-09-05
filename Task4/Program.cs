Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int x = 1;
int count = 0;
while (x < number)
{
    if (x % 2==0)
    {
        count = count+1;
        Console.WriteLine(x);
    }
    else
    {
        count = count;
    }
x++;
}
