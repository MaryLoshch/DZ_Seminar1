Console.WriteLine("Введите первое целое число ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int numB = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if(numA > numB)
{
    max = numA;
    min = numB;
}
else
{
    max = numB;
    min = numA;
}
Console.WriteLine("Большее из представленных чисел " + max);
Console.WriteLine("Меньшее из представленных чисел " + min);