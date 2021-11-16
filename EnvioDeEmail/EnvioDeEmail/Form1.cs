using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace EnvioDeEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAnexo.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress(txtEmail.Text);
                mensagem.To.Add(txtDestino.Text);
                mensagem.Body = txtCorpo.Text;
                mensagem.Subject = txtAssunto.Text;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;

                if (txtAnexo.Text != "")
                {
                    mensagem.Attachments.Add(new Attachment(txtAnexo.Text));
                }
                client.Credentials = new System.Net.NetworkCredential(txtEmail.Text, txtSenha.Text);
                client.Send(mensagem);
                mensagem = null;
                MessageBox.Show("Mensagem enviada!");
            }
            catch (Exception)
            {

                 MessageBox.Show("Erro ao mandar mensagem!");
            }
        }
    }
}
