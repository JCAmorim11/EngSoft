using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaGestaoEstoque.Controller
{
    class Produto
    {
        public string NomeProd { get; protected set; }
        public double ValorProd { get; protected set; }
        public string Tipo { get; set; }
        public string Fornecedor { get; set; }
    }
}
