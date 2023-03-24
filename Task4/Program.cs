Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int num3 = int.Parse(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
    Console.Write(num1);
}
else if (num2 > num1 && num2 > num3)
{
    Console.Write(num2);
}
else if (num3 > num1 && num3 > num2)
{
    Console.Write(num3);
}