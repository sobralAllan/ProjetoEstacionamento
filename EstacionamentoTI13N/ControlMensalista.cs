using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoTI13N
{
    class ControlMensalista
    {
        Mensalista mensalista;
        public int opcao;

        public ControlMensalista()
        {
            mensalista = new Mensalista();
        }//fim do construtor

        public void MenuMensalista()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("------- Menu -------" +
                    "\n1. Cadastrar Mensalista" +
                    "\n2. Consultar Mensalista" +
                    "\n3. Atualizar Nome" +
                    "\n4. Atualizar Endereço" +
                    "\n5. Atualizar Telefone" +
                    "\n6. Atualizar Data de Pagamento" +
                    "\n7. Atualizar Valor Mensal" +
                    "\n8. Desativar" +
                    "\n0. Sair" +
                    "\n\n Escolha uma das opções acima: ");
                opcao = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception erro)
            {
                Console.WriteLine("Algo deu errado!\n\n" + erro);
                opcao = 0;
            }
        } //fim do menu

        public void Operacao()
        {
            do
            {
                MenuMensalista();//Chamar o menu
                try
                {
                    switch (opcao)
                    {
                        case 0:
                            Console.WriteLine("Obrigado!");
                            break;
                        case 1:
                            Console.WriteLine("Informe o código: ");
                            int codigo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Informe o nome: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Informe o telefone: ");
                            string telefone = Console.ReadLine();
                            Console.WriteLine("Informe o Endereço: ");
                            string endereco = Console.ReadLine();
                            Console.WriteLine("Informe a Data de Pagamento");
                            DateTime data = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Informe o valor mensal");
                            double valor = Convert.ToDouble(Console.ReadLine());

                            //Chamar o método Cadastrar
                            mensalista.Cadastrar(codigo, nome, telefone, endereco, data, valor);
                            Console.WriteLine("Cadastrado com Sucesso!");
                            break;
                        case 2:

                            Console.WriteLine("Consultar...");
                            Console.WriteLine(mensalista.ConsultarTudo());
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Informe o código que será atualizado: ");
                            codigo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Informe o nome: ");
                            nome = Console.ReadLine();
                            //Executando o método da classe mensalista
                            mensalista.AtualizarNome(codigo, nome);
                            break;
                        case 4:
                            Console.WriteLine("Informe o código que será atualizado: ");
                            codigo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Informe o Endereço: ");
                            endereco = Console.ReadLine();
                            //Executar o método da classe mensalista
                            mensalista.AtualizarEndereco(codigo, endereco);
                            break;
                        case 5:
                            Console.WriteLine("Informe o código que será atualizado: ");
                            codigo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Informe o telefone: ");
                            telefone = Console.ReadLine();
                            //Executar o método da classe mensalista
                            mensalista.AtualizarTelefone(codigo, telefone);
                            break;
                        case 6:
                            Console.WriteLine("Informe o código que será atualizado: ");
                            codigo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Informe o nova data de pagamento: ");
                            data = Convert.ToDateTime(Console.ReadLine());
                            //Executar o método da classe mensalista
                            mensalista.AtualizarData(codigo, data);
                            break;
                        case 7:
                            Console.WriteLine("Informe o código que será atualizado: ");
                            codigo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Informe o novo valor total: ");
                            valor = Convert.ToDouble(Console.ReadLine());
                            //Executar o método da classe mensalista
                            mensalista.AtualizarValorTotal(codigo, valor);
                            break;
                        case 8:
                            Console.WriteLine("Informe o código do cliente que será desativado: ");
                            codigo = Convert.ToInt32(Console.ReadLine());
                            //Executar o método da classe mensalista
                            mensalista.Excluir(codigo);
                            Console.WriteLine("Dado excluido com sucesso!");
                            break;
                        default:
                            Console.WriteLine("Opção invalida! Escolha um número entre 0 e 8");
                            break;
                    }//fim do switch
                }
                catch(Exception e)
                {
                    Console.WriteLine("Algo deu errado!");
                    opcao = 0;
                }
            } while (opcao != 0);
        }//fim do operacao



    }//fim da classe
}//Fim do projeto
