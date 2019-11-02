using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDeNegocio
{
    class Consumo
    {
        #region ATRIBUTOS
        public string CONSid { get; private set; }
        public double CONSvalor { get; private set; }
        #endregion ATRIBUTOS

        #region CONSTRUTORES
        public Consumo()
        {
            this.CONSid = "";
        }
        public Consumo(string id)
        {
            CONSid = id;
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
