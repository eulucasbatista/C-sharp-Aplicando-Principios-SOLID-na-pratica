using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _This
{
    class Funcionario
{
        public string Nome { get; set; }
        public string Email { get; set; }

        public Funcionario(string Nome, string Email)
        {
            //Use this para qualificar as propriedades
            //Nome e Email evitando confusão com os nomes
            // dos parâmetros usados no construtor

            this.Nome = Nome;
            this.Email = Email;
        }
    }
}
