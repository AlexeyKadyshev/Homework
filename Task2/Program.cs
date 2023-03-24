Console.WriteLine("Введите первоe число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.Write("max = " + num1);
}
else
{
    Console.Write("max = " + num2);
}