using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaGestaoEstoque.Controller
{
    /// <summary>
    /// Classe de controle de Login
    /// </summary>

    #region Classe Login
    class Login
    {
        public string CPF { get; set; }
        public string senha { get; private set; }

    /*    public Login{
            this.CPF="";
            this.senha="admin";
        }*/
        
        public bool CpfValido() {
            return true;
        }
        public bool ValidarSenha()
        {
            return true;
        }
    }
    #endregion
}
