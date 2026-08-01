//Calcule e exiba a tabuada do 0 ao 20  

int tabuada = 0;

while (tabuada <= 20)
{
    Console.WriteLine($"2 x {tabuada} = {tabuada *2}");
    tabuada++;
}

//Crie um validador de entrada de dados. Enquanto o usuario nao digitar entre 1 e 10 peca para digitar novamente
//Primeira opcao

int num = 0;
Console.WriteLine("Digite um numero entre 01 e 10");

while (num <1 || num >10)
{
    Console.WriteLine("Digite um numero valido");
    num = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Numero valido inserido com sucesso!");

//Segunda opcao

int num =0;
bool invalido = false;
while( num <1 || num >10)
{
    if (invalido)
    {
        Console.Write("Numero invalido");
    }
    Console.WriteLine("Digite um numnero entre 01 e 10");
    num = int.Parse(Console.ReadLine());
    invalido = true;
}
Console.WriteLine("Numero valido inserido com sucesso!");

//Validacao completa de input

Console.WriteLine ("Digite um numero");
bool ehNumero = int.TryParse (Console.ReadLine(), out int num);
while(!ehNumero )
{
    Console.WriteLine("Valor invalido. Digite um numero: ");
    ehNumero = int.TryParse(Console.ReadLine(), out num);
}

// Console.WriteLine("O numero digitado foi "+ num);


//Tabuada utilizando a estrutura 'for'

for ( int tabuada =0; tabuada <= 20; tabuada++) 
{
    Console.WriteLine($"2 x {tabuada} = {tabuada *2}");
}

//Calcule o fatorial de  N (obtido do usuario) e multiplicar todos os numeros antessesores positivos



//receber o valor;

Console.WriteLine("Digite um numero para calcular o fatorial: ");
int fatorial = int.Parse(Console.ReadLine());


//while 
int fatorialWhile = fatorial;
int resultadoWhile = 1;
while (fatorialWhile > 1)
{
    resultadoWhile = resultadoWhile * fatorialWhile;
    fatorialWhile--;
}
Console.WriteLine("resultado do fatorial de " + fatorial + "  é " + resultadoWhile);

//do while 
int doFatorial = fatorial;
int doResultado = 1;

do
{
    doResultado = doResultado * doFatorial;
    doFatorial--;

} while (doFatorial > 1);
Console.WriteLine("resultado do fatorial de " + fatorial + "  é " + doResultado);


//for 
int forResultado = 1;
for (int forFatorial = fatorial; forFatorial > 1; forFatorial--)
{
    forResultado = forResultado * forFatorial;
}
Console.WriteLine("resultado do fatorial de " + fatorial + "  é " + forResultado);


//for 

int resultado = 1;
for (int i = 1; i <= fatorial; i++)
{
    resultado = resultado * i;
}
Console.WriteLine("resultado do fatorial de " + fatorial + "  é " + resultado);


