using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoJogo
{
    public partial class Menu : Form
    {
        List<ClassJogadores> listaPrincipal = new List<ClassJogadores>();
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroFalso cadastroFalso = new CadastroFalso();
            cadastroFalso.ShowDialog();
        }

        private void cmdCadastroReal_Click(object sender, EventArgs e)
        {
            CadastroReal cadastroReal = new CadastroReal();
            cadastroReal.ListaCadastro1 = listaPrincipal;
            cadastroReal.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            jogo.ListaJogadores1 = listaPrincipal;
            jogo.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Ranking ranking = new Ranking();
            ranking.ListaRanking1 = listaPrincipal;
            ranking.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.dicio.com.br/charada/");
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = ("Não sabe o que é charada ??");
          
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblHora.Text = DateTime.Now.ToString("T");
            timer1.Enabled = true;
        }

    }
}
