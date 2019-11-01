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
        public string PROnome { get; protected set; }
        public double PROvalor { get; protected set; }
        public string PROtipo { get; set; }
        public string PROfornecedor { get; set; }
        #endregion ATRIBUTOS

        #region CONSTRUTOR
        public Produto(){
            this.PROnome = "";
            this.PROvalor=0.00;
            this.PROtipo = "";
            this.PROfornecedor = "";
        }
        public Produto(string nome,double preco, string tipo, string forn)
        {
            this.PROnome = nome;
            this.PROvalor = preco;
            this.PROtipo = tipo;
            this.PROfornecedor = forn;
        }
        #endregion CONSTRUTOR

        #region MÉTODOS
        public bool PROinserirPreco()
        {
            return true;
        }
        #endregion MÉTODOS
    }
}
