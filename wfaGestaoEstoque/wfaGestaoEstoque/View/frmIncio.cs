using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaGestaoEstoque.View;

namespace wfaGestaoEstoque
{
    public partial class frmIncio : Form
    {
        public frmIncio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cadCons = new frmCadConsum();
            cadCons.Closed += (s, args) => this.Close();
            cadCons.Show();
        }

        private void frmIncio_Load(object sender, EventArgs e)
        {
            lblData.Text = "Olá, seja bem vindo! Hoje é " + DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
            Color mycolor = Color.FromArgb(100, Color.DarkGray);
            lblFundoMenu.BackColor = mycolor;
            lblSelecione.BackColor = mycolor;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inventario = new frmInventario();
            inventario.Closed += (s, args) => this.Close();
            inventario.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            var compras = new frmCompras();
            compras.Closed += (s, args) => this.Close();
            compras.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new frmLogin();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}
