namespace ProvaTPLI
{
    partial class FuncionariosForm
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
            this.Salvar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.IDBox1 = new System.Windows.Forms.TextBox();
            this.NOMEBox2 = new System.Windows.Forms.TextBox();
            this.ESTADOBox3 = new System.Windows.Forms.TextBox();
            this.CIDADEBox4 = new System.Windows.Forms.TextBox();
            this.ENDERECOBox5 = new System.Windows.Forms.TextBox();
            this.NUMEROBox6 = new System.Windows.Forms.TextBox();
            this.CPFBox7 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.ENDERECO = new System.Windows.Forms.Label();
            this.CIDADE = new System.Windows.Forms.Label();
            this.ESTADO = new System.Windows.Forms.Label();
            this.NUMERO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(580, 301);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 0;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(661, 301);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(75, 23);
            this.Fechar.TabIndex = 1;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // IDBox1
            // 
            this.IDBox1.Location = new System.Drawing.Point(30, 49);
            this.IDBox1.Name = "IDBox1";
            this.IDBox1.Size = new System.Drawing.Size(100, 20);
            this.IDBox1.TabIndex = 2;
            // 
            // NOMEBox2
            // 
            this.NOMEBox2.Location = new System.Drawing.Point(30, 88);
            this.NOMEBox2.Name = "NOMEBox2";
            this.NOMEBox2.Size = new System.Drawing.Size(476, 20);
            this.NOMEBox2.TabIndex = 3;
            // 
            // ESTADOBox3
            // 
            this.ESTADOBox3.Location = new System.Drawing.Point(316, 165);
            this.ESTADOBox3.Name = "ESTADOBox3";
            this.ESTADOBox3.Size = new System.Drawing.Size(175, 20);
            this.ESTADOBox3.TabIndex = 4;
            // 
            // CIDADEBox4
            // 
            this.CIDADEBox4.Location = new System.Drawing.Point(30, 165);
            this.CIDADEBox4.Name = "CIDADEBox4";
            this.CIDADEBox4.Size = new System.Drawing.Size(262, 20);
            this.CIDADEBox4.TabIndex = 5;
            // 
            // ENDERECOBox5
            // 
            this.ENDERECOBox5.Location = new System.Drawing.Point(30, 127);
            this.ENDERECOBox5.Name = "ENDERECOBox5";
            this.ENDERECOBox5.Size = new System.Drawing.Size(685, 20);
            this.ENDERECOBox5.TabIndex = 6;
            // 
            // NUMEROBox6
            // 
            this.NUMEROBox6.Location = new System.Drawing.Point(515, 165);
            this.NUMEROBox6.Name = "NUMEROBox6";
            this.NUMEROBox6.Size = new System.Drawing.Size(200, 20);
            this.NUMEROBox6.TabIndex = 7;
            // 
            // CPFBox7
            // 
            this.CPFBox7.Location = new System.Drawing.Point(537, 88);
            this.CPFBox7.Name = "CPFBox7";
            this.CPFBox7.Size = new System.Drawing.Size(178, 20);
            this.CPFBox7.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(27, 33);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 9;
            this.ID.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(27, 72);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(39, 13);
            this.Nome.TabIndex = 10;
            this.Nome.Text = "NOME";
            this.Nome.Click += new System.EventHandler(this.label2_Click);
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(534, 72);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(27, 13);
            this.CPF.TabIndex = 11;
            this.CPF.Text = "CPF";
            // 
            // ENDERECO
            // 
            this.ENDERECO.AutoSize = true;
            this.ENDERECO.Location = new System.Drawing.Point(27, 111);
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.Size = new System.Drawing.Size(67, 13);
            this.ENDERECO.TabIndex = 12;
            this.ENDERECO.Text = "ENDERECO";
            // 
            // CIDADE
            // 
            this.CIDADE.AutoSize = true;
            this.CIDADE.Location = new System.Drawing.Point(27, 149);
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.Size = new System.Drawing.Size(47, 13);
            this.CIDADE.TabIndex = 13;
            this.CIDADE.Text = "CIDADE";
            // 
            // ESTADO
            // 
            this.ESTADO.AutoSize = true;
            this.ESTADO.Location = new System.Drawing.Point(313, 150);
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Size = new System.Drawing.Size(51, 13);
            this.ESTADO.TabIndex = 14;
            this.ESTADO.Text = "ESTADO";
            // 
            // NUMERO
            // 
            this.NUMERO.AutoSize = true;
            this.NUMERO.Location = new System.Drawing.Point(512, 150);
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.Size = new System.Drawing.Size(55, 13);
            this.NUMERO.TabIndex = 15;
            this.NUMERO.Text = "NUMERO";
            // 
            // FuncionariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NUMERO);
            this.Controls.Add(this.ESTADO);
            this.Controls.Add(this.CIDADE);
            this.Controls.Add(this.ENDERECO);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.CPFBox7);
            this.Controls.Add(this.NUMEROBox6);
            this.Controls.Add(this.ENDERECOBox5);
            this.Controls.Add(this.CIDADEBox4);
            this.Controls.Add(this.ESTADOBox3);
            this.Controls.Add(this.NOMEBox2);
            this.Controls.Add(this.IDBox1);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Salvar);
            this.Name = "FuncionariosForm";
            this.Text = "FuncionariosForm";
            this.Load += new System.EventHandler(this.FuncionariosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.TextBox IDBox1;
        private System.Windows.Forms.TextBox NOMEBox2;
        private System.Windows.Forms.TextBox ESTADOBox3;
        private System.Windows.Forms.TextBox CIDADEBox4;
        private System.Windows.Forms.TextBox ENDERECOBox5;
        private System.Windows.Forms.TextBox NUMEROBox6;
        private System.Windows.Forms.TextBox CPFBox7;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label ENDERECO;
        private System.Windows.Forms.Label CIDADE;
        private System.Windows.Forms.Label ESTADO;
        private System.Windows.Forms.Label NUMERO;
    }
}