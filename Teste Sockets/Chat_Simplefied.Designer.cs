
namespace Teste_Sockets
{
    partial class Chat_Simplefied
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat_Simplefied));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tela2 = new System.Windows.Forms.TabPage();
            this.tela1 = new System.Windows.Forms.TabPage();
            this.telas = new Bunifu.UI.WinForms.BunifuPages();
            this.btn_começar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txt_meuNome = new Guna.UI.WinForms.GunaTextBox();
            this.txt_mensagem = new Guna.UI.WinForms.GunaTextBox();
            this.bw1 = new System.ComponentModel.BackgroundWorker();
            this.bw2 = new System.ComponentModel.BackgroundWorker();
            this.btn_enviar = new Guna.UI.WinForms.GunaButton();
            this.txtlog = new Guna.UI.WinForms.GunaTextBox();
            this.tela2.SuspendLayout();
            this.tela1.SuspendLayout();
            this.telas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tela2
            // 
            this.tela2.BackColor = System.Drawing.Color.White;
            this.tela2.Controls.Add(this.txtlog);
            this.tela2.Controls.Add(this.btn_enviar);
            this.tela2.Controls.Add(this.txt_mensagem);
            this.tela2.Location = new System.Drawing.Point(4, 4);
            this.tela2.Name = "tela2";
            this.tela2.Padding = new System.Windows.Forms.Padding(3);
            this.tela2.Size = new System.Drawing.Size(516, 465);
            this.tela2.TabIndex = 1;
            this.tela2.Text = "tabPage2";
            // 
            // tela1
            // 
            this.tela1.BackColor = System.Drawing.Color.White;
            this.tela1.Controls.Add(this.txt_meuNome);
            this.tela1.Controls.Add(this.btn_começar);
            this.tela1.Location = new System.Drawing.Point(4, 4);
            this.tela1.Name = "tela1";
            this.tela1.Padding = new System.Windows.Forms.Padding(3);
            this.tela1.Size = new System.Drawing.Size(516, 465);
            this.tela1.TabIndex = 0;
            this.tela1.Text = "tabPage1";
            // 
            // telas
            // 
            this.telas.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.telas.AllowTransitions = true;
            this.telas.Controls.Add(this.tela1);
            this.telas.Controls.Add(this.tela2);
            this.telas.Location = new System.Drawing.Point(-2, 0);
            this.telas.Name = "telas";
            this.telas.Page = this.tela2;
            this.telas.PageIndex = 1;
            this.telas.PageName = "tela2";
            this.telas.PageTitle = "tabPage2";
            this.telas.SelectedIndex = 0;
            this.telas.Size = new System.Drawing.Size(524, 491);
            this.telas.TabIndex = 0;
            this.telas.TabStop = false;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.telas.Transition = animation1;
            this.telas.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Transparent;
            // 
            // btn_começar
            // 
            this.btn_começar.AllowAnimations = true;
            this.btn_começar.AllowMouseEffects = true;
            this.btn_começar.AllowToggling = false;
            this.btn_começar.AnimationSpeed = 200;
            this.btn_começar.AutoGenerateColors = false;
            this.btn_começar.AutoRoundBorders = false;
            this.btn_começar.AutoSizeLeftIcon = true;
            this.btn_começar.AutoSizeRightIcon = true;
            this.btn_começar.BackColor = System.Drawing.Color.Transparent;
            this.btn_começar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_começar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_começar.BackgroundImage")));
            this.btn_começar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_começar.ButtonText = "Entra em um Chat";
            this.btn_começar.ButtonTextMarginLeft = 0;
            this.btn_começar.ColorContrastOnClick = 45;
            this.btn_começar.ColorContrastOnHover = 45;
            this.btn_começar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_começar.CustomizableEdges = borderEdges1;
            this.btn_começar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_começar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_começar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_começar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_começar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_começar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_começar.ForeColor = System.Drawing.Color.White;
            this.btn_começar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_começar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_começar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_começar.IconMarginLeft = 11;
            this.btn_começar.IconPadding = 10;
            this.btn_começar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_começar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_começar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_começar.IconSize = 25;
            this.btn_começar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_começar.IdleBorderRadius = 20;
            this.btn_começar.IdleBorderThickness = 1;
            this.btn_começar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_começar.IdleIconLeftImage = null;
            this.btn_começar.IdleIconRightImage = null;
            this.btn_começar.IndicateFocus = false;
            this.btn_começar.Location = new System.Drawing.Point(183, 239);
            this.btn_começar.Name = "btn_começar";
            this.btn_começar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_começar.OnDisabledState.BorderRadius = 20;
            this.btn_começar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_começar.OnDisabledState.BorderThickness = 1;
            this.btn_começar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_começar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_começar.OnDisabledState.IconLeftImage = null;
            this.btn_começar.OnDisabledState.IconRightImage = null;
            this.btn_começar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_começar.onHoverState.BorderRadius = 20;
            this.btn_começar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_começar.onHoverState.BorderThickness = 1;
            this.btn_começar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_começar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_começar.onHoverState.IconLeftImage = null;
            this.btn_começar.onHoverState.IconRightImage = null;
            this.btn_começar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_começar.OnIdleState.BorderRadius = 20;
            this.btn_começar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_começar.OnIdleState.BorderThickness = 1;
            this.btn_começar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_começar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_começar.OnIdleState.IconLeftImage = null;
            this.btn_começar.OnIdleState.IconRightImage = null;
            this.btn_começar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_começar.OnPressedState.BorderRadius = 20;
            this.btn_começar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_começar.OnPressedState.BorderThickness = 1;
            this.btn_começar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_começar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_começar.OnPressedState.IconLeftImage = null;
            this.btn_começar.OnPressedState.IconRightImage = null;
            this.btn_começar.Size = new System.Drawing.Size(150, 39);
            this.btn_começar.TabIndex = 0;
            this.btn_começar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_começar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_começar.TextMarginLeft = 0;
            this.btn_começar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_começar.UseDefaultRadiusAndThickness = true;
            this.btn_começar.Click += new System.EventHandler(this.btn_começar_Click);
            // 
            // txt_meuNome
            // 
            this.txt_meuNome.BaseColor = System.Drawing.Color.White;
            this.txt_meuNome.BorderColor = System.Drawing.Color.Silver;
            this.txt_meuNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_meuNome.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_meuNome.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_meuNome.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_meuNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_meuNome.Location = new System.Drawing.Point(126, 183);
            this.txt_meuNome.Name = "txt_meuNome";
            this.txt_meuNome.PasswordChar = '\0';
            this.txt_meuNome.Radius = 10;
            this.txt_meuNome.SelectedText = "";
            this.txt_meuNome.Size = new System.Drawing.Size(262, 46);
            this.txt_meuNome.TabIndex = 1;
            this.txt_meuNome.TextChanged += new System.EventHandler(this.txt_meuNome_TextChanged);
            // 
            // txt_mensagem
            // 
            this.txt_mensagem.BaseColor = System.Drawing.Color.White;
            this.txt_mensagem.BorderColor = System.Drawing.Color.Silver;
            this.txt_mensagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mensagem.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_mensagem.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_mensagem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_mensagem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_mensagem.Location = new System.Drawing.Point(8, 419);
            this.txt_mensagem.Name = "txt_mensagem";
            this.txt_mensagem.PasswordChar = '\0';
            this.txt_mensagem.SelectedText = "";
            this.txt_mensagem.Size = new System.Drawing.Size(450, 40);
            this.txt_mensagem.TabIndex = 0;
            this.txt_mensagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mensagem_KeyDown);
            // 
            // bw1
            // 
            this.bw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw1_DoWork);
            // 
            // bw2
            // 
            this.bw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw2_DoWork);
            // 
            // btn_enviar
            // 
            this.btn_enviar.AnimationHoverSpeed = 0.07F;
            this.btn_enviar.AnimationSpeed = 0.03F;
            this.btn_enviar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_enviar.BorderColor = System.Drawing.Color.Black;
            this.btn_enviar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_enviar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_enviar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_enviar.ForeColor = System.Drawing.Color.White;
            this.btn_enviar.Image = null;
            this.btn_enviar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_enviar.Location = new System.Drawing.Point(464, 419);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_enviar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_enviar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_enviar.OnHoverImage = null;
            this.btn_enviar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_enviar.Size = new System.Drawing.Size(44, 42);
            this.btn_enviar.TabIndex = 4;
            this.btn_enviar.Text = ">>";
            this.btn_enviar.TextOffsetX = 6;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // txtlog
            // 
            this.txtlog.BaseColor = System.Drawing.Color.White;
            this.txtlog.BorderColor = System.Drawing.Color.White;
            this.txtlog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlog.Enabled = false;
            this.txtlog.FocusedBaseColor = System.Drawing.Color.White;
            this.txtlog.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtlog.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtlog.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtlog.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtlog.Location = new System.Drawing.Point(0, 0);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.PasswordChar = '\0';
            this.txtlog.ReadOnly = true;
            this.txtlog.SelectedText = "";
            this.txtlog.Size = new System.Drawing.Size(516, 413);
            this.txtlog.TabIndex = 5;
            // 
            // Chat_Simplefied
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 491);
            this.Controls.Add(this.telas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Chat_Simplefied";
            this.Text = "Real Time CHAT - Início";
            this.tela2.ResumeLayout(false);
            this.tela1.ResumeLayout(false);
            this.telas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tela2;
        private System.Windows.Forms.TabPage tela1;
        private Bunifu.UI.WinForms.BunifuPages telas;
        private Guna.UI.WinForms.GunaTextBox txt_meuNome;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_começar;
        private Guna.UI.WinForms.GunaTextBox txt_mensagem;
        private System.ComponentModel.BackgroundWorker bw1;
        private System.ComponentModel.BackgroundWorker bw2;
        private Guna.UI.WinForms.GunaButton btn_enviar;
        private Guna.UI.WinForms.GunaTextBox txtlog;
    }
}