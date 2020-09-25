namespace ProjetoJogo
{
    partial class Jogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.cmdIniciarJogo = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdResponder = new System.Windows.Forms.Button();
            this.cmdFimdeJogo = new System.Windows.Forms.Button();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.lblQuem = new System.Windows.Forms.Label();
            this.cbNomeJogador = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdIniciarJogo
            // 
            this.cmdIniciarJogo.BackColor = System.Drawing.Color.Transparent;
            this.cmdIniciarJogo.Location = new System.Drawing.Point(352, 51);
            this.cmdIniciarJogo.Name = "cmdIniciarJogo";
            this.cmdIniciarJogo.Size = new System.Drawing.Size(103, 23);
            this.cmdIniciarJogo.TabIndex = 12;
            this.cmdIniciarJogo.Text = "Iniciar Jogo";
            this.cmdIniciarJogo.UseVisualStyleBackColor = false;
            this.cmdIniciarJogo.Visible = false;
            this.cmdIniciarJogo.Click += new System.EventHandler(this.cmdIniciarJogo_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensagem.Location = new System.Drawing.Point(42, 30);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(729, 18);
            this.lblMensagem.TabIndex = 11;
            this.lblMensagem.Text = "Bom usuário.. Já que chegou até aqui, vamos ver se consegue advinhar minhas chara" +
    "das..";
            this.lblMensagem.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cmdResponder);
            this.panel1.Controls.Add(this.cmdFimdeJogo);
            this.panel1.Controls.Add(this.rb3);
            this.panel1.Controls.Add(this.rb2);
            this.panel1.Controls.Add(this.rb1);
            this.panel1.Location = new System.Drawing.Point(148, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 358);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Progresso :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(95, 303);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjetoJogo.Properties.Resources.pergunta1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cmdResponder
            // 
            this.cmdResponder.Location = new System.Drawing.Point(219, 332);
            this.cmdResponder.Name = "cmdResponder";
            this.cmdResponder.Size = new System.Drawing.Size(75, 23);
            this.cmdResponder.TabIndex = 7;
            this.cmdResponder.Text = "Responder";
            this.cmdResponder.UseVisualStyleBackColor = true;
            this.cmdResponder.Click += new System.EventHandler(this.cmdResponder_Click);
            // 
            // cmdFimdeJogo
            // 
            this.cmdFimdeJogo.Location = new System.Drawing.Point(219, 303);
            this.cmdFimdeJogo.Name = "cmdFimdeJogo";
            this.cmdFimdeJogo.Size = new System.Drawing.Size(75, 23);
            this.cmdFimdeJogo.TabIndex = 4;
            this.cmdFimdeJogo.Text = "Fim de Jogo";
            this.cmdFimdeJogo.UseVisualStyleBackColor = true;
            this.cmdFimdeJogo.Click += new System.EventHandler(this.cmdFimdeJogo_Click);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.Color.Transparent;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb3.Location = new System.Drawing.Point(23, 239);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(119, 24);
            this.rb3.TabIndex = 3;
            this.rb3.Text = "radioButton3";
            this.rb3.UseVisualStyleBackColor = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.BackColor = System.Drawing.Color.Transparent;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb2.Location = new System.Drawing.Point(23, 201);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(119, 24);
            this.rb2.TabIndex = 2;
            this.rb2.Text = "radioButton2";
            this.rb2.UseVisualStyleBackColor = false;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.Transparent;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb1.Location = new System.Drawing.Point(23, 165);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(119, 24);
            this.rb1.TabIndex = 1;
            this.rb1.Text = "radioButton1";
            this.rb1.UseVisualStyleBackColor = false;
            // 
            // lblQuem
            // 
            this.lblQuem.AutoSize = true;
            this.lblQuem.BackColor = System.Drawing.Color.Transparent;
            this.lblQuem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuem.Location = new System.Drawing.Point(6, 6);
            this.lblQuem.Name = "lblQuem";
            this.lblQuem.Size = new System.Drawing.Size(98, 16);
            this.lblQuem.TabIndex = 8;
            this.lblQuem.Text = "Quem é você ?";
            // 
            // cbNomeJogador
            // 
            this.cbNomeJogador.FormattingEnabled = true;
            this.cbNomeJogador.Location = new System.Drawing.Point(110, 6);
            this.cbNomeJogador.Name = "cbNomeJogador";
            this.cbNomeJogador.Size = new System.Drawing.Size(121, 21);
            this.cbNomeJogador.TabIndex = 16;
            this.cbNomeJogador.SelectedIndexChanged += new System.EventHandler(this.cbNomeJogador_SelectedIndexChanged);
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbNomeJogador);
            this.Controls.Add(this.cmdIniciarJogo);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblQuem);
            this.Name = "Jogo";
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.Jogo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdIniciarJogo;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdResponder;
        private System.Windows.Forms.Button cmdFimdeJogo;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label lblQuem;
        private System.Windows.Forms.ComboBox cbNomeJogador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}