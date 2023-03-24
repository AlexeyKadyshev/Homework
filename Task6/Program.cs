Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
if (num % 2 != 0 || num == 0)
{
    Console.Write("нет");
}
else
{
    Console.Write("да");
}
