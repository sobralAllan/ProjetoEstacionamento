using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoTI13N
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlMensalista control = new ControlMensalista();
            control.Operacao();

            //O item abaixo é utilizado APENAS para manter o CMD aberto
            Console.ReadLine();
        }//fim do método
    }//fim da classe 
}//fim do projeto
