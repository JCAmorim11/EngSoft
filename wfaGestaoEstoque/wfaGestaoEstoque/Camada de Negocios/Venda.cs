using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaGestaoEstoque.Controller
{
    class Venda
    {
        #region ATRIBUTOS
        public string VENid { get; private set; }
        public int[] VENdata { get; private set; }
        public double VENvalor { get; private set; }

        #endregion ATRIBUTOS

        #region CONSTRUTORES
        public Venda()
        {
            this.VENid = "";
            this.VENvalor = 0.00;
        }
        public Venda(string id, double preco)
        {
            VENid = id;
            VENvalor = preco;
        }
        #endregion CONSTRUTORES

        #region MÉTODOS
        public int VENokok(int hue)
        {
            return hue;
        }
        #endregion MÉTODOS
    }
}
