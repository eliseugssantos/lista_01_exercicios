﻿/*Ex.02 -Número Positivo ou Negativo
 
Objetivo: Aprenda a trabalhar com várias condições. 

Descrição: Desenvolva um programa que solicite ao usuário um número. O programa deve determinar
se o número é positivo, negativo ou zero, usando if, else if e else para todas as três possibilidades.
Exiba a mensagem correspondente. 

Exemplo de saída: "O número é positivo.", "O número é negativo." ou "O número é zero".
   */


Console.WriteLine("Digite um número: ");
int num = int.Parse(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("O número é positivo");
}
else if (num < 0)
{
    Console.WriteLine("O número é negativo");
}
 else
{
    Console.WriteLine("O número é zero");
}