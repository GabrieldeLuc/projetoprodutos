using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto
{
    public class Produto
    {



        public int Codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        public DateTime DataCadastro { get; set; }

        public Marca Marca = new Marca();

        public Usuário CadastradoPor { get; set; }

        List<Produto> listaprodutos = new List<Produto>();

        public void Cadastrar()
        {

            Produto novoProduto = new Produto();

            Console.WriteLine($"Digite o Código do Produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Agora, digite o nome do Produto: ");
            novoProduto.NomeProduto = Console.ReadLine()!;

            Console.WriteLine($"Agora,  informe o preço do Produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            novoProduto.DataCadastro = DateTime.Now;

            Console.WriteLine($"informe os dados da Marca do Produto: ");
            novoProduto.Marca = new Marca();
            novoProduto.Marca.Cadastrar();

            Console.WriteLine($"informe os dados do Usuario responsável pelo cadastro: ");
            novoProduto.CadastradoPor = new Usuário();
            novoProduto.CadastradoPor.Cadastrar();

            listaprodutos.Add(novoProduto);

            Console.WriteLine($"O Produto foi Cadastrado !");



        }

        public void Listar()
        {
            Console.WriteLine($"*********Lista de Produtos*********");
            foreach (var produto in listaprodutos)
            {
                Console.WriteLine($"Código: {produto.Codigo}");
                Console.WriteLine($"Nome: {produto.NomeProduto}");
                Console.WriteLine($"Preço: {produto.Preco}");
                Console.WriteLine($"Data de Cadastro: {produto.DataCadastro}");
                Console.WriteLine($"Dados da Marca: ");
                Console.WriteLine($"Nome: {produto.Marca.NomeMarca}");
                Console.WriteLine($"Código: {produto.Marca.Codigo}");
                Console.WriteLine($"Data de Cadastro: {produto.DataCadastro}");
                Console.WriteLine($"Dados do Usuario: ");
                Console.WriteLine($"Nome: {produto.CadastradoPor.nome}");
                Console.WriteLine($"Email: {produto.CadastradoPor.email}");
                Console.WriteLine($"*************************************");

            }

        }

        public void Deletar(int codigo)
        {
            Produto produtoParaDeletar = null;

            foreach (var produto in listaprodutos)
            {
                if (produto.Codigo == codigo)
                {

                    produtoParaDeletar = produto;
                    break;
                }
            }
            if (produtoParaDeletar != null)
            {

                listaprodutos.Remove(produtoParaDeletar);
                Console.WriteLine($"Produto Removido !");


            }

            else
            {

                Console.WriteLine($"Nenhum código encontrado ");

            }

        }
    }
}
