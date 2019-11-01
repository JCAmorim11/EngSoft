using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaGestaoEstoque.Controller
{
    class Fornecedor
    {
        #region ATRIBUTOS
        public string FORnome { get; private set; }
        public string FORcnpj { get; private set; }
        public string FORnacl { get; private set; }
        public string FORcep { get; private set; }
        public string FORrua { get; private set; }
        #endregion

        #region CONSTRUTORES
        public Fornecedor()
        {
            FORnome = "";
            FORcnpj = "11111111111111";
            FORnacl = "Brasil";
            FORcep = "00000000";
            FORrua = "rua";
        }
        public Fornecedor(string nome, string cnpj, string nacl, string cep, string rua )
        {
            FORnome = nome;
            FORcnpj = cnpj;
            FORnacl = nacl;
            FORcep = cep;
            FORrua = rua;

        }
        #endregion

        #region MÉTODOS
        public bool FORinsereNome(string original)
        {
            if (FORvalidaNome(original))
            {
                FORnome = original;
                return true;
            }
            return false;
        }

        public bool FORinsereCPNJ(string original)
        {
            if (FORvalidaCNPJ(original)) {
                FORcnpj = original;
                return true;
            }
            return false;
        }

        public bool FORvalidaCNPJ(string cnpj)
        {
            string tempCNPJ = cnpj.Replace(",", "").Replace("-", "").Replace(".", "").Replace("/", "");

            if (tempCNPJ.Length != 14)
                return false;

            int A = int.Parse(tempCNPJ.Substring(0, 1)) * 5;
            int B = int.Parse(tempCNPJ.Substring(1, 1)) * 4;
            int C = int.Parse(tempCNPJ.Substring(2, 1)) * 3;
            int D = int.Parse(tempCNPJ.Substring(3, 1)) * 2;
            int E = int.Parse(tempCNPJ.Substring(4, 1)) * 9;
            int F = int.Parse(tempCNPJ.Substring(5, 1)) * 8;
            int G = int.Parse(tempCNPJ.Substring(6, 1)) * 7;
            int H = int.Parse(tempCNPJ.Substring(7, 1)) * 6;
            int I = int.Parse(tempCNPJ.Substring(8, 1)) * 5;
            int J = int.Parse(tempCNPJ.Substring(9, 1)) * 4;
            int K = int.Parse(tempCNPJ.Substring(10, 1)) * 3;
            int L = int.Parse(tempCNPJ.Substring(11, 1)) * 2;
            int M = int.Parse(tempCNPJ.Substring(12, 1));
            int N = int.Parse(tempCNPJ.Substring(13, 1));

            int soma = A + B + C + D + E + F + G + H + I + J + K + L;
            int resto = soma % 11;

            if ((resto < 2 && M == 0) || 11 - resto == M)
            {
                A = int.Parse(tempCNPJ.Substring(0, 1)) * 6;
                B = int.Parse(tempCNPJ.Substring(1, 1)) * 5;
                C = int.Parse(tempCNPJ.Substring(2, 1)) * 4;
                D = int.Parse(tempCNPJ.Substring(3, 1)) * 3;
                E = int.Parse(tempCNPJ.Substring(4, 1)) * 2;
                F = int.Parse(tempCNPJ.Substring(5, 1)) * 9;
                G = int.Parse(tempCNPJ.Substring(6, 1)) * 8;
                H = int.Parse(tempCNPJ.Substring(7, 1)) * 7;
                I = int.Parse(tempCNPJ.Substring(8, 1)) * 6;
                J = int.Parse(tempCNPJ.Substring(9, 1)) * 5;
                K = int.Parse(tempCNPJ.Substring(10, 1)) * 4;
                L = int.Parse(tempCNPJ.Substring(11, 1)) * 3;
                M *= 2;

                soma = A + B + C + D + E + F + G + H + I + J + K + L + M;
                resto = soma % 11;
                if ((resto < 2 && N == 0) || 11 - resto == N)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public bool FORvalidaNome(string nome)
        {
            return true;
        }
        #endregion
    }
}
