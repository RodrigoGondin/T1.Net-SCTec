﻿// Crie um sistema que peça usuário e senha. 
// O usuário tem 3 tentativas. 
// Se errar 3 vezes, o sistema bloqueia o acesso. 
// Se acertar, exibe “Login realizado com sucesso”.

string UsuarioRoot = "admin";
string SenhaRoot = "admin123";

string usuarioDigitado;
string senhaDigitada;
int contaFalhas =0;

do
{     
    Console.WriteLine("Digite seu usuario: "); 
    usuarioDigitado = Console.ReadLine(); 
    Console.WriteLine("Digite sua senha: "); 
     senhaDigitada = Console.ReadLine(); 

    if (UsuarioRoot == usuarioDigitado && 
        SenhaRoot == senhaDigitada)
    {
        Console.WriteLine("Login realizado com sucesso");
    }
    else
    {
        contaFalhas ++; 
        Console.WriteLine("usuario Inválido ");
    }
} while((UsuarioRoot != usuarioDigitado ||
        SenhaRoot != senhaDigitada) &&  contaFalhas < 3);


if (UsuarioRoot != usuarioDigitado ||
        SenhaRoot != senhaDigitada)
{
    Console.WriteLine("Usuario Bloqueado! ");
}

/// solucao Taise 
Console.WriteLine("Informe o login e senha corretamente! Você tem três tentativas!");
string login = "Taise";
string senha = "1234";
string l;
string s;

for (int i = 1; i < 4; i++)
{
    Console.WriteLine($"Sua {i}ª tentativa: ");
    Console.WriteLine("Informe o login: ");
    l = Console.ReadLine();
    Console.WriteLine("Informe a senha: ");
    s = Console.ReadLine();
    if (login == l && senha == s) {
        Console.WriteLine("Login realizado com sucesso!");
        break;
    } else
    {
        Console.WriteLine("Senha incorreta digite novamente");
        if (i == 3)
        {
            Console.WriteLine("Acesso bloqueado!");
        }
    }
}



// Leonardo eu e o copilot fizemos este:
// criar um simulador de login com tentativas limitadas
int maxTentativas = 3;
int tentativas = 0;

while (tentativas < maxTentativas)
{
    Console.Write("Digite seu usuário: ");
    string usuario = Console.ReadLine();

    Console.Write("Digite sua senha: ");
    senha = Console.ReadLine();

    // Simulação de verificação de login
    if (usuario == "admin" && senha == "1234")
    {
        Console.WriteLine("Login bem-sucedido!");
        break;
    }
    else
    {
        tentativas++;
        Console.WriteLine($"Usuário ou senha incorretos. Tentativa {tentativas} de {maxTentativas}.");
        
        if (tentativas == maxTentativas)
        {
            Console.WriteLine("Número máximo de tentativas atingido. Acesso negado.");
        }
    }
}