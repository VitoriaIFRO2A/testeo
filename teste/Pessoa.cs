using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public DateTime Datanascimneto { get; set; }
        public Pessoa() { }

        public Pessoa(string nome, string profissao, DateTime datanascimneto)
        {
            Nome = nome;
            Profissao = profissao;
            Datanascimneto = datanascimneto;
        }
    }
}
