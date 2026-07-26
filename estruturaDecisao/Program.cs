//If - Executa um bloco se valor for "True"
//Else - Executa o caminho alternativo caso o primeiro bloco de "false"
//Else if - Condicoes multiplas sequenciais

//Primeiro exercicio

using System.Collections.Concurrent;
using System.Diagnostics.Contracts;

Console.WriteLine("Algoritmo do Cafe");

Console.WriteLine("Tem po de cafe?");
string cafe = Console.ReadLine();

if (cafe.ToLower() == "sim")
{
    Console.WriteLine("A agua ferveu?");
    string agua = Console.ReadLine();

    if (agua.ToLower() == "sim")
    {
        Console.WriteLine("O cafe esta amargo?");
        string amargo = Console.ReadLine();

        if (amargo.ToLower() == "sim")
        {
            Console.WriteLine("Coloque acucar e beba o cafe.");
        }
        else
        {
            Console.WriteLine("Beba o cafe.");
        }
    }
    else
    {
        Console.WriteLine("Aqueça a agua antes de fazer o cafe.");
    }
}
else
{
    Console.WriteLine("Compre po de cafe antes de fazer o cafe.");
}


//ToLower serve para que o compilador nao verifique camelCase ou PascalCase


//Operadores da estrutura condicional//

"Operador igual - ==";
"Operador diferente - !=";
"Operador maior - >";
"Operador menor - <";
"Operador maior ou igual - >=";
"Operador menor ou igual - <=";


int valor1 = 5;
int valor2 = 1;

if (valor1 > valor2);
{
    Console.WriteLine(valor1 + "eh maior que" + valor2)
}
else
{
    Console.WriteLine(valor1 + "eh menor que" + valor2);
}


//Encadeamento de Ifs//

if ("condicao1 true")
{
}
else if ("condicao2 true e condicao 1 falsa")
{
}
else
{
    ("se ambas condicoes falsas");
}

int valor1 = 5;
int valor2 = 1;

if (valor1 > valor2)
{
Console.WriteLine(valor1 + "eh maior que" + valor2);
}

else if (valor1 < valor2)
{
Console.WriteLine(valor1 + "eh menor que" + valor2);
}

else
{
Console.WriteLine(valor1 + "eh igual a"+ valor2);
}

//Encadeamento de Ifs com multiplas condicoes//

"Operador && {E}- Necessita de todas as condicoes "true" para ter o resultado final "true""
"Operador || (OU) Necessita de pelo menos uma condicao "true" para ter o resultado final "true""
