using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaGestaoEstoque.Controller
{
    class Produto
    {
        #region ATRIBUTOS
        public string PROnome { get; private set; }
        public double PROvalor { get; private set; }
        public string PROtipo { get; private set; }
        public string PROfornecedor { get; private set; }
        public string PROlote { get; private set; }
        #endregion

        #region CONSTRUTORES
        public Produto()
        {
            this.PROnome = "";
            this.PROvalor = 0.00;
            this.PROtipo = "";
            this.PROfornecedor =  "";
            this.PROlote = "";
        }
        public Produto(string nome, double valor, string tipo, string forn, string lote)
        {
            this.PROnome = nome;
            this.PROvalor = valor;
            this.PROtipo = tipo;
            this.PROfornecedor = forn;
            this.PROlote = lote;

        }
        #endregion

        #region MÉTODOS
        #endregion
    }
}
