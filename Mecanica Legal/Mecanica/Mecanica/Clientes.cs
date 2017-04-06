using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanica
{
    class Clientes
    {

        protected string Nome;
        protected string DataNascimento;

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetNome(string nome)
        {
            return Nome;
        }
        public void SetDataNascimento(string datanascimento)
        {
            DataNascimento = datanascimento;
        }

        public string GetDataNascimento(string datanascimento)
        {
            return DataNascimento;
        }



        #region Acesso a Dados
        public void Incluir() { }
        public void Consultar() { }
        public void Alterar() { }
        public void Excluir() { }
        #endregion

    }
}
