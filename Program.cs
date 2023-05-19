using Projeto_Produto;

class Program
{
    static void Main(string[] args)
    {
        Login login = new Login();

        Marca mar = new Marca();

        Produto prod = new Produto();

        if (login.Logado)
        {
            string opcao;

            do
            {
               
                opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        // Cadastrar produto
                        mar.Cadastrar();
                        break;
                    case "2":
                        // Listar produtos
                        prod.Listar();
                        break;
                    case "3":
                        // Remover produto
                        Console.WriteLine("Informe o código do produto a ser removido: ");
                        int codigoProduto = int.Parse(Console.ReadLine()!);

                        prod.Deletar(codigoProduto);
                        break;
                    case "4":
                        // Cadastrar marca
                        mar.Cadastrar();
                        break;
                    case "5":
                        // Listar marcas
                        mar.Listar();
                        break;
                    case "6":
                        // Remover marca
                        Console.WriteLine("Informe o código da marca a ser removida: ");
                        int codigoMarca = int.Parse(Console.ReadLine()!);

                        mar.Deletar(codigoMarca);
                        break;
                    case "0":
                        // Sair
                        Console.WriteLine("App encerrado !");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != "0");
        }
        else
        {
            Console.WriteLine("Falha ao realizar o login. Encerrando o programa...");
        }

        Console.ReadLine();
    }
}