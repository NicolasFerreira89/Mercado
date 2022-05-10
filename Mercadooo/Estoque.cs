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

        public int AcessarQuantidadeProduto
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

        public double AcessarValorUni
        {
            get
            {
                return valorUni;
            }
            set
            {
                this.valorUni = value;
            }
        }
        public string AcessarCategoria
        {
            get
            {
                return categoria;
            }
            set
            {
                this.categoria = value;
            }
        }

        public void CadatrarProduto (int codigoProduto, string nomeProduto, int quantidadeProduto, double valorUni, string categoria)
        {
            AcessarCodigoProduto = codigoProduto;
            AcessarNomeProduto = nomeProduto;
            AcessarQuantidadeProduto = quantidadeProduto;
            AcessarValorUni = valorUni;
            AcessarCategoria = categoria;
        }
         public string ConsultarProduto(int codigoProduto)
        {
            if(AcessarCodigoProduto == codigoProduto)
            {
                return "Código do Produto: " + AcessarCodigoProduto +
                        "\nNome do Produto: " + AcessarNomeProduto +
                        "\nQuantidade no Estoque: " + AcessarQuantidadeProduto +
                        "\nValor Unitário: " + AcessarValorUni +
                        "\nCategoria do Produto: " + AcessarCategoria;
            }
            else
            {
                return "Código do Produto inválido! Digite Novamente!";
            }
         }

        public string AtualizarNomeProduto(int codigoProduto, string nomeProduto)
        {
            if (AcessarCodigoProduto == codigoProduto)
            {
                AcessarNomeProduto = nomeProduto;
                return "Nome do Produto:" + AcessarNomeProduto + "Atualizado!";
            }
            else
            {
                return "Código do Produto inválido! Digite Novamente!";
            }
        }
        public string AtualizarQuantidadeProduto(int codigoProduto, int quantidadeProduto)
            {
                if(AcessarCodigoProduto == codigoProduto)
                {
                    AcessarQuantidadeProduto = quantidadeProduto;
                    return "Quantidade do Produto:" + AcessarNomeProduto + "Atualizada!";
                }
                else
                {
                    return "Código do Produto inválido! Digite Novamente!";
                }
            }
            public string AtualizarValorUni(int codigoProduto, double valorUni)
            {
                if(AcessarCodigoProduto == codigoProduto)
                {
                    AcessarValorUni = valorUni;
                }   return "Valor Unitário do Produto:" + AcessarNomeProduto + "Atualizado!";
            }

        public string AtualizarCategoria(int codigoProduto, string categoria)
        {
            if(AcessarCodigoProduto == codigoProduto)
            {
                AcessarCategoria = categoria;
                return "Categoria do Produto:" + AcessarNomeProduto + "Atualizada!";
            }
            else
            {
                return "Código do Produto inválido! Digite Novamente!";
            }
        }

        public string ExcluirProduto(int codigoProduto)
        {
            if (AcessarCodigoProduto == codigoProduto)
            {
                AcessarCodigoProduto = 0;
                AcessarNomeProduto = "";
                AcessarQuantidadeProduto = 0;
                AcessarValorUni = 0;
                AcessarCategoria = "";
                
                
                return "Dados do Produto Foram Excluidos!";
            }
            else
            {
                return "Código do Produto Inválido! Digite Novamente!";
            }
        }
    } // fim da classe \\

} // fim do projeto \\
