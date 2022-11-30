Console.Clear();
Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > y)
{

    Console.WriteLine($"Max: {x}");
    Console.WriteLine($"Min: {y}" );
}

if (x < y)
{
    Console.WriteLine($"Max: {y}");
    Console.WriteLine($"Min: {x}");
}
if (x == y)
{
    Console.WriteLine("Значения равны");
}



