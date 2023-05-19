using Projeto_Produto;

namespace Projeto_Produto
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login()
        {


            Usuário user = new Usuário();
            user.email = "chaolinmatador@gmail.com";
            user.senha = "123456";


            // Validar se está logado
            Logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }

        public void Logar(Usuário usuario)
        {
            // Aqui vai a lógica
            Console.WriteLine($"Insira seu email: ");
            string email = Console.ReadLine()!;

            Console.WriteLine($"Insira sua senha: ");
            string senha = Console.ReadLine()!;

            if (email == usuario.email && senha == usuario.senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login efetuado com sucesso !");
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar !");
            }
        }

        public void Deslogar()
        {
            Logado = false;
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;

            do
            {
                Console.WriteLine(@$"
            [1] - Cadastrar Produto
            [2] - Listar Produtos
            [3] - Remover Produto
            ----------------------
            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Remover Marca

            [0] - Sair
            ");

                opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        // Cadastrar
                        produto.Cadastrar();
                        break;
                    case "2":
                        // Listar
                        produto.Listar();
                        break;
                    case "3":
                        // Remover
                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoProduto = int.Parse(Console.ReadLine()!);

                        produto.Deletar(codigoProduto);
                        break;
                    case "4":
                        // Cadastrar
                        marca.Cadastrar();
                        break;
                    case "5":
                        // Listar
                        marca.Listar();
                        break;
                    case "6":
                        // Remover
                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoMarca = int.Parse(Console.ReadLine()!);

                        marca.Deletar(codigoMarca);
                        break;
                    case "0":
                        // Sair
                        Console.WriteLine($"App encerrado !");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida!");
                        break;
                }
            } while (opcao != "0");
        }
    }
}