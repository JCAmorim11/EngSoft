using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaGestaoEstoque.View
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
                Form inicio = new frmIncio();
                inicio.Show();
            }
            else
            {
                lblErro.Visible = true;
            }
        }
    }
}
