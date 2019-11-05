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

            /*CamadaDeNegocios.Validacao validaCampo = new Validacao();
            /if (!validaCampo.ValidaTexto(txtNome.Text.ToString()) ||
                !validaCampo.ValidaCPF(txtCPF.Text.ToString()) ||
                txtRG.Text.Length != 12 || txtTelefone.Text.Length != 15)
            {
                MessageBox.Show("Por favor Verifique os campos:\nNome,\nRG,\nCPF," +
                    "\nTelefone.\n" +
                    "Note: Todos os campos devem estar preenchidos.\nO campo nome aceita apenas letras.\n" +
                    "CPF Inserido deve ser válido.\n" +
                    "RG Inserido deve ter todos os números.\n" +
                    "O Telefone deve ser válido.", "Campo(s) Inválido(s)!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                name = txtNome.Text.ToString();
                RG = txtRG.Text.ToString();
                CPF = txtCPF.Text.ToString();
                telefone = txtTelefone.Text.ToString();
                usuario = txtUsuario.Text.ToString();
                senha = txtSenha.Text.ToString();
                if (txtConfirmaSenha.Text.ToString().Equals(txtSenha.Text.ToString()))
                {
                    LoginUser NovoUsuario = new LoginUser();
                    if (NovoUsuario.cadastraUsuario(name, RG, CPF, telefone, usuario, senha))
                    {
                        MessageBox.Show("Usuario cadastrado com sucesso", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Clear();
                        txtRG.Clear();
                        txtCPF.Clear();
                        txtTelefone.Clear();
                        txtUsuario.Clear();
                        txtSenha.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Usuario já existe", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtUsuario.Clear();
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não coincidem", "Senhas não conferem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Focus();
                }


            }*/
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
