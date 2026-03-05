using System;

namespace _This
{
        class Teste
        {
                public string Nome { get; set; }
                public Teste(Exemplo exemplo)
                {
                    // Usa o nome da instância Perl
                    this.Nome = exemplo.Nome;
                    Console.WriteLine($"Teste : {this.Nome}");
                }
        }
        class Exemplo
        {

            public string Nome { get; set; }

            public Exemplo(string nome)
            {

                this.Nome = nome;
                // Passa a instância this como um parâmetro
                Teste teste = new Teste(this);
                // A instçância Teste agora possui o mesmo nome
                Console.WriteLine($"Exemplo : {teste.Nome}");
            }
        }

        class Program
        {
        
            static void Main(string[] args)
            {
                Exemplo exemplo = new Exemplo("Eleven");
                Console.ReadLine();
            }
        }
}