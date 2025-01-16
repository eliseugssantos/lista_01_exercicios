/*
 Ex.03 -Aprovação do aluno

 
Objetivo: Compreender a aplicação das condições para a tomada de decisão. 

Descrição: Escreva um programa que solicite a nota de um aluno. 
Se a nota for maior ou igual a 6, o aluno é considerado "Aprovado". 
Caso contrário, ele está "falhando". Exiba a situação do aluno na tela. 

Exemplo de saída: "Aluno aprovado." ou "Aluno reprovado".
 */
using System.ComponentModel.Design;

Console.WriteLine("Digite sua nota:");
double nota = double.Parse(Console.ReadLine());

if (nota >= 9){
    Console.WriteLine("otimo ");
}else if (nota > 7){
    Console.WriteLine("Boa");
}else if (nota >= 5) {
    Console.WriteLine("regular");
}else{
    Console.WriteLine("baixa");
}









