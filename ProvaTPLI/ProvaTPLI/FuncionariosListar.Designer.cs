namespace ProvaTPLI
{
    partial class FuncionariosListar
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
            this.Quantidade = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.Funcionarios = new System.Windows.Forms.Label();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UfColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(21, 325);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(62, 13);
            this.Quantidade.TabIndex = 0;
            this.Quantidade.Text = "Quantidade";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NomeColumn,
            this.UfColumn,
            this.CidadeColumn,
            this.EnderecoColumn,
            this.NumeroColumn,
            this.CPFColumn});
            this.dataGridView1.Location = new System.Drawing.Point(24, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(749, 256);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(24, 12);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(455, 320);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 3;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(536, 320);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(75, 23);
            this.Alterar.TabIndex = 4;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(617, 320);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(75, 23);
            this.Novo.TabIndex = 5;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(698, 320);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(75, 23);
            this.Fechar.TabIndex = 6;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Funcionarios
            // 
            this.Funcionarios.AutoSize = true;
            this.Funcionarios.Location = new System.Drawing.Point(21, 42);
            this.Funcionarios.Name = "Funcionarios";
            this.Funcionarios.Size = new System.Drawing.Size(67, 13);
            this.Funcionarios.TabIndex = 7;
            this.Funcionarios.Text = "Funcionarios";
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "ID";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // NomeColumn
            // 
            this.NomeColumn.DataPropertyName = "Nome";
            this.NomeColumn.HeaderText = "Nome";
            this.NomeColumn.Name = "NomeColumn";
            this.NomeColumn.ReadOnly = true;
            // 
            // UfColumn
            // 
            this.UfColumn.DataPropertyName = "Uf";
            this.UfColumn.HeaderText = "UF";
            this.UfColumn.Name = "UfColumn";
            this.UfColumn.ReadOnly = true;
            // 
            // CidadeColumn
            // 
            this.CidadeColumn.DataPropertyName = "Cidade";
            this.CidadeColumn.HeaderText = "Cidade";
            this.CidadeColumn.Name = "CidadeColumn";
            this.CidadeColumn.ReadOnly = true;
            // 
            // EnderecoColumn
            // 
            this.EnderecoColumn.DataPropertyName = "Endereco";
            this.EnderecoColumn.HeaderText = "Endereco";
            this.EnderecoColumn.Name = "EnderecoColumn";
            this.EnderecoColumn.ReadOnly = true;
            // 
            // NumeroColumn
            // 
            this.NumeroColumn.DataPropertyName = "Numero";
            this.NumeroColumn.HeaderText = "Numero";
            this.NumeroColumn.Name = "NumeroColumn";
            this.NumeroColumn.ReadOnly = true;
            // 
            // CPFColumn
            // 
            this.CPFColumn.DataPropertyName = "CPF";
            this.CPFColumn.HeaderText = "CPF";
            this.CPFColumn.Name = "CPFColumn";
            this.CPFColumn.ReadOnly = true;
            // 
            // FuncionariosListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Funcionarios);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Quantidade);
            this.Name = "FuncionariosListar";
            this.Text = "LISTAGEM DE FUNCIONARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Label Funcionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UfColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFColumn;
    }
}

