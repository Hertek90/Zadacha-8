Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    System.Console.Write("Число не подходит");
}
else
{
    for (int i = 2; i <= number; i = i + 2)
{
    System.Console.Write(i+" ");
}
}