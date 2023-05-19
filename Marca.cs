using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto
{
    public class Marca
    {
        public string NomeMarca { get; set; }

        public int Codigo { get; set; }

        public DateTime DataCadastro { get; set; }

        List<Marca> listaMarcas = new List<Marca>();

        public Marca Cadastrar()
        {
            Marca novaMarca = new Marca();

            Console.WriteLine($"Digite o nome da Marca: ");
            novaMarca.NomeMarca = Console.ReadLine()!;

            Console.WriteLine($"Agora, digite o código da Marca: ");
           novaMarca. Codigo = int.Parse(Console.ReadLine()!);

            novaMarca.DataCadastro = DateTime.Now;


            listaMarcas.Add(novaMarca);

            Console.WriteLine($"Marca Cadastrada !");


            return novaMarca;
        }

        public void Listar()
        {
            Console.WriteLine($"*********Lista de Marcas *********");
            foreach (var marca in listaMarcas)
            {
                Console.WriteLine($"Nome: {marca.NomeMarca}");
                Console.WriteLine($"Código: {marca.Codigo}");
                Console.WriteLine($"Data de Cadastro: {marca.DataCadastro}");
                Console.WriteLine($"*******************************************");




            }


        }

        public void Deletar(int Codigo)
        {

            Marca marcaParaDeletar = null;

            foreach (var marca in listaMarcas)
            {
                if (marca.Codigo == Codigo)
                {

                    marcaParaDeletar = marca;
                    break;
                }
            }

            if (marcaParaDeletar != null)
            {

                listaMarcas.Remove(marcaParaDeletar);
                Console.WriteLine($"Marca removida !");


            }

            else
            {

                Console.WriteLine($"O código informado não é válido !");

            }
        }
    }
}