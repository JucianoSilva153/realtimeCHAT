using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Teste_Sockets
{
    public partial class Chat : Form
    {
        //teste
        int testeVez = 1;

        //Oficial
        TcpClient Cliente;
        StreamReader Reader;
        StreamWriter writer;
        string msgReceber;
        string msgEnviar;
        int MSG_LocAtual = 0;
        string IPLocal;
        string EnderecoIP;

        string nomeUsuario;
        bool Servidor;
        
        Label msgbox2 = new Label();
        Label msgbox = new Label();

        public Chat( string nome,  bool servidor)
        {
            nomeUsuario = nome;
            Servidor = servidor;

            InitializeComponent();
            IPAddress[] iPAddresses = Dns.GetHostAddresses(Dns.GetHostName());
            foreach( IPAddress endereco in iPAddresses)
            {
                if( endereco.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPLocal = endereco.ToString();
                }
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {

            if( Servidor)
            {
                IniciarServidor(IPAddress.Any, 80);
            }
            else
            {
                ConectarAoServidor();
            }


        }


        private void IniciarServidor(IPAddress IP, int Porta)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 80);
            listener.Start();
            Cliente = listener.AcceptTcpClient();
            MessageBox.Show("Chat operacional");
            Reader = new StreamReader(Cliente.GetStream());
            writer = new StreamWriter(Cliente.GetStream());
            writer.AutoFlush = true;
            BW1.RunWorkerAsync();
            BW2.WorkerSupportsCancellation = true;
        }

        private void ConectarAoServidor()
        {
            TcpClient cliente = new TcpClient();
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse(IPLocal), 80);
            cliente.Connect(iPEnd);

            try
            {
                MessageBox.Show("Sala Encontrada, Chat operacional!");
                writer = new StreamWriter(cliente.GetStream());
                Reader = new StreamReader(cliente.GetStream());
                writer.AutoFlush = true;
                BW1.RunWorkerAsync();
                BW2.WorkerReportsProgress = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void gunaTileButton1_Click(object sender, EventArgs e)
        {
            //if( testeVez == 1)
            //{
            //    MSGBOX_Servidor(6, 66, txtMensagem.Text);
            //    testeVez = 2;
            //} else if ( testeVez == 2 )
            //{
            //    MSGBOX_Cliente(115, 66, txtMensagem.Text);
            //    testeVez = 1;
            //}

            if( txtMensagem.Text != "")
            {
                msgEnviar = txtMensagem.Text;
                BW2.RunWorkerAsync();
            }
            txtMensagem.Text = "";

        }

        private void MSGBOX_Servidor(int Lx, int Ly, string mensagem)
        {

            msgbox.AutoSize = true;
            msgbox.BackColor = System.Drawing.Color.DarkSlateBlue;
            msgbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            msgbox.ForeColor = System.Drawing.Color.White;
            msgbox.Location = new System.Drawing.Point(Lx, Ly + MSG_LocAtual);
            msgbox.MaximumSize = new System.Drawing.Size(220, 200);
            msgbox.MinimumSize = new System.Drawing.Size(220, 35);
            msgbox.Name = "msgbox";
            msgbox.Padding = new System.Windows.Forms.Padding(10);
            msgbox.Size = new System.Drawing.Size(220, 35);
            msgbox.TabIndex = 3;
            msgbox.Text = mensagem;

            
            MSG_LocAtual += 46;
        }

        private void MSGBOX_Cliente(int Lx, int Ly, string mensagem)
        {

            msgbox2.AutoSize = true;
            msgbox2.BackColor = System.Drawing.Color.DarkSlateBlue;
            msgbox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            msgbox2.ForeColor = System.Drawing.Color.White;
            msgbox2.Location = new System.Drawing.Point(Lx, Ly + MSG_LocAtual);
            msgbox2.Size = new System.Drawing.Size(220, 35);
            msgbox2.MaximumSize = new System.Drawing.Size(220, 200);
            msgbox2.MinimumSize = new System.Drawing.Size(220, 35);
            msgbox2.Name = "msgbox2";
            msgbox2.Padding = new System.Windows.Forms.Padding(10);
            msgbox2.TabIndex = 3;
            msgbox2.RightToLeft = RightToLeft;
            msgbox2.Text = mensagem;

            
            MSG_LocAtual += 46;
        }

        private void BW1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (Cliente.Connected)
            {
                try
                {
                    msgReceber = Reader.ReadLine();
                    MSGBOX_Cliente(115, 66, msgReceber);
                    Controls.Add(msgbox2);
                    msgReceber = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
        }

        private void BW2_DoWork(object sender, DoWorkEventArgs e)
        {
            if( Cliente.Connected)
            {
                writer.WriteLine(msgEnviar);
                MSGBOX_Servidor(6, 66, msgEnviar);
                Controls.Add(msgbox);
            }
            else
            {
                MessageBox.Show("Falha ao enviar mensagem");
            }
            BW2.CancelAsync();
        }
    }
}
