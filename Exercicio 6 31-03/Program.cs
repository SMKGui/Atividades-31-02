Console.WriteLine($"Qual a frequencia de faltas? ");
int frequencia = int.Parse (Console.ReadLine());

Console.WriteLine($"Media do aluno: ");
int media = int.Parse (Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine($"Reprovado");
}

else if (media >= 7)
{
    Console.WriteLine($"Aprovado");
}

else if (media >= 3)
{
    Console.WriteLine($"Fazer recuperacao");
}

else 
{
    Console.WriteLine($"Reprovado");
}