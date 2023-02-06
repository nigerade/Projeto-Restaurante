using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Caixa
    {

        public double totalizarComanda(Comanda mesa)
        {
            mesa.verificarPromocao();
            mesa.setvalorTotal( (mesa.getvalorConsumo() + mesa.getvalorEstacionamento() + mesa.getvalorCouvert()) - mesa.getvalorDescontoPromocional());

            return mesa.getvalorTotal();


        }

    }
}
