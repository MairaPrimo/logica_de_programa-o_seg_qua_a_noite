// Solicitar 2 numero ao usuario e realizar teste lógico (

Console.Write("N1");
double n1 = double.Parse(Console.ReadLine());
Console.Write("N2");
double N2 = double.Parse(Console.ReadLine());

Console.WriteLine($"N1 é maior que N2? Resposta: {n1 > N2}");
Console.WriteLine($"N1 é maior ou igual que N2? Resposta: {n1 > N2}");
Console.WriteLine($"N1 é menor que N2? resposta: {n1 < N2}");
Console.WriteLine($"n1 é menor ou igual que N2? resposta: {n1 <= N2}");
Console.WriteLine($"n1 é igual que n2? resposta: {n1 == N2}");
Console.WriteLine($"N1 é diferente que n2? resposta : {n1 != N2}");
Console.WriteLine($"n1 ou n2 são maior que zero resposta: {( n1 >0 || N2 > 0)}");
Console.WriteLine($"n1 e n2 são maior que zero resposta : {(n1 > 0 && N2 > 0)}");