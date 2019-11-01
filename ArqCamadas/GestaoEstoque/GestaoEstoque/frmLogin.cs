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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Color mycolor = Color.FromArgb(100, Color.DarkGray);
            lblFundo.BackColor = mycolor;
            pbLogo.BackColor = mycolor;
        }

        private void lblFundo_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "admin" && txtSenha.Text == "admin")
            {
                Program.globalString = txtNome.Text;
                this.Hide();
                var inicio = new frmIncio();
                inicio.Closed += (s, args) => this.Close();
                inicio.Show();
            }
            else
            {
                lblErro.Visible = true;
                txtNome.Text = "";
                txtSenha.Text = "";
                txtNome.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                btnEntrar.PerformClick();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
                Environment.Exit(0);
        }
    }
}
