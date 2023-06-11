using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaTPLI
{
    public partial class FuncionariosListar : Form
    {
        public FuncionariosListar()
        {
            InitializeComponent();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            //executa o método e coloca os dados na variável
            var dados = new FuncionariosDAO().ListarTodas();
            //conta os registros e coloca no label
            Quantidade.Text = $"Registros encontrados: {dados.Rows.Count}";
            //joga os dados no grid
            dataGridView1.DataSource = dados;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Alterar_Click(object sender, EventArgs e)
        {
           
                //pega o id da linha selecionada no grid
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idColumn"].Value);
                //abre a tela passando a cidade selecionada
                new FuncionariosForm(id).ShowDialog();
                //executa a busca novamente, como se tivesse clicado no botão
                Buscar.PerformClick();
            
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Confirma a exclusão do Funcionario?", ProductName,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //pega o id da linha selecionada no grid
                    int id =
                   Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idColumn"].Value);
                    //executa a exclusão
                    new FuncionariosDAO().Excluir(id);
                    //executa a busca novamente, como se tivesse clicado no botão
                    Buscar.PerformClick();
                    //avisa o usuário
                    MessageBox.Show("Funcionarios excluído com sucesso!", ProductName,
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Novo_Click(object sender, EventArgs e)
        {
           
                //pega o id da linha selecionada no grid
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idColumn"].Value);
                //abre a tela para um novo cadastro
                new FuncionariosForm().ShowDialog();
                //executa a busca novamente, como se tivesse clicado no botão
                Buscar.PerformClick();
         
        }
    }
}
