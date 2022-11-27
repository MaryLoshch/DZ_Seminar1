Console.WriteLine("Введите первое целое число ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число ");
int numC = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (numA > numB)
{
    max = numA;
    if (numA > numC)
    {
        max = numA;
    }
    else
    {
        max = numC;
    }
}
else
{
    max = numB;
    if (numB > numC)
    {
        max = numB;
    }
    else
    {
        max = numC;
    }
}
Console.WriteLine($"Большее из представленных чисел {max}");