using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadooo
{
    class ControlMercado
    {
        ClienteMercado cliente;
        Funcionarios funcionarios;
        Estoque estoque;
        private int opcao;
        public ControlMercado()

        {
            cliente = new ClienteMercado(); // conectando a control com model cliente \\
            funcionarios = new Funcionarios();  // conectando a control com model funcionarios \\
            estoque = new Estoque();  // conectando a control com model estoque \\

        }
        public int AcessarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\nEscolha uma da opções abaixo:\n\n" +
                                "1. Cadastrar Cliente\n" +
                                "2. Cadastrar Funcionário\n" +
                                "3. Cadastrar Produto\n" +
                                "4. Consultar Cliente\n" +
                                "5. Consultar Funcionário\n" +
                                "6. Consultar Produto\n" +
                                "7. Atualizar Nome Do Ciente\n " +
                                "8. Atualizar Nome Do Funcionário\n" +
                                "9. Atualizar Nome do Produto\n" +
                                "10. Atualizar Telefone do Cliente\n" +
                                "11. Atualizar Telefone do Funcionário\n" +
                                "12. Atualizar Endereço do Cliente\n" +
                                "13. Atualizar Endereço do Funcionário\n" +
                                "14. Atualizar Função do Funcionário\n" +
                                "15. Atualizar Salario do Funcionário\n" +
                                "16. Atualizar Quantidade do Produto\n" +
                                "17. Atualizar Valor Unitário do Produto\n" +
                                "18. Atualizar Categoria do Produto\n" +
                                "19. Excluir Cliente\n" +
                                "20. Excluir Funcionário\n" +
                                "21. Excluir Produto\n" +
                                "0. Sair");

            AcessarOpcao = Convert.ToInt32(Console.ReadLine());

        } // fim do Menu \\

        public void Executar()
        {
            do
            {
                Menu();
                switch (AcessarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1: // Coletando os dados  Clinete\\
                        Console.WriteLine("Informe o CPF do Cliente");
                        int cpf = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o nome do cliente");
                        string nomeCompleto = Console.ReadLine();
                        Console.WriteLine("Informe o Telefone do Cliente");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe o Endereço do Cliente");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("Quantidade de Compras Realizadas");
                        int quantidade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Valor Total Gasto");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Informe o Código do Funcionário");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o nome do Funcionário");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe o Telefone do Funcionário");
                        string telefoneFun = Console.ReadLine();
                        Console.WriteLine("Informe o Endereço do Funcionário");
                        string enderecoFun = Console.ReadLine();
                        Console.WriteLine("Informe a funçao do Funcionário");
                        string funcao = Console.ReadLine();
                        Console.WriteLine("Informe o salário do Funcionário");
                        double salario = Convert.ToDouble(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Informe o Código do Produto");
                        int codigoProduto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o nome do Produto");
                        string nomeProduto = Console.ReadLine();
                        Console.WriteLine("Informe a Quantidade em Estoque do Produto");
                        int quantidadeProduto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Valor Unitário do Produto");
                        double valorUni = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a Categoria do Produto");
                        string categoria = Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Informe o CPF do Cliente: ");
                        cpf = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(cliente.ConsultarCliente(cpf));
                        Console.ReadLine();//Manter o prompt aberto \\
                        break;

                    case 5:
                        Console.WriteLine("Informe o Código do Funcionário: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(funcionarios.ConsultarFun(codigo));
                        Console.ReadLine();//Manter o prompt aberto \\
                        break;
                    case 6:
                        Console.WriteLine("Informe o Códido do Produto: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(estoque.ConsultarProduto(codigoProduto));
                        Console.ReadLine();//Manter o prompt aberto \\
                        break;

                    case 7:
                        Console.WriteLine("Informe o CPF: ");
                        cpf = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o novo Nome: ");
                        nomeCompleto = Console.ReadLine();
                        Console.WriteLine(cliente.AtualizarNome(cpf, nomeCompleto));
                        break;

                    case 8:
                        Console.WriteLine("Informe o Código do Funcionário: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o novo Nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine(cliente.AtualizarNome(codigo, nome));
                        break;

                    case 9:
                        Console.WriteLine("Informe o Código do Produto: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o novo Nome do Produto: ");
                        nomeProduto = Console.ReadLine();
                        Console.WriteLine(estoque.AtualizarNomeProduto(codigoProduto, nomeProduto));
                        break;

                    case 10:
                        Console.WriteLine("Informe o CPF do Cliente: ");
                        cpf = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o novo Telefone do Cliente: ");
                        telefone = Console.ReadLine();
                        Console.WriteLine(cliente.AtualizarTelefone(cpf, telefone));
                        break;

                    case 11:
                        Console.WriteLine("Informe o Código do Funcionário: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o novo Telefone do Funcionário: ");
                        telefoneFun = Console.ReadLine();
                        Console.WriteLine(funcionarios.AtualizarTelefoneFun(codigo, telefoneFun));
                        break;

                    case 12:
                        Console.WriteLine("Informe o CPF do Cliente: ");
                        cpf = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o novo Endereço do Cliente: ");
                        endereco = Console.ReadLine();
                        Console.WriteLine(cliente.AtualizarEndereco(cpf, endereco));
                        break;

                    case 13:
                        Console.WriteLine("Informe o Código do Funcionário: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o novo Endereço do Funcionário: ");
                        enderecoFun = Console.ReadLine();
                        Console.WriteLine(funcionarios.AtualizarEnderecoFun(codigo, enderecoFun));
                        break;

                    case 14:
                        Console.WriteLine("Informe o Código do Funcionário: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a nova função do funcionário : ");
                        funcao = Console.ReadLine();
                        Console.WriteLine(funcionarios.AtualizarFuncao(codigo, funcao));
                        break;

                    case 15:
                        Console.WriteLine("Informe o Código do Funcionário: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o novo salário: ");
                        salario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(funcionarios.AtualizarSalario(codigo, salario));
                        break;

                    case 16:
                        Console.WriteLine("Informe o Código do produto: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a quantidade do produto: ");
                        quantidade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(estoque.AtualizarQuantidadeProduto(codigoProduto, quantidade));
                        break;

                    case 17:
                        Console.WriteLine("Informe o Código do produto: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o novo valor do produto: ");
                        valorUni = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(estoque.AtualizarValorUni(codigoProduto, valorUni));
                        break;

                    case 18:
                        Console.WriteLine("Informe o Código do produto: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a nova categoria do produto: ");
                        categoria = Console.ReadLine();
                        Console.WriteLine(estoque.AtualizarCategoria(codigoProduto, categoria));
                        break;

                    case 19:
                        Console.WriteLine("Informe o CPF do cliente: ");
                        cpf = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cliente excluido!");
                        Console.WriteLine(cliente.ExcluirCliente(cpf));
                        break;

                    case 20:
                        Console.WriteLine("Informe o Codigo do Funcionário: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Funcionário excluido!");
                        Console.WriteLine(funcionarios.ExcluirFun(codigo));
                        break;

                    case 21:
                        Console.WriteLine("Informe o Código do produto: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Produto excluido!");
                        Console.WriteLine(estoque.ExcluirProduto(codigoProduto));
                        break;
                } // fim do switch \\
            } while (AcessarOpcao != 0);
        }
    } // fim da classe \\
} // fim do projeto \\
