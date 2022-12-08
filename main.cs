using System;

class Program {
  public static void Main (string[] args) {
//A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais de 40 horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%. Escreva um algoritmo que leia o número de horas trabalhadas em um mês, o salário por hora e escreva o salário total do funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas (considere que o mês possua 4 semanas exatas). 
    
Double salario_hora, horas_trabalhadas, horas_extras, salario_hora_extra,salario_extra, salario_final;
String entrada; 
    
Console.WriteLine("Horas trabalhadas no mês: ");
entrada = Console.ReadLine ();
    horas_trabalhadas = Double.Parse(entrada);
    
Console.WriteLine("Salário por hora de trabalho: ");
entrada = Console.ReadLine ();
    salario_hora = Double.Parse(entrada);

horas_extras = horas_trabalhadas - 160.0;
 
salario_hora_extra = salario_hora * 1.5;

// Ou :  salario_hora_extra <- salario_hora + (salario_hora * 0.5)

salario_extra = salario_hora_extra * horas_extras;

salario_final = (salario_hora_extra * horas_extras) + (160.0 * salario_hora);

Console.WriteLine ("Salário : " + 160.0*salario_hora);
Console.WriteLine ("Salário das horas extras : " +salario_extra);
Console.WriteLine ("Salário final : "+salario_final);
    
  }
}