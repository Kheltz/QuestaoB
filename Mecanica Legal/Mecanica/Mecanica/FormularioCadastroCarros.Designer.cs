namespace Mecanica
{
    partial class FormularioCadastroCarros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCadastroCarros));
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.cboCorCarro = new System.Windows.Forms.ComboBox();
            this.butSalvarReg = new System.Windows.Forms.Button();
            this.lblPortas = new System.Windows.Forms.Label();
            this.txtPortas = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.butVoltarReg = new System.Windows.Forms.Button();
            this.topImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.topImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMarca.Location = new System.Drawing.Point(72, 248);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(60, 18);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.Location = new System.Drawing.Point(147, 246);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(198, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(72, 274);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(69, 18);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(72, 300);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(42, 18);
            this.lblAno.TabIndex = 3;
            this.lblAno.Text = "Ano:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(72, 327);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(41, 18);
            this.lblCor.TabIndex = 4;
            this.lblCor.Text = "Cor:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(147, 272);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(198, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(147, 298);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(78, 20);
            this.txtAno.TabIndex = 6;
            // 
            // cboCorCarro
            // 
            this.cboCorCarro.FormattingEnabled = true;
            this.cboCorCarro.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Vermelho",
            "Azul",
            "Verde",
            "Amarelo",
            "Personalizado"});
            this.cboCorCarro.Location = new System.Drawing.Point(147, 324);
            this.cboCorCarro.Name = "cboCorCarro";
            this.cboCorCarro.Size = new System.Drawing.Size(78, 21);
            this.cboCorCarro.TabIndex = 7;
            // 
            // butSalvarReg
            // 
            this.butSalvarReg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalvarReg.Location = new System.Drawing.Point(227, 405);
            this.butSalvarReg.Name = "butSalvarReg";
            this.butSalvarReg.Size = new System.Drawing.Size(144, 39);
            this.butSalvarReg.TabIndex = 8;
            this.butSalvarReg.Text = "Salvar";
            this.butSalvarReg.UseVisualStyleBackColor = true;
            this.butSalvarReg.Click += new System.EventHandler(this.butSalvarReg_Click);
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortas.Location = new System.Drawing.Point(72, 353);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(63, 18);
            this.lblPortas.TabIndex = 9;
            this.lblPortas.Text = "Portas:";
            // 
            // txtPortas
            // 
            this.txtPortas.Location = new System.Drawing.Point(147, 351);
            this.txtPortas.Name = "txtPortas";
            this.txtPortas.Size = new System.Drawing.Size(78, 20);
            this.txtPortas.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(40, 197);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 37);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Registro de Automóvel";
            // 
            // butVoltarReg
            // 
            this.butVoltarReg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVoltarReg.Location = new System.Drawing.Point(66, 405);
            this.butVoltarReg.Name = "butVoltarReg";
            this.butVoltarReg.Size = new System.Drawing.Size(144, 39);
            this.butVoltarReg.TabIndex = 13;
            this.butVoltarReg.Text = "Voltar";
            this.butVoltarReg.UseVisualStyleBackColor = true;
            this.butVoltarReg.Click += new System.EventHandler(this.butVoltarReg_Click);
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
            this.topImagem.TabIndex = 14;
            this.topImagem.TabStop = false;
            // 
            // FormularioCadastroCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 469);
            this.Controls.Add(this.topImagem);
            this.Controls.Add(this.butVoltarReg);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtPortas);
            this.Controls.Add(this.lblPortas);
            this.Controls.Add(this.butSalvarReg);
            this.Controls.Add(this.cboCorCarro);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormularioCadastroCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículos";
            this.Load += new System.EventHandler(this.FormularioCadastroCarros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox cboCorCarro;
        private System.Windows.Forms.Button butSalvarReg;
        private System.Windows.Forms.Label lblPortas;
        private System.Windows.Forms.TextBox txtPortas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button butVoltarReg;
        private System.Windows.Forms.PictureBox topImagem;
    }
}

