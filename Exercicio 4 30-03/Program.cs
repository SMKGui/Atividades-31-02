// Informe a senha
// Verificar se e igual a 1234
// Se nao for negar acesso

Console.WriteLine($"Digite sua senha: ");
int senha = int.Parse (Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine($"ACESSO PERMITIDO");
}

else
{
    Console.WriteLine($"ACESSO NEGADO");
    
}