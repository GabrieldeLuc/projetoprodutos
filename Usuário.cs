using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto
{
    public class Usuário
    {
        public int Codigo { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public DateTime DataCadastro { get; set; }


        public void Usuario()
        {

            Cadastrar();
        }
        public void Cadastrar()
        {

            Console.WriteLine($"Digite seu nome de Usuário: ");
            this.nome = Console.ReadLine()!;

            Console.WriteLine($"Digite o seu email de Usuário: ");
            this.email = Console.ReadLine()!;

            Console.WriteLine($"Crie uma senha: ");
            this.senha = Console.ReadLine()!;

            this.DataCadastro = DateTime.Now;


            Console.WriteLine($"Usuario Cadastrado !");

        }


        public void Deletar()
        {
            this.nome = "";

            this.email = "";

            this.nome = "";

            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");

            Console.WriteLine($"Usuário deletado !");


        }
    }
}