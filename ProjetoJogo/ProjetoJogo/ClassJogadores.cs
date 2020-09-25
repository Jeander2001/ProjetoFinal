using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJogo
{
    class ClassJogadores
    {
        private string nome;
        private int pontos;
        public string Nome { get => nome; set => nome = value; }
        public int Pontos { get => pontos; set => pontos = value; }

        //public ClassJogadores()
        //{
        //    this.Pontos = Pontos + 0;
        //    this.Nome = Nome;
        //}

        public string MostraRanking()
        {
            string aux = "";
            aux = Nome + "\t\t" + Pontos.ToString() + " Pontos\t\t";
            return aux;
        }

    }
}
