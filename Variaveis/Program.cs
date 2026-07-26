//Declarando variaveis no C# //


int num1 =5;   //Declaracao atribuindo Tipo + Nome da variavel + Valor
int num1;      //Sem atribuir valor
var num1 = 5;  //Sem abtribuir a variavel que sera atribuida pelo compilador

//Convencoes

// 1- Sem espacos
// 2- Sem caracteres especiais e acentos
// 3- Formato cammelCase para nomes de variaveis compostos. Ex: nomeCompleto, valorLiquido, formacaoAcademica
// 4- Descrever o nome da variavel Ex: int Salario = X, string nomeCompleto = Y

//Operacoes

int num1 = 5;
int resultado;
resultado = num1 + 1;

int num1 = 5;
num1 = num1 + 1;   //ou//

int num1 = 5;
num1 += 1;

int num1 = 5;
int num2 = 10;
int resultado;
resultado = num1 + num2

//------------------------//

string nome = "Rodrigo";
string sobrenome = "Gondin";
var nomeCompleto = nome + sobrenome;

string num1 = "5";
string num2 = "1";
string total = num1 + num2; // Como eh string, o compilador entende que eh texto e vai printar "51" e nao somar como no exemplo anterior.

//----------------------//

int //Numeros inteiros//
double //Decimais n.nn//
string //Texto//
bool //Verdadeiro ou falso//


//Precedencia em logica de calculo//

"Parenteses";
"Subtracao";
"Multiplicacao";
"Divisao";
"Modulo (Resto da divisao)";
