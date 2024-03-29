﻿using System;
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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }
        Produto consulta = new Produto();
        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inicio = new frmIncio();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'padokaBDDataSetInventario.Produto'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtoTableAdapter.Fill(this.padokaBDDataSetInventario.Produto);
            Color mycolor = Color.FromArgb(100, Color.DarkGray);
            lblFundo.BackColor = mycolor;

            DataSet oDx = new DataSet();
            oDx = consulta.selecionaProd();
            dataGridView1.DataSource = oDx.Tables[0];
        }
    }
}
