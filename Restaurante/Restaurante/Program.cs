using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {

            Comanda mesa = new Comanda();

            Caixa caixa = new Caixa();


            int op = 0;

            do
            {

                Console.Clear();

                Console.WriteLine("1 - Lançar\n2 - Verificar Promoção\n3 - Fechar Mesa\n4 - Listar Comanda\n0 - Sair");

                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        mesa.lancarGastos();
                        break;
                    case 2:
                        mesa.verificarPromocao();
                        break;
                    case 3:
                        caixa.totalizarComanda(mesa);
                        break;
                    case 4:
                        mesa.listarComanda();
                        break;
                   
                        
                   
                }

                Console.ReadKey();


            } while (op != 0);

        }
    }
}
