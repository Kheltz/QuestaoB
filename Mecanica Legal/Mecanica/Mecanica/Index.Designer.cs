namespace Mecanica
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.topImagem = new System.Windows.Forms.PictureBox();
            this.butCadCarro = new System.Windows.Forms.Button();
            this.butCadMoto = new System.Windows.Forms.Button();
            this.butCadCliente = new System.Windows.Forms.Button();
            this.butSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.topImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // topImagem
            // 
            this.topImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topImagem.Image = ((System.Drawing.Image)(resources.GetObject("topImagem.Image")));
            this.topImagem.InitialImage = null;
            this.topImagem.Location = new System.Drawing.Point(0, 0);
            this.topImagem.Name = "topImagem";
            this.topImagem.Size = new System.Drawing.Size(433, 160);
            this.topImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topImagem.TabIndex = 12;
            this.topImagem.TabStop = false;
            // 
            // butCadCarro
            // 
            this.butCadCarro.Location = new System.Drawing.Point(12, 271);
            this.butCadCarro.Name = "butCadCarro";
            this.butCadCarro.Size = new System.Drawing.Size(200, 70);
            this.butCadCarro.TabIndex = 13;
            this.butCadCarro.Text = "Cadastrar Automóvel";
            this.butCadCarro.UseVisualStyleBackColor = true;
            this.butCadCarro.Click += new System.EventHandler(this.butCadCarro_Click);
            // 
            // butCadMoto
            // 
            this.butCadMoto.Location = new System.Drawing.Point(222, 271);
            this.butCadMoto.Name = "butCadMoto";
            this.butCadMoto.Size = new System.Drawing.Size(200, 70);
            this.butCadMoto.TabIndex = 14;
            this.butCadMoto.Text = "Cadastrar Motocicleta";
            this.butCadMoto.UseVisualStyleBackColor = true;
            this.butCadMoto.Click += new System.EventHandler(this.butCadMoto_Click);
            // 
            // butCadCliente
            // 
            this.butCadCliente.Location = new System.Drawing.Point(12, 195);
            this.butCadCliente.Name = "butCadCliente";
            this.butCadCliente.Size = new System.Drawing.Size(410, 70);
            this.butCadCliente.TabIndex = 15;
            this.butCadCliente.Text = "Cadastrar Cliente";
            this.butCadCliente.UseVisualStyleBackColor = true;
            this.butCadCliente.Click += new System.EventHandler(this.butCadCliente_Click);
            // 
            // butSair
            // 
            this.butSair.Location = new System.Drawing.Point(83, 420);
            this.butSair.Name = "butSair";
            this.butSair.Size = new System.Drawing.Size(270, 36);
            this.butSair.TabIndex = 16;
            this.butSair.Text = "Sair";
            this.butSair.UseVisualStyleBackColor = true;
            this.butSair.Click += new System.EventHandler(this.butSair_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 469);
            this.Controls.Add(this.butSair);
            this.Controls.Add(this.butCadCliente);
            this.Controls.Add(this.butCadMoto);
            this.Controls.Add(this.butCadCarro);
            this.Controls.Add(this.topImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mecânica Veículo Legal - Sistem v0.1";
            ((System.ComponentModel.ISupportInitialize)(this.topImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox topImagem;
        private System.Windows.Forms.Button butCadCarro;
        private System.Windows.Forms.Button butCadMoto;
        private System.Windows.Forms.Button butCadCliente;
        private System.Windows.Forms.Button butSair;
    }
}