Console.WriteLine($"Tamanho lado 1: ");
int x = int.Parse (Console.ReadLine());

Console.WriteLine($"Tamanho lado 2: ");
int y = int.Parse (Console.ReadLine());

Console.WriteLine($"Tamanho lado 3: ");
int z = int.Parse (Console.ReadLine());

if ((x == y) && (y == z))
{
    Console.WriteLine($"Equilatero");
}
 else if ((x == y) || (y == z))
{
    Console.WriteLine($"Isosceles");
}
else 
{
    Console.WriteLine($"Escaleno");
}