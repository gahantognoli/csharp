using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomExceptions
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Autenticacao.Autenticar(txtUsuario.Text, txtSenha.Text);
                MessageBox.Show("OK!");
            }
            catch (UsuarioInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(SenhaInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
