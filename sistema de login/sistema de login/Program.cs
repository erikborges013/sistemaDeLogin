//sistema de login

using System.ComponentModel;

Dictionary<string, string> login = new Dictionary<string, string>();

MainLoop();

void MainLoop()
{
do
{
    Menu();
} while(true);
}



void Menu()
{

    Console.Clear();
    int entrada;
    do
    {

        Console.WriteLine("MENU\n");

        Console.WriteLine("Digite 1 para fazer login");
        Console.WriteLine("Digite 2 para se cadastrar");
        Console.WriteLine("Digite 0 para sair");
        Console.Write("Escolha uma das opções acima: ");
        string? input = Console.ReadLine();
         
    if (!int.TryParse(input, out entrada) || entrada > 2)
    {
        Console.Clear();
        Console.WriteLine("Opção inválida! Tente novamente");
        
    } else
    {
        break;
    }
    } while(true);
   

    switch (entrada)
    {
        case 0:
            {
                Console.WriteLine("Até logo!");
                Environment.Exit(0); //encerra app
            }
            break;
        case 1:
            {
                FazerLogin();
            }
            break;
        case 2:
            {
                SeCadastrar();
            }
            break;
    }
}

void FazerLogin()
{
    string usuarioDigitado;
    Console.WriteLine("EFETUAR LOGIN");
    Console.Write("Digite o seu usuário: ");
    usuarioDigitado = Console.ReadLine()!;
    if (!login.ContainsKey(usuarioDigitado))
    {
        Console.WriteLine("Esse usuário não existe. Tente novamente ou faça o cadastro.");
        Thread.Sleep(3000);
        return;
    }

    Console.Write("Digite a sua senha:");
    string senhaDigitada = Console.ReadLine()!;

    if (login.TryGetValue(usuarioDigitado, out string? senhaCadastrada) && senhaCadastrada == senhaDigitada)
    {
        Console.WriteLine("Login efetuado com sucesso!");
        Thread.Sleep(3000);
    } else
    {
        Console.WriteLine("Senha incorreta!");
        Thread.Sleep(3000);
    }

}

void SeCadastrar()
{
   Console.Clear();
   Console.WriteLine("CADASTRAR USUÁRIO\n");
   string nome;

   do
   {
    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine()!;
    if (login.ContainsKey(nome))
    {
        Console.WriteLine("Usuário já cadastrado. Tente novamente.");

    } else
    {
        break;
    }
   } while (true);
   Console.WriteLine("CADASTRAR SENHA\n");
   Console.Write("Digite sua senha: ");
   string senha = Console.ReadLine()!;
   login[nome] = senha;

   Console.WriteLine("Usuário cadastrado com sucesso.");
   Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
   Console.ReadKey();
   

}
   