using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Teste_Sockets
{
    public partial class Chat_Simplefied : Form
    {
        TcpClient cliente;
        StreamReader reader;
        StreamWriter writer;
        string msg_receber;
        string msg_enviar;

        public Chat_Simplefied()
        {
            InitializeComponent();
        }

        private void btn_começar_Click(object sender, EventArgs e)
        {
            if( txt_meuNome.Text != "")
            {
                if (txt_meuNome.Text == "Juciano Silva")
                {
                    MessageBox.Show("Chat criado, clique em OK para esperar utilizadores.");
                    Iniciar();
                    telas.SelectedTab = tela2;
                }
                else
                {
                    try
                    {
                        Conectar();
                        telas.SelectedTab = tela2;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao conectar-se à um Chat, certifique-se que o Chat está ligado");
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira seu nome, para ingressar no chat...");
            }

            this.Text = "Real Time CHAT - " + txt_meuNome.Text;
        }

        private void Iniciar()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 80);
            listener.Start();
            cliente = listener.AcceptTcpClient();
            reader = new StreamReader(cliente.GetStream());
            writer = new StreamWriter(cliente.GetStream());
            writer.AutoFlush = true;
            bw1.RunWorkerAsync();
            bw2.WorkerSupportsCancellation = true;
        }

        private void Conectar()
        {
            cliente = new TcpClient();
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
            cliente.Connect(iPEnd);

            try
            {
                txtlog.AppendText($"Você entrou no Chat{Environment.NewLine}");
                writer = new StreamWriter(cliente.GetStream());
                reader = new StreamReader(cliente.GetStream());
                writer.AutoFlush = true;
                bw1.RunWorkerAsync();
                bw2.WorkerSupportsCancellation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bw1_DoWork(object sender, DoWorkEventArgs e)
        {
            while( cliente.Connected)
            {
                try
                {
                    msg_receber = reader.ReadLine();
                    this.txtlog.Invoke(new MethodInvoker(delegate ()
                   {
                       txtlog.AppendText($"{msg_receber}{Environment.NewLine}");
                       msg_receber = "";
                   }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bw2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (cliente.Connected)
            {
                writer.WriteLine(msg_enviar);
                this.txtlog.Invoke(new MethodInvoker(delegate ()
              {
                  txtlog.AppendText($"{msg_enviar}{Environment.NewLine}");
              }));
            }
            else
            {
                MessageBox.Show("Falha ao enviar...");
            }
            bw2.CancelAsync();
        }

        private void txt_mensagem_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            
                if (txt_mensagem.Text != "")
                {
                    msg_enviar = txt_meuNome.Text + ": " + txt_mensagem.Text;
                    bw2.RunWorkerAsync();
                }
                txt_mensagem.Text = "";
        }

        private void txt_meuNome_TextChanged(object sender, EventArgs e)
        {
            if( txt_meuNome.Text == "Juciano Silva")
            {
                btn_começar.Text = "Criar Sala";
            }
            else
            {
                btn_começar.Text = "Entra em um Chat";
            }
        }
    }
}
