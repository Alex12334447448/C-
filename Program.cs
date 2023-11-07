class Program
{
static void Main()
{
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Первое число: {num1:F2}");
Console.WriteLine($"Второе число: {num2:F2}");
Console.WriteLine($"Третье число: {num3:F2}");
}
}