using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadooo
{
    class Funcionarios
    {
        private int codigo;
        private string nome;
        private string enderecoFun;
        private string telefoneFun;
        private string sexo;
        private string bairro;
        private string funcao;
        private double salario;
        // fim das variaveis \\

        public Funcionarios()
        {
            AcessarCodigo = 0;
            AcessarNomeFun = "";
            AcessarTelefoneFun = "";
            AcessarEnderecoFun = "";
            AcessarSexoFun = "";
            AcessarBairro = "";
            AcessarFuncao = "";
            AcessarSalario = 0;


        }// fim da Construtor

        public int AcessarCodigo
        {
            get
            {
                return codigo;
            }
            set
            {
                this.codigo = value;
            }


        }
        public string AcessarNomeFun
        {
            get
            {
                return nome;
            }
            set
            {
                this.nome = value;
            }


        }
        public string AcessarTelefoneFun
        {
            get
            {
                return telefoneFun;
            }
            set
            {
                this.telefoneFun = value;
            }
        }

        public string AcessarEnderecoFun
        {
            get
            {
                return enderecoFun;
            }

            set
            {
                this.enderecoFun = value;
            }
        }

        public string AcessarSexoFun
        {
            get
            {
                return sexo;
            }
            set
            {
                this.sexo = value;
            }
        }
        public string AcessarBairro
        {
            get
            {
                return bairro;
            }
            set
            {
                this.bairro = value;
            }
        }
        public string AcessarFuncao
        {
            get
            {
                return funcao;
            }
            set
            {
                this.funcao = value;
            }
        }
        public double AcessarSalario
        {
            get
            {
                return salario;
            }
            set
            {
                this.salario = value;
            }
        }

        public void CadastrarFun(int codigo, string nome, string enderecoFun,string telefoneFun, string sexo, string bairro, string funcao, double salario)
        {
            AcessarCodigo = codigo;
            AcessarNomeFun = nome;
            AcessarTelefoneFun = telefoneFun;
            AcessarEnderecoFun = enderecoFun;
            AcessarSexoFun = sexo;
            AcessarBairro = bairro;
            AcessarFuncao = funcao;
            AcessarSalario = salario;  
        }
        public string ConsultarFun(int codigo)
        {
            if(AcessarCodigo == codigo)
             {
                return "codigo: " + AcessarCodigo +
                       "\nNome Completo: " + AcessarNomeFun +
                       "\nTelefone: " + AcessarTelefoneFun +
                       "\nEndereço: " + AcessarEnderecoFun +
                       "\nSexo:    "  + AcessarSexoFun     +
                       "\nBairro:  "  + AcessarBairro      +
                       "\nSalario  "  + AcessarSalario     +
                       "\nFuncao   "  + AcessarFuncao      ;
            } 
            else
            {
                 return "codigo Invalido! Digite Novamente!";
            }
        }
        public string AtualizarNomeFun(int codigo, string nome) 
        {

            if (AcessarCodigo == codigo)
            {
                AcessarNomeFun = nome;
                return "Seu Nome Foi Atualizado!";
            }
            else
            {
                return "Código Invalido!";
            }

        }
        public string AtualizarTelefoneFun(int codigo, string telefoneFun)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarTelefoneFun = telefoneFun;
                return "Seu telefone Foi Atualizado!";
            }
            else
            {
                return "Código Invalido!";
            }
        }
         public string AtualizarEnderecoFun(int codigo, string enderecoFun)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarEnderecoFun = enderecoFun;
                return "Seu endereço foi atualizado!";
            }
            else
            {
                return "Código Invalido!";
            }
        }
        public string Atualizarbairro(int codigo, string bairro)
        {
            if ( AcessarCodigo == codigo)
            {
                AcessarBairro = bairro;
                return "Seu Bairro foi Atualixado!";   
            }
            else
            {
                return "Código Invalido!";
            }
        }
        public string AtulizarFuncao(int codigo, string funcao)
        {
            if( AcessarCodigo == codigo)
            {
                AcessarFuncao = funcao;
                return "Sua Funçao foi Atualizada!";
            }
            else
            {
                return "Código Invalido!";
            }
        }
        public string AtualizarSalario(int codigo, double salario)
        {
            if(AcessarCodigo == codigo)
            {
                AcessarSalario = salario;
                return "Seu salário foi Atualizado";

            }
            else
            {
                return "Código Invalido!";
            }
        }

        






    } // fim da classe \\

}
