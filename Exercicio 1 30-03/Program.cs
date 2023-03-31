// 1 Informe o salario recebido
// 2 total gasto
// 3 orcamento maximo
// 4 se dentro ou fora do orcamento

Console.WriteLine($"Salario recebido: ");
int salario = int.Parse (Console.ReadLine());


Console.WriteLine($"Informe o total gasto: ");
int gastos = int.Parse (Console.ReadLine());

if (salario <= gastos ) 
{
    Console.WriteLine($"Fora do orcamento");
}
else
{
    Console.WriteLine($"Dentro do orcamento");
}

