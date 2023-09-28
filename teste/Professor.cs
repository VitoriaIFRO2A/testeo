using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Professor : Pessoa
    {
        public string Materia { get; set; }
        public Professor(string nome, string profissao, DateTime datanascimneto, string materia) : base(nome, profissao, datanascimneto)
        {
            Nome = nome;
            Profissao = profissao;
            Materia = materia;
        }

    }
}
