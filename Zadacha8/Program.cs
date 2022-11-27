Console.WriteLine("Введите целое число ");
int Num = Convert.ToInt32(Console.ReadLine());
int x = 1;
while (x <= Num)
{
    if (x % 2 == 0)
    {
        Console.Write($"{x} " );
        x++;

    }
    else
    {
        x++;
    }
}