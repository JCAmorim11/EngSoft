﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaGestaoEstoque.View;

namespace wfaGestaoEstoque.View
{
    public partial class frmCadastros : Form
    {
        public frmCadastros()
        {
            InitializeComponent();
        }

        private void btnConsumidores_Click(object sender, EventArgs e)
        {
            this.Hide();
            var consum = new frmCadConsum();
            consum.Closed += (s, args) => this.Close();
            consum.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            var forn = new frmCadForn();
            forn.Closed += (s, args) => this.Close();
            forn.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            var prod = new frmCadProd();
            prod.Closed += (s, args) => this.Close();
            prod.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new frmIncio();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
