int opcao;
string[] produto = new string[10];
string[] preco = new string[10];
bool[] resposta = new bool[10];

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(@$"
    --------------------------------
    |          Bem vindo           |
    |   Escolha uma opcao abaixo   |
    |                              |  
    |    1 - Cadastrar Produto     |
    |    2 - Listar Produtos       |
    |                              |
    |    0 - Sair                  |
    --------------------------------                
");
Console.ResetColor();
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {

        case 1:
            Console.WriteLine($"Cadastro de produtos");

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite o produto: ");
                produto[i] = Console.ReadLine();
                Console.Write("Digite o preco do produto: ");
                preco[i] = Console.ReadLine();
                Console.Write("Produto esta em promocao? (S/N): ");
                resposta[i] = Console.ReadLine().ToLower() == "s";
                Console.WriteLine($"");
                Console.ResetColor();
            }

            Console.WriteLine($"Produto(s) cadastrado(s) com sucesso!");
            break;

        case 2:
            Console.WriteLine($"Listagem de Produtos:");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (produto[i] != null || produto[i] != "")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{produto[i]} - R${preco[i]} {(resposta[i] ? "(em promoção)" : "")}");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }

            break;

        case 0:
            Console.WriteLine($"Saindo do sistema...");
            break;
        default:
            Console.WriteLine($"Opção inválida. Tente novamente.");
            break;
    }

} while (opcao != 0);