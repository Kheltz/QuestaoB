namespace Mecanica
{
    partial class FormularioCadastroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCadastroClientes));
            this.topImagem = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.butVoltarReg = new System.Windows.Forms.Button();
            this.butSalvarReg = new System.Windows.Forms.Button();
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
            this.topImagem.TabIndex = 15;
            this.topImagem.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(65, 197);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(305, 37);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Registro de Cliente";
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cboSexo.Location = new System.Drawing.Point(154, 289);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(89, 21);
            this.cboSexo.TabIndex = 22;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(154, 263);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(198, 20);
            this.txtDataNascimento.TabIndex = 21;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(104, 292);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(51, 18);
            this.lblSexo.TabIndex = 20;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 265);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(143, 18);
            this.lblDataNascimento.TabIndex = 19;
            this.lblDataNascimento.Text = "Data Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Location = new System.Drawing.Point(154, 237);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(198, 20);
            this.txtNome.TabIndex = 18;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNome.Location = new System.Drawing.Point(97, 239);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 18);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "Nome:";
            // 
            // butVoltarReg
            // 
            this.butVoltarReg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVoltarReg.Location = new System.Drawing.Point(66, 405);
            this.butVoltarReg.Name = "butVoltarReg";
            this.butVoltarReg.Size = new System.Drawing.Size(144, 39);
            this.butVoltarReg.TabIndex = 24;
            this.butVoltarReg.Text = "Voltar";
            this.butVoltarReg.UseVisualStyleBackColor = true;
            this.butVoltarReg.Click += new System.EventHandler(this.butVoltarReg_Click_1);
            // 
            // butSalvarReg
            // 
            this.butSalvarReg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalvarReg.Location = new System.Drawing.Point(227, 405);
            this.butSalvarReg.Name = "butSalvarReg";
            this.butSalvarReg.Size = new System.Drawing.Size(144, 39);
            this.butSalvarReg.TabIndex = 23;
            this.butSalvarReg.Text = "Salvar";
            this.butSalvarReg.UseVisualStyleBackColor = true;
            this.butSalvarReg.Click += new System.EventHandler(this.butSalvarReg_Click_1);
            // 
            // FormularioCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 469);
            this.Controls.Add(this.butVoltarReg);
            this.Controls.Add(this.butSalvarReg);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.topImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormularioCadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioCadastroCliente";
            ((System.ComponentModel.ISupportInitialize)(this.topImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox topImagem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button butVoltarReg;
        private System.Windows.Forms.Button butSalvarReg;
    }
}