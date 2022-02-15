
namespace Teste_Sockets
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
            this.txtIPServidor = new Guna.UI.WinForms.GunaTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServidorPorta = new Guna.UI.WinForms.GunaTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConetar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientePorta = new Guna.UI.WinForms.GunaTextBox();
            this.txtClienteIP = new Guna.UI.WinForms.GunaTextBox();
            this.txtMensagem = new Guna.UI.WinForms.GunaTextBox();
            this.btnEnviarMsg = new System.Windows.Forms.Button();
            this.bw1 = new System.ComponentModel.BackgroundWorker();
            this.bw2 = new System.ComponentModel.BackgroundWorker();
            this.txtLog = new Guna.UI.WinForms.GunaTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIPServidor
            // 
            this.txtIPServidor.BaseColor = System.Drawing.Color.White;
            this.txtIPServidor.BorderColor = System.Drawing.Color.Silver;
            this.txtIPServidor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIPServidor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIPServidor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIPServidor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIPServidor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIPServidor.Location = new System.Drawing.Point(15, 46);
            this.txtIPServidor.Name = "txtIPServidor";
            this.txtIPServidor.PasswordChar = '\0';
            this.txtIPServidor.SelectedText = "";
            this.txtIPServidor.Size = new System.Drawing.Size(240, 30);
            this.txtIPServidor.TabIndex = 0;
            this.txtIPServidor.TextChanged += new System.EventHandler(this.txtIPServidor_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 139);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnIniciar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtServidorPorta);
            this.tabPage1.Controls.Add(this.txtIPServidor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 113);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Servidor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(361, 6);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 30);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Porta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // txtServidorPorta
            // 
            this.txtServidorPorta.BaseColor = System.Drawing.Color.White;
            this.txtServidorPorta.BorderColor = System.Drawing.Color.Silver;
            this.txtServidorPorta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServidorPorta.FocusedBaseColor = System.Drawing.Color.White;
            this.txtServidorPorta.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtServidorPorta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtServidorPorta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServidorPorta.Location = new System.Drawing.Point(270, 46);
            this.txtServidorPorta.Name = "txtServidorPorta";
            this.txtServidorPorta.PasswordChar = '\0';
            this.txtServidorPorta.SelectedText = "";
            this.txtServidorPorta.Size = new System.Drawing.Size(75, 30);
            this.txtServidorPorta.TabIndex = 0;
            this.txtServidorPorta.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConetar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtClientePorta);
            this.tabPage2.Controls.Add(this.txtClienteIP);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 113);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConetar
            // 
            this.btnConetar.Location = new System.Drawing.Point(357, 47);
            this.btnConetar.Name = "btnConetar";
            this.btnConetar.Size = new System.Drawing.Size(75, 30);
            this.btnConetar.TabIndex = 7;
            this.btnConetar.Text = "Conectar";
            this.btnConetar.UseVisualStyleBackColor = true;
            this.btnConetar.Click += new System.EventHandler(this.btnConetar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IP";
            // 
            // txtClientePorta
            // 
            this.txtClientePorta.BaseColor = System.Drawing.Color.White;
            this.txtClientePorta.BorderColor = System.Drawing.Color.Silver;
            this.txtClientePorta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientePorta.FocusedBaseColor = System.Drawing.Color.White;
            this.txtClientePorta.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtClientePorta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtClientePorta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClientePorta.Location = new System.Drawing.Point(269, 47);
            this.txtClientePorta.Name = "txtClientePorta";
            this.txtClientePorta.PasswordChar = '\0';
            this.txtClientePorta.SelectedText = "";
            this.txtClientePorta.Size = new System.Drawing.Size(75, 30);
            this.txtClientePorta.TabIndex = 3;
            // 
            // txtClienteIP
            // 
            this.txtClienteIP.BaseColor = System.Drawing.Color.White;
            this.txtClienteIP.BorderColor = System.Drawing.Color.Silver;
            this.txtClienteIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteIP.FocusedBaseColor = System.Drawing.Color.White;
            this.txtClienteIP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtClienteIP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtClienteIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClienteIP.Location = new System.Drawing.Point(14, 47);
            this.txtClienteIP.Name = "txtClienteIP";
            this.txtClienteIP.PasswordChar = '\0';
            this.txtClienteIP.SelectedText = "";
            this.txtClienteIP.Size = new System.Drawing.Size(240, 30);
            this.txtClienteIP.TabIndex = 4;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BaseColor = System.Drawing.Color.White;
            this.txtMensagem.BorderColor = System.Drawing.Color.Silver;
            this.txtMensagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMensagem.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMensagem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMensagem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMensagem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMensagem.Location = new System.Drawing.Point(16, 436);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.PasswordChar = '\0';
            this.txtMensagem.SelectedText = "";
            this.txtMensagem.Size = new System.Drawing.Size(369, 30);
            this.txtMensagem.TabIndex = 3;
            // 
            // btnEnviarMsg
            // 
            this.btnEnviarMsg.Location = new System.Drawing.Point(391, 436);
            this.btnEnviarMsg.Name = "btnEnviarMsg";
            this.btnEnviarMsg.Size = new System.Drawing.Size(75, 30);
            this.btnEnviarMsg.TabIndex = 4;
            this.btnEnviarMsg.Text = "Iniciar";
            this.btnEnviarMsg.UseVisualStyleBackColor = true;
            this.btnEnviarMsg.Click += new System.EventHandler(this.btnEnviarMsg_Click);
            // 
            // bw1
            // 
            this.bw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_servidor_DoWork);
            // 
            // bw2
            // 
            this.bw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_cliente_DoWork);
            // 
            // txtLog
            // 
            this.txtLog.BaseColor = System.Drawing.Color.White;
            this.txtLog.BorderColor = System.Drawing.Color.Silver;
            this.txtLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLog.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLog.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLog.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLog.Location = new System.Drawing.Point(16, 154);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.PasswordChar = '\0';
            this.txtLog.SelectedText = "";
            this.txtLog.Size = new System.Drawing.Size(442, 276);
            this.txtLog.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 478);
            this.Controls.Add(this.btnEnviarMsg);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtIPServidor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtServidorPorta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnConetar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtClientePorta;
        private Guna.UI.WinForms.GunaTextBox txtClienteIP;
        private Guna.UI.WinForms.GunaTextBox txtMensagem;
        private System.Windows.Forms.Button btnEnviarMsg;
        private System.ComponentModel.BackgroundWorker bw1;
        private System.ComponentModel.BackgroundWorker bw2;
        private Guna.UI.WinForms.GunaTextBox txtLog;
    }
}

