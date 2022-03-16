using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoTI13N
{
    class Mensalista
    {
        private int codigo;
        private string nome;
        rivate string telefone;
        private string endereco;
        private DateTime dataDePagamento;
        private double valorMensal;
        public string msg;

        //Declaro o método construtor
        public Mensalista()
        {
            //Instanciando as variáveis
            this.codigo = 0;
            this.nome = "";
            this.telefone = "";
            this.endereco = "";
            this.dataDePagamento = new DateTime();
            this.valorMensal = 0;
        }//fim do construtor

        //Métodos de acesso
        public int ConsultarCodigo
        {
            get 
            {
                return codigo;
            }
            set
            {
                this.codigo = value;
            }
        }//fim do método consultarCodigo

        public string ConsultarNome
        {
            get
            {
                return nome;
            }
            set
            {
                this.nome = value;
            }
        }//fim do consultarNome

        public string ConsultarTelefone
        {
            get
            {
                return telefone;
            }
            set
            {
                this.telefone = value;
            }
        }//fim do consultarTelefone

        public string ConsultarEndereco
        {
            get
            {
                return endereco;
            }
            set
            {
                this.endereco = value;
            }
        }//fim do método ConsultarEndereço

        public DateTime ConsultarDataDePagamento
        {
            get
            {
                return dataDePagamento;
            }
            set
            {
                this.dataDePagamento = value;
            }
        }//fim do método ConsultarDataDePagamento

        public double ConsultarValorTotal
        {
            set
            {
                this.valorMensal = value;
            }
            get
            {
                return valorMensal;
            }
        }//fim do método ConsultarValorTotal

        //Método Cadastrar
        public void Cadastrar(int codigo, string nome, 
        string telefone, string endereco,
        DateTime dataDePagamento, double valorMensal)
        {
            ConsultarCodigo = codigo;
            ConsultarNome = nome;
            ConsultarTelefone = telefone;
            ConsultarEndereco = endereco;
            ConsultarDataDePagamento = dataDePagamento;
            ConsultarValorTotal = valorMensal;
        }//fim do método cadastrar

        //Método Consultar
        public string ConsultarTudo()
        {
            msg = "-------- Resultado da Consultar -------" +
            "\nCódigo: "              + ConsultarCodigo          +
            "\nNome: "                + ConsultarNome            +
            "\nTelefone: "            + ConsultarTelefone        +
            "\nEndereço: "            + ConsultarEndereco        +
            "\nData de Pagamento: "   + ConsultarDataDePagamento +
            "\nValor Mensal: "        + ConsultarValorTotal;

            return msg;
        }//fim do consultarTudo

        //Atualizar Nome
        public void AtualizarNome(int codigo, string nome)
        {
            if(ConsultarCodigo == codigo)
            {
                ConsultarNome = nome;
            }
        }//fim do método AtualizarNome

        public void AtualizarTelefone(int codigo, string telefone)
        {
            if(ConsultarCodigo == codigo)
            {
                ConsultarTelefone = telefone;
            }
        }//fim do método AtualizarTelefone

        public void AtualizarEndereco(int codigo, string endereco)
        {
            if (ConsultarCodigo == codigo)
            {
                ConsultarEndereco = endereco;
            }
        }//fim do método AtualizarTelefone

        public void AtualizarData(int codigo, DateTime dataDePagamento)
        {
            if (ConsultarCodigo == codigo)
            {
                ConsultarDataDePagamento = dataDePagamento;
            }
        }//fim do método AtualizarTelefone

        public void AtualizarValorTotal(int codigo, double valorMensal)
        {
            if (ConsultarCodigo == codigo)
            {
                ConsultarValorTotal = valorMensal;
            }
        }//fim do método AtualizarTelefone

        public void Excluir(int codigo)
        {
            if(ConsultarCodigo == codigo)
            {
                ConsultarNome = "";
                ConsultarTelefone = "";
                ConsultarEndereco = "";
                ConsultarDataDePagamento = new DateTime();
                ConsultarValorTotal = 0;
            }
        }//fim do excluir

    }//Fim da Classe
}//Fim do projeto
