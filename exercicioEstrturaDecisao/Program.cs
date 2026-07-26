// // //Leia um número inteiro N. Se N for positivo (maior que 0) imprima positivo, senao sera nao positivo//

Console.WriteLine("Desafio #01");

Console.WriteLine("Digite um numero para verificar se e postivo");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("positivo");
}
else
{
    Console.WriteLine("nao positivo");
}

// // //Leia um numero inteiro N. Verifique se N eh multiplo de 5 e caso sim, imprima Multiplo de 5, caso nao imprima Nao eh Multiplo//

Console.WriteLine("Digite um numero para verificar se e positivo e multiplo de 5");

int num = Convert.ToInt32(Console.ReadLine());

if (num %5 ==0)
{
    Console.WriteLine("Positivo e Multpiplo de 5");
}
else
{
    Console.WriteLine("Negativo nao possui multiplos");
}

// //Verificacao de maioridade com condicao extra

Console.WriteLine("Digite sua idade");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade < 18)
{
    Console.WriteLine("Menor de idade");
}
else if (idade >= 18 && idade <65)
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Maior de idade e idoso");
}


// // Verificacao de valor para aplicacao de desconto

Console.WriteLine("Digite o valor da compra");
decimal valorCompra = Convert.ToDecimal(Console.ReadLine());

decimal desconto;

if (valorCompra >= 500)
{
   desconto = valorCompra * 0.2m;  
}
else if (valorCompra >=200 && valorCompra <500)
{
   desconto = valorCompra * 0.1m;
}
else
{
    desconto = valorCompra* 0.0m;
}

decimal valorPagar = valorCompra - desconto;
Console.WriteLine("Valor final eh: " + valorPagar);


// //Sistema de aprovacao de credito

Console.WriteLine ("Digite a renda");
decimal renda = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Cliente eh negativado?");
string score = Convert.ToString(Console.ReadLine());

Console.WriteLine("Digite a idade");
int checkIdade = Convert.ToInt32(Console.ReadLine());

if (renda >= 3000 && renda <8000 && score == "Não" && checkIdade >= 18 && checkIdade < 65)
{
    Console.WriteLine("Credito aprovado");
}
else
{
    Console.WriteLine("Credito negado");
}

if (renda >=8000 && score =="Não" && checkIdade >=18 && checkIdade <65)
{
    Console.WriteLine("Credito pre autorizado");
}


//Calculo de frete

Console.WriteLine("Digite a distância em KM");
decimal distancia = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite o peso em quilos");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine("Cliente Premium ou Basico?");
string cliente = Console.ReadLine();

if (distancia < 0 || peso < 0)
{
    Console.WriteLine("Erro: distância e peso não podem ser negativos.");
}
else
{
    decimal frete = distancia * 1.5m;

    if (peso > 100)
    {
        frete *= 1.12m;
    }
    if (cliente == "Premium" && peso <= 200)
    {
        frete *= 0.85m;
    }
    if (distancia > 1000 && peso > 150)
    {
        frete *= 1.08m;
    }

    Console.WriteLine($"Frete: R$ {frete:F2}");
}