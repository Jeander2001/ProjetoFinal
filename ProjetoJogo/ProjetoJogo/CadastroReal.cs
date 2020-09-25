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
    public partial class CadastroReal : Form
    {
        public CadastroReal()
        {
            InitializeComponent();
        }

        List<ClassJogadores> ListaCadastro = null;

        internal List<ClassJogadores> ListaCadastro1 { get => ListaCadastro; set => ListaCadastro = value; }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdCadastroReal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oque está procurando aqui usuário ??");
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            ClassJogadores J = new ClassJogadores();
            J.Nome = txtNick.Text;
            ListaCadastro1.Add(J);
            Close();
        }
    }
}
