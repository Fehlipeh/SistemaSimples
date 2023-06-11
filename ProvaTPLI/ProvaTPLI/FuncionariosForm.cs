using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProvaTPLI
{
    public partial class FuncionariosForm : Form
    {
        public FuncionariosForm()
        {
            InitializeComponent();
            Text = "Novo Funcionario";
            IDBox1.Text = "Automático";
            NOMEBox2.Focus();
        }
        public FuncionariosForm(int id)
        {
            InitializeComponent();
            var funcionario = new FuncionariosDAO().Buscar(id);
            Text = "Alteração de Funcionario";
            IDBox1.Text = funcionario.Rows[0]["ID"].ToString();
            NOMEBox2.Text = funcionario.Rows[0]["Nome"].ToString();
            NOMEBox2.Focus();
            ESTADOBox3.Text = funcionario.Rows[0]["UF"].ToString();
            CIDADEBox4.Text = funcionario.Rows[0]["CIDADE"].ToString();
            ENDERECOBox5.Text = funcionario.Rows[0]["Endereco"].ToString();
            NUMEROBox6.Text = funcionario.Rows[0]["Numero"].ToString();
            CPFBox7.Text = funcionario.Rows[0]["CPF"].ToString();
        }
        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (Text == "Novo funcionario")
            {
                //faz a inclusão
                new FuncionariosDAO().Adicionar(NOMEBox2.Text, ESTADOBox3.Text, CIDADEBox4.Text, ENDERECOBox5.Text, NUMEROBox6.Text, CPFBox7.Text);
                MessageBox.Show("Funcionario alterado com sucesso!", ProductName,
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                //faz a alteração
                new FuncionariosDAO().Atualizar(Convert.ToInt32(IDBox1.Text), NOMEBox2.Text, CIDADEBox4.Text, ENDERECOBox5.Text, NUMEROBox6.Text, CPFBox7.Text,
               ESTADOBox3.Text);
                MessageBox.Show("Funcionario alterado com sucesso!", ProductName,
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private void FuncionariosForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (Text == "Novo funcionario")
            {
                //faz a inclusão
                new FuncionariosDAO().Adicionar(NOMEBox2.Text, ESTADOBox3.Text, CIDADEBox4.Text, ENDERECOBox5.Text, NUMEROBox6.Text, CPFBox7.Text);
                MessageBox.Show("Funcionario alterado com sucesso!", ProductName,
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                //faz a alteração
                new FuncionariosDAO().Atualizar(Convert.ToInt32(IDBox1.Text), NOMEBox2.Text, CIDADEBox4.Text, ENDERECOBox5.Text, NUMEROBox6.Text, CPFBox7.Text,
               ESTADOBox3.Text);
                MessageBox.Show("Funcionario alterado com sucesso!", ProductName,
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
