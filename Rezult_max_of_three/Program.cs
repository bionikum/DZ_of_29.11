Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (c <= a)
    {
        Console.WriteLine($"Max: {a}");
    }
}
if (b > c)
{
    if (a <= b)
    {
            Console.WriteLine($"Max: {b}");
    }
}
if (b <= c)
{
    if (c > a)
    {
                Console.WriteLine($"Max: {c}");
    }
}
if (a == b)
{
     if (a == c)
     {
        Console.WriteLine($"Max: {b + 0}");
     }
}




