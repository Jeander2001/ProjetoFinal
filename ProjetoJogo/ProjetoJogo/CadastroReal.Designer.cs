namespace ProjetoJogo
{
    partial class CadastroReal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroReal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.cmdCadastroReal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nickname :";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(307, 136);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(162, 20);
            this.txtNick.TabIndex = 1;
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Location = new System.Drawing.Point(307, 190);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(75, 23);
            this.cmdConfirmar.TabIndex = 2;
            this.cmdConfirmar.Text = "Confirmar ?";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(713, 292);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(75, 23);
            this.cmdSair.TabIndex = 3;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdCadastroReal
            // 
            this.cmdCadastroReal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCadastroReal.BackgroundImage")));
            this.cmdCadastroReal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCadastroReal.Location = new System.Drawing.Point(-1, 304);
            this.cmdCadastroReal.Margin = new System.Windows.Forms.Padding(0);
            this.cmdCadastroReal.Name = "cmdCadastroReal";
            this.cmdCadastroReal.Size = new System.Drawing.Size(106, 23);
            this.cmdCadastroReal.TabIndex = 4;
            this.cmdCadastroReal.Text = "Let`s ... Play?";
            this.cmdCadastroReal.UseVisualStyleBackColor = true;
            this.cmdCadastroReal.Click += new System.EventHandler(this.cmdCadastroReal_Click);
            // 
            // CadastroReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 327);
            this.Controls.Add(this.cmdCadastroReal);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdConfirmar);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.label1);
            this.Name = "CadastroReal";
            this.Text = "CadastroReal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.Button cmdCadastroReal;
    }
}