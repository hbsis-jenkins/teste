using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaDTO
{
    public class Pessoa
    {
        public String Cpf { get; set; }

        public String Nome { get; set; }

        public Pessoa(String cpf, string nome)
        {
            this.Cpf = cpf;
            this.Nome = nome;
        }
    }
}
