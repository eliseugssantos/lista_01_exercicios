/*
Ex.09 - Dia da semana (usando if-else)

 
Objetivo: Pratique o uso de várias condições com if, else if e else. 
Descrição: Desenvolva um programa que solicite um número de 1 a 7 e exiba o dia da semana correspondente (1 para "domingo", 2 para "segunda-feira", etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de erro. 
Exemplo de saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. Digite um número de 1 a 7."*/

Console.WriteLine("Digite um número");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("DOMINGO");
}
else if (num == 2)
{
    Console.WriteLine("SEGUNDA");

}
else if (num == 3) 
{
    Console.WriteLine("TERÇA");
}
else if (num == 4)
{
    Console.WriteLine("QUARTA");
}
else if (num == 5)
{ 
    Console.WriteLine("QUINTTA");
}
else if (num == 6)
{
    Console.WriteLine("SEXTA");
}
else if (num == 7)
{
    Console.WriteLine("SÁBADO");
}
else 
{
    Console.WriteLine("ERRO");
}
