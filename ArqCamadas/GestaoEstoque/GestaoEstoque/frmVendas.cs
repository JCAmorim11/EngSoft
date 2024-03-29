﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Data.OleDb;

using CamadaDeDados;
using CamadaDeNegocio;
using System.Windows.Forms;

namespace GestaoEstoque
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
            
        }
        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inicio = new frmIncio();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }

        private void frmVendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
                Environment.Exit(0);
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'padokaBDDataSet.Consumo_Prod'. Você pode movê-la ou removê-la conforme necessário.
            this.consumo_ProdTableAdapter.Fill(this.padokaBDDataSet.Consumo_Prod);

        }
       
    }
}
