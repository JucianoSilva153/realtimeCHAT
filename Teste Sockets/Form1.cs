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
    public partial class Form1 : Form
    {
        public TcpClient cliente;
        public StreamReader leitor;
        public StreamWriter escritor;
        public string msgReceber;
        public string msgEnviar;
        public Form1()
        {
            InitializeComponent();


            IPAddress[] IPLocal = Dns.GetHostAddresses(Dns.GetHostName());

            foreach( IPAddress endereco in IPLocal)
            {
                if(endereco.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtIPServidor.Text = endereco.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private  void btnIniciar_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txtServidorPorta.Text));
            listener.Start();
            cliente = listener.AcceptTcpClient();
            leitor = new StreamReader(cliente.GetStream());
            escritor = new StreamWriter(cliente.GetStream());
            escritor.AutoFlush = true;
            bw1.RunWorkerAsync();
            bw2.WorkerSupportsCancellation = true;
        }

        private void btnConetar_Click(object sender, EventArgs e)
        {
            cliente = new TcpClient();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(txtClienteIP.Text), int.Parse(txtClientePorta.Text));
            cliente.Connect(iPEndPoint);

            try
            {
                txtLog.AppendText("Conectar ao Servidor" + "\n");
                escritor = new StreamWriter(cliente.GetStream());
                leitor = new StreamReader(cliente.GetStream());
                escritor.AutoFlush = true;
                bw1.RunWorkerAsync();
                bw2.WorkerSupportsCancellation = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bw_servidor_DoWork(object sender, DoWorkEventArgs e)
        {
            while (cliente.Connected)
            {
                try
                {
                    msgReceber = leitor.ReadLine();
                    this.txtLog.Invoke(new MethodInvoker(delegate ()
                   {
                       txtLog.AppendText("Você: " + msgReceber + "\n");
                       msgReceber = "";
                   }));
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bw_cliente_DoWork(object sender, DoWorkEventArgs e)
        {
            if (cliente.Connected)
            {
                escritor.WriteLine(msgEnviar);
                this.txtLog.Invoke(new MethodInvoker(delegate ()
               {
                   txtLog.AppendText("Eu: " + msgEnviar + "\n");
               }));
            }
            else
            {
                MessageBox.Show("Falha ao enviar a mensagem!");
            }
            bw2.CancelAsync();
        }

        private void btnEnviarMsg_Click(object sender, EventArgs e)
        {
            if( txtMensagem.Text != "")
            {
                msgEnviar = txtMensagem.Text;
                bw2.RunWorkerAsync();
            }
            txtMensagem.Text = "";
        }

        private void txtIPServidor_TextChanged(object sender, EventArgs e)
        {
            if( txtIPServidor.Text.Contains("Juciano"))
            {

            }
        }


    }
}
