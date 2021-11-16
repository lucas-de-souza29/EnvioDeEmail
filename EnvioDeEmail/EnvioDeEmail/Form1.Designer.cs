namespace EnvioDeEmail
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.txtCorpo = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnexo = new System.Windows.Forms.Label();
            this.lblCorpo = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 20);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(21, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "De";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(383, 20);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(427, 20);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(298, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(61, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(61, 65);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(664, 20);
            this.txtDestino.TabIndex = 4;
            // 
            // txtAnexo
            // 
            this.txtAnexo.Enabled = false;
            this.txtAnexo.Location = new System.Drawing.Point(69, 125);
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.Size = new System.Drawing.Size(656, 20);
            this.txtAnexo.TabIndex = 5;
            // 
            // txtCorpo
            // 
            this.txtCorpo.Location = new System.Drawing.Point(125, 259);
            this.txtCorpo.Multiline = true;
            this.txtCorpo.Name = "txtCorpo";
            this.txtCorpo.Size = new System.Drawing.Size(600, 123);
            this.txtCorpo.TabIndex = 6;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(77, 190);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(648, 20);
            this.txtAssunto.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Para";
            // 
            // lblAnexo
            // 
            this.lblAnexo.AutoSize = true;
            this.lblAnexo.Location = new System.Drawing.Point(26, 125);
            this.lblAnexo.Name = "lblAnexo";
            this.lblAnexo.Size = new System.Drawing.Size(37, 13);
            this.lblAnexo.TabIndex = 9;
            this.lblAnexo.Text = "Anexo";
            // 
            // lblCorpo
            // 
            this.lblCorpo.AutoSize = true;
            this.lblCorpo.Location = new System.Drawing.Point(26, 262);
            this.lblCorpo.Name = "lblCorpo";
            this.lblCorpo.Size = new System.Drawing.Size(93, 13);
            this.lblCorpo.TabIndex = 10;
            this.lblCorpo.Text = "Corpo(Mensagem)";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(26, 190);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(45, 13);
            this.lblAssunto.TabIndex = 11;
            this.lblAssunto.Text = "Assunto";
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(726, 403);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(96, 33);
            this.btnEnviarEmail.TabIndex = 12;
            this.btnEnviarEmail.Text = "Enviar Email";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(743, 117);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(79, 35);
            this.btnProcurar.TabIndex = 13;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 448);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.lblCorpo);
            this.Controls.Add(this.lblAnexo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtCorpo);
            this.Controls.Add(this.txtAnexo);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Name = "Form1";
            this.Text = "Envio de Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtAnexo;
        private System.Windows.Forms.TextBox txtCorpo;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnexo;
        private System.Windows.Forms.Label lblCorpo;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

