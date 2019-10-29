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
    public partial class frmCadConsum : Form
    {
        public frmCadConsum()
        {
            InitializeComponent();
        }
        Controller.Consumidor FCCconsumidor = new Controller.Consumidor(); //FCC = frmCadConsum

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (FCCconsumidor.CONvalidanome(txtNome.Text) == 0) //validação do campo txtNome
            {
                MessageBox.Show("Nome inválido!");
                txtNome.Focus();
            }
            else
            {
                if (FCCconsumidor.CONvalidacpf(mskCPF.Text) == 0) //validação do campo mskCPF
                {
                    MessageBox.Show("CPF inválido!");
                    mskCPF.Focus();
                }
                else //caso todos os campos estejam preenchidos corretamente
                {
                    FCCconsumidor.CONsetnome(txtNome.Text);
                    FCCconsumidor.CONsetcpf(mskCPF.Text);

                    label4.Text = FCCconsumidor.CONnome;
                    label5.Text = FCCconsumidor.CONcpf;
                }
            }
        }
                
        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e) //verificação letra por letra do campo nome
        {
            if (FCCconsumidor.CONvalidaletranome(e.KeyChar) == 0)
            {                
                e.KeyChar = (Char)0;
            }
        }
    }
}
