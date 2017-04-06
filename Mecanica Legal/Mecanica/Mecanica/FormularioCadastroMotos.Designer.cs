namespace Mecanica
{
    partial class FormularioCadastroMotos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCadastroMotos));
            this.topImagem = new System.Windows.Forms.PictureBox();
            this.butVoltarReg = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.butSalvarReg = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.cboCorMoto = new System.Windows.Forms.ComboBox();
            this.formularioCadastroMotosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.topImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularioCadastroMotosBindingSource)).BeginInit();
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
            this.topImagem.TabIndex = 15;
            this.topImagem.TabStop = false;
            // 
            // butVoltarReg
            // 
            this.butVoltarReg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVoltarReg.Location = new System.Drawing.Point(66, 405);
            this.butVoltarReg.Name = "butVoltarReg";
            this.butVoltarReg.Size = new System.Drawing.Size(144, 39);
            this.butVoltarReg.TabIndex = 26;
            this.butVoltarReg.Text = "Voltar";
            this.butVoltarReg.UseVisualStyleBackColor = true;
            this.butVoltarReg.Click += new System.EventHandler(this.butVoltarReg_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(40, 197);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(372, 37);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Registro de Motocicleta";
            // 
            // butSalvarReg
            // 
            this.butSalvarReg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalvarReg.Location = new System.Drawing.Point(227, 405);
            this.butSalvarReg.Name = "butSalvarReg";
            this.butSalvarReg.Size = new System.Drawing.Size(144, 39);
            this.butSalvarReg.TabIndex = 24;
            this.butSalvarReg.Text = "Salvar";
            this.butSalvarReg.UseVisualStyleBackColor = true;
            this.butSalvarReg.Click += new System.EventHandler(this.butSalvarReg_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(147, 298);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(78, 20);
            this.txtAno.TabIndex = 22;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(147, 272);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(198, 20);
            this.txtModelo.TabIndex = 21;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(72, 327);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(41, 18);
            this.lblCor.TabIndex = 20;
            this.lblCor.Text = "Cor:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(72, 300);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(42, 18);
            this.lblAno.TabIndex = 19;
            this.lblAno.Text = "Ano:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(72, 274);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(69, 18);
            this.lblModelo.TabIndex = 18;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtMarca
            // 
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.Location = new System.Drawing.Point(147, 246);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(198, 20);
            this.txtMarca.TabIndex = 17;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMarca.Location = new System.Drawing.Point(72, 248);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(60, 18);
            this.lblMarca.TabIndex = 16;
            this.lblMarca.Text = "Marca:";
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(157, 351);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(68, 20);
            this.txtCilindrada.TabIndex = 28;
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCilindrada.Location = new System.Drawing.Point(72, 353);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(88, 18);
            this.lblCilindrada.TabIndex = 27;
            this.lblCilindrada.Text = "Cilindrada:";
            // 
            // cboCorMoto
            // 
            this.cboCorMoto.FormattingEnabled = true;
            this.cboCorMoto.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Vermelho",
            "Azul",
            "Verde",
            "Amarelo",
            "Personalizado"});
            this.cboCorMoto.Location = new System.Drawing.Point(147, 324);
            this.cboCorMoto.Name = "cboCorMoto";
            this.cboCorMoto.Size = new System.Drawing.Size(78, 21);
            this.cboCorMoto.TabIndex = 29;
            this.cboCorMoto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // formularioCadastroMotosBindingSource
            // 
            this.formularioCadastroMotosBindingSource.DataSource = typeof(Mecanica.FormularioCadastroMotos);
            // 
            // FormularioCadastroMotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 469);
            this.Controls.Add(this.cboCorMoto);
            this.Controls.Add(this.txtCilindrada);
            this.Controls.Add(this.lblCilindrada);
            this.Controls.Add(this.butVoltarReg);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.butSalvarReg);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.topImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormularioCadastroMotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioCadastroMotos";
            ((System.ComponentModel.ISupportInitialize)(this.topImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularioCadastroMotosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox topImagem;
        private System.Windows.Forms.Button butVoltarReg;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button butSalvarReg;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.Label lblCilindrada;
        private System.Windows.Forms.ComboBox cboCorMoto;
        private System.Windows.Forms.BindingSource formularioCadastroMotosBindingSource;
    }
}