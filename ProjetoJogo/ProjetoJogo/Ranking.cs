using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoJogo
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        List<ClassJogadores> ListaRanking = null;

        internal List<ClassJogadores> ListaRanking1 { get => ListaRanking; set => ListaRanking = value; }

        private void Ranking_Load(object sender, EventArgs e)
        {
            foreach (ClassJogadores x in ListaRanking)
            {
                LTranking.Items.Add(x.MostraRanking());              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
