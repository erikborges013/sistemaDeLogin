//sistema de login

using System.ComponentModel;

Dictionary<string, string> login = new Dictionary<string, string>();

Menu();

void Menu()
{
    Console.Clear();
    Console.WriteLine("MENU\n");

    Console.WriteLine("Digite 1 para fazer login");
    Console.WriteLine("Digite 2 para se cadastrar");
    Console.WriteLine("Digite 0 para sair");
    Console.Write("Escolha uma das opções acima: ");
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out int entrada) || entrada > 2)
    {
        Console.WriteLine("Opção inválida! Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Menu();
    }

    switch (entrada)
    {
        case 0:
            {
                Console.WriteLine("Até logo!");
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

}

void SeCadastrar()
{
    Console.WriteLine("CADASTRAR USUÁRIO\n");
    Console.Write("Digite o seu nome: ");
    string nome = Console.ReadLine()!;
   
    if (!login.ContainsKey(nome))
    {
        Console.WriteLine("\nCadastrar senha: ");
        string senha = Console.ReadLine()!;
        login[nome] = senha;
        Console.WriteLine("Cadastro realizado com sucesso!");
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Menu();
    } else
    {
        Console.WriteLine("Esse nome já existe. Escolha outro nome.");
        Thread.Sleep(2000);
        SeCadastrar();
    }

        


}
   