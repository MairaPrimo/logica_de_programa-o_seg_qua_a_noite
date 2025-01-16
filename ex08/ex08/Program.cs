// Exercício 8: Crie um programa que solicite ao usuário um número e imprima todos os números de 1 até o número informado usando um laço `while`.

Console.WriteLine("Digite um numero");

int numero = int.Parse(Console.ReadLine());
int contador = 10;


// usar do -white para imprimir numeros de 10 até o numero informado ( decrementando de 2 em 2) 
do
{
    Console.WriteLine(contador);
    contador -= 5;
}

while (contador >= numero);
{

}