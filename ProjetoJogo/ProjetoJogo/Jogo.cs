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
    public partial class Jogo : Form
    {
        public Jogo()
        {
            InitializeComponent();
        }

        List<ClassJogadores> ListaJogadores = null;

        internal List<ClassJogadores> ListaJogadores1 { get => ListaJogadores; set => ListaJogadores = value; }
        ClassJogadores j = null;
        int x = 0;
        private void Jogo_Load(object sender, EventArgs e)
        {
            foreach (ClassJogadores item in ListaJogadores)
            {
                cbNomeJogador.Items.Add(item.Nome);
            }
        }

        private void cbNomeJogador_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
            cmdIniciarJogo.Visible = true;
            lblQuem.Visible = false;
            cbNomeJogador.Visible = false ;
        }

        private void cmdIniciarJogo_Click(object sender, EventArgs e)
        {
            x = 1;
            j = ListaJogadores[cbNomeJogador.SelectedIndex];
            cmdFimdeJogo.Visible = false;
            panel1.Visible = true;
            pictureBox1.Visible = true;
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            cmdIniciarJogo.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (x == 1)
            {
                pictureBox1.Image = Properties.Resources.pergunta1;
                rb1.Text = "Escada";
                rb2.Text = "Elevador";
                rb3.Text = "Avião";
                progressBar1.Value = 20;
            }
            if (x == 2)
            {
                pictureBox1.Image = Properties.Resources.pergunta2;
                rb1.Text = "A sombra";
                rb2.Text = "A janela";
                rb3.Text = "O espelho";
                progressBar1.Value = 40;
            }
            if (x == 3)
            {
                pictureBox1.Image = Properties.Resources.pergunta3;
                rb1.Text = "Fulga da Floresta";
                rb2.Text = "Correria";
                rb3.Text = "Velozes e Furiosos 6";
                progressBar1.Value = 60;
            }
            if (x == 4)
            {
                pictureBox1.Image = Properties.Resources.pergunta5;
                rb1.Text = "Quem se importa ?";
                rb2.Text = "Serra ";
                rb3.Text = "Dilma ";
                progressBar1.Value = 80;
            }
            if (x == 5)
            {
                pictureBox1.Image = Properties.Resources.pergunta4;
                rb1.Text = "26 ";
                rb2.Text = "27 ";
                rb3.Text = "28 ";
                progressBar1.Value = 100;
            }
        }

        private void cmdResponder_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                case 1:
                    if(rb1.Checked == true)
                    {
                        j.Pontos++;
                    }
                    break;
                case 2:
                    if (rb2.Checked == true)
                    {
                        j.Pontos++;
                    }
                    break;
                case 3:
                    if (rb3.Checked == true)
                    {
                        j.Pontos++;
                    }
                    break;
                case 4:
                    if (rb1.Checked == true)
                    {
                        j.Pontos++;
                    }
                    break;
                case 5:
                    if (rb2.Checked == true)
                    {
                        j.Pontos++;
                    }
                    break;               
                default:
                    break;
            };
            x++;
            if (x==6)
            {
                pictureBox1.Visible = false;
                rb1.Visible = false;
                rb2.Visible = false;
                rb3.Visible = false;
                cmdResponder.Visible = false;
                cmdFimdeJogo.Visible = true;
            }
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
        }

        private void cmdFimdeJogo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
