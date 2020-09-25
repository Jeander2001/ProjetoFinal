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
    public partial class CadastroFalso : Form
    {
        public CadastroFalso()
        {
            InitializeComponent();
        }

        private void cmdJogarFalso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EI.. Use o célebro !!, quer jogar antes de cadastrar ??");
        }

        private void cmdCadastrarFalso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não pensou que seria tão facil assim né ?");
            MessageBox.Show("Isso é um jogo de chadaras.. hahaha");
            Close();
        }

        private void cmdSairCadastroFalso_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
