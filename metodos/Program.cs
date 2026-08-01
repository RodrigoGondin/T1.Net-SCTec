// quero fazer somas 
int num = 5;
int num2 = 10;

int resultado = SomaDoisNumeros(num, num2);

int resultado2 = SomaDoisNumeros(5,20);

int SomaDoisNumeros(int num1, int num2)
{
    int soma = num1 + num2; 
    Console.WriteLine($"{num1} + {num2} = {soma}");
    return soma; 
}

int ObtemUmNumeroSimples(string mensagem)
{
    Console.WriteLine(mensagem);
    return int.Parse(Console.ReadLine());
}


int ObtemUmNumero(string mensagem)
{
    Console.WriteLine(mensagem);
    
    bool ehNumero =  int.TryParse(Console.ReadLine(), out int num);
    while (!ehNumero)
    {
        Console.WriteLine("Numero Invalido digite novamente  ");
        ehNumero =  int.TryParse(Console.ReadLine(), out  num);
    }
    return num;
}

// int num1 = ObtemUmNumero("Digite um numero: ");

// int num3 = ObtemUmNumero("Digite outro numero: ");

// int num4 = ObtemUmNumero("Digite mais um numero: ");

/// AULA sexta 14/06/2024
/// 

// EXERCÍCIO 1
// Crie um método chamado
// Subtrair que recebe dois números inteiros (int) como parâmetros.
// O método deve retornar (return) o resultado da subtração do primeiro pelo segundo.

// Quando criamos metodo na program nao usamos o modificador , mas quando criamos fora da program.cs usamos.


int Subtrair( int num1, int num2)
{
    int resultado = num1 -num2; 
    return resultado;
}

int resultadoSbtrair = Subtrair(5,2);
Console.WriteLine($"o resultado da subtração foi: {resultadoSbtrair}");

// int num1Sub = ObtemUmNumeroSimples("Digite um numero para subtrair");
// int num2Sub = ObtemUmNumeroSimples("Digite outro numero para subtrair");
// int resultadoSubtrair2 = Subtrair(num1Sub,num2Sub);
// Console.WriteLine($"O Resultado de {num1Sub} - {num2Sub} = {resultadoSubtrair2}");



// EXERCÍCIO 2
// Crie um método do tipo void chamado Mostrarldade.
// Ele deve receber o ano de nascimento (int), calcular a idade baseada no ano atual e exibir no Console. WriteLine.

void MostrarIdade (int anoNascimento)
{
    int anoAtual = DateTime.Now.Year; //2026; 
    int idade = anoAtual - anoNascimento;
    Console.WriteLine("você tem "+ idade +" anos ");
}

void MostrarIdadeData (DateTime anoNascimento)
{
    DateTime dia = DateTime.Now.Date; //2026; 
    TimeSpan idade = dia - anoNascimento;
    Console.WriteLine("você tem "+ Math.Floor(idade.TotalDays / 365) +" anos ");
}

MostrarIdade(2010);
MostrarIdadeData( new DateTime(2010, 08 ,05));


// EXERCÍCIO 3
// Crie um método chamado
// VerificarPar que recebe um número inteiro.
// O método deve ter o retorno bool (true/false). Retorne true se for par e false se for ímpar.

bool VerificarPar(int num)
{
    return num%2 == 0;
}


bool ehPar = VerificarPar(5);

if (ehPar)
{
    Console.WriteLine("O numero é par ");
}
else
{
    
    Console.WriteLine("O numero Não é par ");
}