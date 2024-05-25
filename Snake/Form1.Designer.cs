namespace Snake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PnTela = new Panel();
            LbPontuacao = new Label();
            menuStrip1 = new MenuStrip();
            Menu = new ToolStripMenuItem();
            iniciarJogoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            Frame = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PnTela
            // 
            PnTela.BorderStyle = BorderStyle.Fixed3D;
            PnTela.Location = new Point(7, 62);
            PnTela.Name = "PnTela";
            PnTela.Size = new Size(428, 428);
            PnTela.TabIndex = 0;
            // 
            // LbPontuacao
            // 
            LbPontuacao.BackColor = SystemColors.ActiveCaptionText;
            LbPontuacao.BorderStyle = BorderStyle.Fixed3D;
            LbPontuacao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPontuacao.ForeColor = SystemColors.ButtonFace;
            LbPontuacao.Location = new Point(7, 24);
            LbPontuacao.Name = "LbPontuacao";
            LbPontuacao.Size = new Size(428, 38);
            LbPontuacao.TabIndex = 1;
            LbPontuacao.Text = "PONTOS: 0";
            LbPontuacao.TextAlign = ContentAlignment.MiddleRight;
            LbPontuacao.Click += LbPontuacao_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaptionText;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(441, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            Menu.BackColor = Color.Black;
            Menu.DropDownItems.AddRange(new ToolStripItem[] { iniciarJogoToolStripMenuItem, sairToolStripMenuItem });
            Menu.ForeColor = SystemColors.ButtonFace;
            Menu.Name = "Menu";
            Menu.Size = new Size(50, 20);
            Menu.Text = "Menu";
            Menu.Click += Menu_Click;
            // 
            // iniciarJogoToolStripMenuItem
            // 
            iniciarJogoToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            iniciarJogoToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            iniciarJogoToolStripMenuItem.Name = "iniciarJogoToolStripMenuItem";
            iniciarJogoToolStripMenuItem.Size = new Size(133, 22);
            iniciarJogoToolStripMenuItem.Text = "Iniciar jogo";
            iniciarJogoToolStripMenuItem.Click += iniciarJogoToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            sairToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(133, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Frame
            // 
            Frame.Tick += Frame_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(441, 498);
            Controls.Add(LbPontuacao);
            Controls.Add(PnTela);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake II";
            Load += Form1_Load;
            KeyDown += Clicado;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnTela;
        private Label LbPontuacao;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menu;
        private ToolStripMenuItem iniciarJogoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer Frame;
    }
}
