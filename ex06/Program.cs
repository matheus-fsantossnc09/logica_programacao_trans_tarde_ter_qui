﻿Console.WriteLine("Digite o 1 número");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o 2 numero");
int num2 = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("+ : " + (num1 + num2));
Console.WriteLine("- : " + (num1 - num2));      
Console.WriteLine("* : " + (num1 * num2));

if(num2 != 0)
{
    Console.WriteLine("/ : " + (num1 / num2));
}
else
{
    Console.WriteLine("/ : DIVISÃO POR ZERO NÃO E PERMITIDA");
}

Console.WriteLine("==============");
Console.WriteLine("Os números são iguais? " + (num1 == num2));
Console.WriteLine("Número 1 é maior Número 2? " + (num1 > num2));
Console.WriteLine("Número 1 é menor Número 2? " + (num1 < num2));   
Console.WriteLine("Número 1 é maior igual Número 2? " + (num1 >= num2));    
Console.WriteLine("Número 1 é menor igual Número 2? " + (num1 <= num2));    
