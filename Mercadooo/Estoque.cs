using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadooo
{
    class Estoque
    {
        private int codigoProduto;
        private string nomeProduto;
        private int quantidadeProduto;
        private double valorUni;
        private string categoria;

        public Estoque()
        {
            AcessarCodigoProduto = 0;
            AcessarNomeProduto = "";
            AcessarQuantidadeProduto = 0;
            AcessarValorUni = 0;
            AcessarCategoria = "";
        }// fim do metodo construtor \\

        public int AcessarCodigoProduto
        {
            get
            {
                return codigoProduto;
            }
            set
            {
                this.codigoProduto = value;
            }
        }

        public string AcessarNomeProduto
        {
            get
            {
                return nomeProduto;
            }
            set
            {
                this.nomeProduto = value;
            }
        }

        public int AcessarQuantidadèProduto
        {
            get
            {
                return quantidadeProduto;
            }
            set
            {
                this.quantidadeProduto = value;
            }
        }
    }// fim da classe \\

} // fim do projeto \\
