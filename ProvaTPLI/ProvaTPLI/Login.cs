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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ENTRARbutton1_Click(object sender, EventArgs e)
        {
            Global.UsuarioLogado = new UsuariosDAO().Login(usuariotext.Text, senhatext.Text);
            //não encontrou
            if (Global.UsuarioLogado == null)
            {
                MessageBox.Show("Usuário e senha não encontrado!", ProductName,
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                senhatext.Clear();
                usuariotext.Focus();
            }
            else
            {
                //encontrou e testamos se está ativo
                if (Global.UsuarioLogado.Ativo == false)
                {
                    MessageBox.Show("Usuário desabilitado!", ProductName,
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    senhatext.Clear();
                    usuariotext.Focus();
                }
                
 else
                {
                    //está tudo certo, fechamos a tela
                    this.Hide();
                    MENU MENU = new MENU();
                    MENU.Show();

                }
            }
        }
    }
}
