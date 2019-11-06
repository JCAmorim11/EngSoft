using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDeNegocios;

namespace GestaoEstoque
{
    public partial class frmCadColab : Form
    {
        public frmCadColab()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string name, CPF, usuario, senha;
            string nivel;
            name = txtNome.Text;
            CPF = mskCPF.Text;
            usuario = txtLogin.Text;
            senha = txtSenha.Text;
            if (rdbAdm.Checked == true)
                nivel = "0";
            else
                nivel = "1";
            
            Login NovoUsuario = new Login();
            if (NovoUsuario.cadastraUsuario(name, CPF, usuario, senha, nivel))
                MessageBox.Show("Cadastro realizado!");
            else
                MessageBox.Show("puts amigah");            
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inicio = new frmIncio();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar) && e.KeyChar != (Char)8) && e.KeyChar != (Char)32)            
                e.KeyChar = (Char)0;
        }

        private void TxtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar)) && e.KeyChar != (Char)8)
                e.KeyChar = (Char)0;
        }
    }
}
