// Calcular que recebe 2 numeros e apresenta + - * /

Console.Write("Informe o 1 número: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("informe o 2 numero");
int num2 = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("soma :" + (num1 + num2));
Console.WriteLine("subtração : " + ( num1 - num2 ));
Console.WriteLine("multiplicação :" + (num1* num2));
Console.WriteLine("divisao :" + (num1 * num2));
if (num2 != 0)
{
    Console.WriteLine("divisão : " + (num1 * num2));
}
else

    Console.WriteLine("divisão por ZERO não permitida");
