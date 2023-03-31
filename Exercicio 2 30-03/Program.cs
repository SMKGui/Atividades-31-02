// Digite placar time 1
// Digite placar time 2
// Empate?
// Vitoria time 1
// Vitoria time 2

Console.WriteLine($"Placar time 1: ");
int time1 = int.Parse (Console.ReadLine());

Console.WriteLine($"Placar time 2: ");
int time2 = int.Parse (Console.ReadLine());

if (time1 == time2)
{
    Console.WriteLine($"Empate");
}
else if (time1 > time2)
{
    Console.WriteLine($"Time 1 vitorioso!");
}
else 
{
    Console.WriteLine($"Time 2 vitorioso!");
}