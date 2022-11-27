Console.WriteLine("Введите целое число ");
int N = Convert.ToInt32(Console.ReadLine());
int x = 1;
while (x <= N)
{
    if (x % 2 == 0)
    {
        Console.Write($"{x} ");
        x++;

    }
    else
    {
        x++;
    }
}