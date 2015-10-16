namespace VideoAlstom
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btAssistir = new System.Windows.Forms.Button();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.LbTerceiro = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAssistir
            // 
            this.btAssistir.BackColor = System.Drawing.Color.SteelBlue;
            this.btAssistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAssistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAssistir.Location = new System.Drawing.Point(314, 238);
            this.btAssistir.Name = "btAssistir";
            this.btAssistir.Size = new System.Drawing.Size(200, 75);
            this.btAssistir.TabIndex = 2;
            this.btAssistir.Text = "Assistir";
            this.btAssistir.UseVisualStyleBackColor = false;
            this.btAssistir.Click += new System.EventHandler(this.btAssistir_Click);
            // 
            // tbMatricula
            // 
            this.tbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatricula.Location = new System.Drawing.Point(165, 165);
            this.tbMatricula.MaxLength = 100;
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(500, 44);
            this.tbMatricula.TabIndex = 1;
            this.tbMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatricula_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALPS (Número do Crachá)";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 23);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(810, 83);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Se você é terceiro clique";
            // 
            // LbTerceiro
            // 
            this.LbTerceiro.AutoSize = true;
            this.LbTerceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTerceiro.LinkColor = System.Drawing.Color.Blue;
            this.LbTerceiro.Location = new System.Drawing.Point(506, 382);
            this.LbTerceiro.Name = "LbTerceiro";
            this.LbTerceiro.Size = new System.Drawing.Size(154, 55);
            this.LbTerceiro.TabIndex = 5;
            this.LbTerceiro.TabStop = true;
            this.LbTerceiro.Text = "AQUI!";
            this.LbTerceiro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbTerceiro_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(117, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(610, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Acompanhe o vídeo até o final e aguarde a impressão do comprovante.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(834, 546);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbTerceiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.btAssistir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAssistir;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LbTerceiro;
        private System.Windows.Forms.Label label3;
    }
}