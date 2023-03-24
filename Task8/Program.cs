Console.WriteLine("Введите натуральное число:");
int num = int.Parse(Console.ReadLine());
int even_num = 2;
if (num != 0)
{
    while (even_num <= num)
    {
        Console.WriteLine(even_num);
        even_num = even_num + 2;
    }
}
else
{
    Console.Write("0 не является натуральным числом");
}