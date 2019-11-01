using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CamadaDeDados
{
    public class Conexao
    {
        String StrCon = "";
        SqlConnection Conx = new SqlConnection();

        public void AbrirConexao()
        {
            Conx.ConnectionString = StrCon;
            Conx.Open();
        }
        public void FecharConexao()
        {
            Conx.Close();
        }
        public void ExecutarPRO()
        {

        }
    }
}
