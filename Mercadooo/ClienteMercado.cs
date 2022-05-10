using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadooo
{
    class ClienteMercado
    { // Variáveis \\ 
        private int cpf;
        private string nomeCompleto;
        private string telefone;
        private string endereco;
        private int quantidade;
        private double valor;

        public ClienteMercado()
        { // instanciando variaveis \\
            AcessarCpf = 0;
            AcessarNome = "";
            AcessarTelefone = "";
            AcessarEndereco = "";
            AcessarQuantidade = 0;
            AcessarValor = 0;

        } // fim do metodo construtor \\

        public int AcessarCpf
        {
            get
            {
                return cpf;
            }

            set
            {
                this.cpf = value;
            }
        }

        public string AcessarNome
        {
            get
            {
                return nomeCompleto;
            }

            set
            {
                this.nomeCompleto = value;
            }

        }
            
        public string AcessarTelefone
        {
            get
            {
                return telefone;
            }
            set
            {
                this.telefone = value;
            }
        }
        public string AcessarEndereco
        {
            get
            {
                return endereco;
            }

            set
            {
                this.endereco = value;
            }
        } 

        public int AcessarQuantidade
        {
            get
            {
                return quantidade;
            }
            set
            {
                this.quantidade = value;

            }
        }

        public double AcessarValor
        {
            get
            {
                return valor;
            }
            set
            {
                this.valor = value;
            }
        }
        public void Cadastrar(int cpf, string nome, string telefone, string endereco, int quantidade, double valor)
        {
            AcessarCpf = cpf;
            AcessarNome = nome;
            AcessarTelefone = telefone;
            AcessarEndereco = endereco;
            AcessarQuantidade = quantidade;
            AcessarValor = valor;
        } // fim do cadastramento \\
        
        public string ConsultarCliente(int cpf)
        {
            if (AcessarCpf == cpf)
            {
                return "CPF: " + AcessarCpf +
                       "\nNome Completo: " + AcessarNome +
                       "\nTelefone: " + AcessarTelefone +
                       "\nEndereço: " + AcessarEndereco +
                       "\nQuantidades Compradas:" + AcessarQuantidade +
                       "\nValor Total Gasto: " + AcessarValor;

            }
            else
            {
                return "CPF Invalido! Digite Novamente!";
            }
        }

        public string AtualizarNome(int cpf, string nomeCompleto)
        {
            if (AcessarCpf == cpf)
            {
                AcessarNome = nomeCompleto;
                return "Seu Nome Foi Atualizado!";
            }
            else
            {
                return "CPF Inválido! Digite Novamente!";
            } // fim do atualizar nome \\
        }

        public string AtualizarTelefone(int cpf, string telefone)
        {
            if (AcessarCpf == cpf)
            {
                AcessarTelefone = telefone;
                return "Seu Telefone Foi Atualizado!";
            }
            else
            {
                return "CPF Inválido! Digite Novamente!";
            }
        }//fim do  atualizar telefone
        public string AtualizarEndereco(int cpf, string endereco)
        {
            if (AcessarCpf == cpf)
            {
                AcessarEndereco = endereco;
                return "Seu Endereço Foi Atualizado!";
            }
            else
            {
                return "CPF Inválido! Digite Novamente!";
            }
        }//fim do método Atualizar Endereço

        public string ExcluirCliente(int cpf)
        {
            if (AcessarCpf == cpf)
            {
                AcessarCpf = 0;
                AcessarNome = "";
                AcessarTelefone = "";
                AcessarEndereco = "";
                AcessarQuantidade = 0;
                AcessarValor = 0;
                return "Dados Foram Excluidos!";
            }
            else
            {
                return "CPF Inválido! Digite Novamente!";
            }

        } 

    } // fim da classe \\
} // fim do projeto \\
