using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace wfaGestaoEstoque.Controller
{
    class Compra
    {
        #region ATRIBUTOS
        public string COMid { get; private set; }
        public double COMpreço { get; private set; }
        public int[] COMdata { get; private set; }
        public int[] COMstatus { get; private set; }
        /*Observação sobre atributos:
         * COMdata: Posição[0]= dia, Posição[1]=mês, Posição[2]=ano;
         * COMstatus: Posição[0]= em aberto, Posição[1]=a caminho, Posição[2]=finalizada,
         * Posição[3]=Cancelada.
        */
        #endregion ATRIBUTOS

        #region CONSTRUTORES
        public Compra() {
            this.COMid = "";
            this.COMpreço = 0.00;
            this.COMdata = new int[3] { 01, 01, 1970 };
            this.COMstatus = new int[4] { 0, 1, 2, 3 };
        }
        public Compra(string id,double preco, int[] data, int[] COMstatus)
        {
            this.COMid = id;
            this.COMpreço = preco;
            this.COMdata = data;
            this.COMstatus = COMstatus;
        }
        #endregion CONSTRUTORES

        #region MÉTODOS
        /* EM CONSTRUÇÃO
         * public int[] Consumidor(int[] vetor) {
             return vetor;
         }*/
        /*public void COMinserirID() {
            //insere o ID 
        }*/
        public bool CONinserePreco()
        {
            return true;
        }
        public bool CONinsereData()
        {
            return true;
        }
        public bool CONinsereStatus()
        {
            return true;
        }
        #endregion MÉTODOS

    }
}
