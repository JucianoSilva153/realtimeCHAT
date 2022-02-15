
namespace Teste_Sockets
{
    partial class Chat
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
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_EnviarMensagem = new Guna.UI.WinForms.GunaTileButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.msg_servidor = new Guna.UI.WinForms.GunaLabel();
            this.msgCliente = new Guna.UI.WinForms.GunaLabel();
            this.txtMensagem = new Guna.UI.WinForms.GunaTextBox();
            this.BW1 = new System.ComponentModel.BackgroundWorker();
            this.BW2 = new System.ComponentModel.BackgroundWorker();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SuspendLayout();
            // 
            // btn_EnviarMensagem
            // 
            this.btn_EnviarMensagem.AnimationHoverSpeed = 0.07F;
            this.btn_EnviarMensagem.AnimationSpeed = 0.03F;
            this.btn_EnviarMensagem.BackColor = System.Drawing.Color.Transparent;
            this.btn_EnviarMensagem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_EnviarMensagem.BorderColor = System.Drawing.Color.Black;
            this.btn_EnviarMensagem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_EnviarMensagem.FocusedColor = System.Drawing.Color.Empty;
            this.btn_EnviarMensagem.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btn_EnviarMensagem.ForeColor = System.Drawing.Color.White;
            this.btn_EnviarMensagem.Image = null;
            this.btn_EnviarMensagem.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_EnviarMensagem.Location = new System.Drawing.Point(291, 461);
            this.btn_EnviarMensagem.Name = "btn_EnviarMensagem";
            this.btn_EnviarMensagem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_EnviarMensagem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_EnviarMensagem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_EnviarMensagem.OnHoverImage = null;
            this.btn_EnviarMensagem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_EnviarMensagem.Radius = 20;
            this.btn_EnviarMensagem.Size = new System.Drawing.Size(40, 40);
            this.btn_EnviarMensagem.TabIndex = 1;
            this.btn_EnviarMensagem.Text = "gunaTileButton1";
            this.btn_EnviarMensagem.Click += new System.EventHandler(this.gunaTileButton1_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(343, 45);
            this.gunaPanel1.TabIndex = 2;
            // 
            // msg_servidor
            // 
            this.msg_servidor.AutoSize = true;
            this.msg_servidor.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.msg_servidor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.msg_servidor.ForeColor = System.Drawing.Color.White;
            this.msg_servidor.Location = new System.Drawing.Point(6, 66);
            this.msg_servidor.MaximumSize = new System.Drawing.Size(250, 200);
            this.msg_servidor.Name = "msg_servidor";
            this.msg_servidor.Padding = new System.Windows.Forms.Padding(10);
            this.msg_servidor.Size = new System.Drawing.Size(216, 35);
            this.msg_servidor.TabIndex = 3;
            this.msg_servidor.Text = "Olá, está é uma caixa de mensagem";
            this.msg_servidor.Visible = false;
            // 
            // msgCliente
            // 
            this.msgCliente.AutoSize = true;
            this.msgCliente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.msgCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.msgCliente.ForeColor = System.Drawing.Color.White;
            this.msgCliente.Location = new System.Drawing.Point(115, 112);
            this.msgCliente.MaximumSize = new System.Drawing.Size(250, 200);
            this.msgCliente.MinimumSize = new System.Drawing.Size(220, 0);
            this.msgCliente.Name = "msgCliente";
            this.msgCliente.Padding = new System.Windows.Forms.Padding(10);
            this.msgCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msgCliente.Size = new System.Drawing.Size(220, 35);
            this.msgCliente.TabIndex = 4;
            this.msgCliente.Text = "Olá, esta é outra caixa de mensagem";
            this.msgCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.msgCliente.Visible = false;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.Transparent;
            this.txtMensagem.BaseColor = System.Drawing.Color.White;
            this.txtMensagem.BorderColor = System.Drawing.Color.Silver;
            this.txtMensagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMensagem.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMensagem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMensagem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMensagem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMensagem.Location = new System.Drawing.Point(12, 461);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.PasswordChar = '\0';
            this.txtMensagem.Radius = 15;
            this.txtMensagem.SelectedText = "";
            this.txtMensagem.Size = new System.Drawing.Size(276, 40);
            this.txtMensagem.TabIndex = 5;
            // 
            // BW1
            // 
            this.BW1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW1_DoWork);
            // 
            // BW2
            // 
            this.BW2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW2_DoWork);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPanel1;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(343, 513);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.msgCliente);
            this.Controls.Add(this.msg_servidor);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.btn_EnviarMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTileButton btn_EnviarMensagem;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel CaixaMensagem;
        private Guna.UI.WinForms.GunaLabel msg_servidor;
        private Guna.UI.WinForms.GunaLabel msgCliente;
        private Guna.UI.WinForms.GunaTextBox txtMensagem;
        private System.ComponentModel.BackgroundWorker BW1;
        private System.ComponentModel.BackgroundWorker BW2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}