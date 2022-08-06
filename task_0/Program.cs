Console.Write("Напишите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Напашите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.Write($"Max = {num1} ");
}
else 
{
    Console.Write($"Max = {num2}");
}