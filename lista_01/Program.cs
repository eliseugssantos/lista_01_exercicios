/*
Ex.01 Verificação de paridade

Objetivo: Pratique o uso do operador % (módulo) e estruturas condicionais simples. 
Descrição: Crie um programa que solicite que o usuário digite um número inteiro. O programa deve verificar se o número é par ou ímpar.
Use a condição if para determinar o resultado e exibir uma mensagem apropriada. 
Exemplo de saída: "O número é par." ou "O número é ímpar".

 
 */

Console.WriteLine("Digite um numero");
int num1 = int.Parse(Console.ReadLine());

int resultado = num1 % 2;

if (resultado == 0)
{
    Console.WriteLine("O Número digitado é par");
}
if (resultado >= 1)
{
    Console.WriteLine("O Número digitado é impar");
}