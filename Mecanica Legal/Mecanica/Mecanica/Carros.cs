using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanica
{
    class Carros
    {
        public enum Cores { Branco, Preto, Vermelho, Azul, Verde, Amarelo, Personalizado }

        protected string Marca;
        protected string Modelo;
        protected int Ano;
        protected Cores Cor;
        protected int Portas;

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetMarca(string marca)
        {
            return Marca;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public string GetModelo(string modelo)
        {
            return Modelo;
        }
        public void SetAno(int ano)
        {
            Ano = ano;
        }

        public int GetAno(int ano)
        {
            return Ano;
        }
        public void SetCores(Cores cor)
        {
            Cor = cor;
        }

        public Cores GetCores(Cores cor)
        {
            return Cor;
        }
        
        public void SetPortas(int portas)
        {
            Portas = portas;
        }

        public int GetPortas()
        {
            return Portas;
        }



        #region Acesso a Dados
        public void Incluir() { }
        public void Consultar() { }
        public void Alterar() { }
        public void Excluir() { }
        #endregion

    }
}
