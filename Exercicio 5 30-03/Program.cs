// Informe a quantidade de macas compradas 
// criar condicoes para preco
// se mais de 12 macas, 0,25 cents
// se menos, 0,30 cents


Console.WriteLine($"Quantas macas comprou? ");
int quantidade = int.Parse (Console.ReadLine());
float preco = 0.30f;
float precodesconto = 0.25f;

if (quantidade >= 12)
{
Console.WriteLine($"{quantidade * precodesconto}");
}else
{
    Console.WriteLine($"{quantidade * preco}");
}

