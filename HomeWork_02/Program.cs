int a, b, c;
 
Console.WriteLine("Введите 3 числа : ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
 
if ((a > b) && (a > c))
 
{
    Console.WriteLine(a);
}
 
if ((b > a) && (b > c))

{
    Console.WriteLine(b);
}

if ((c > a) && (c > b))
        
{
    Console.WriteLine(c);
}