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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void fECHARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fUNCIONARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FuncionariosListar FuncionariosListar = new FuncionariosListar();
            FuncionariosListar.Show();

        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuário desabilitado!", ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void fUNCIONARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FuncionariosListar FuncionariosListar = new FuncionariosListar();
            FuncionariosListar.Show();
        }
    }
}
