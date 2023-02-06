using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Comanda
    {

        private int id;
        private double valorConsumo;
        private double valorEstacionamento;
        private double valorCouvert;
        private double valorDescontoPromocional;
        private double valorTotal;

        public int getid()
        {
            return id;
        }

        public void setid(int id)
        {
            this.id = id;
        }



        public double getvalorConsumo()
        {
            return valorConsumo;
        }

        public void setValorConsumo(double valorConsumo)
        {
            this.valorConsumo = valorConsumo;
        }



        public double getvalorEstacionamento()
        {
            return valorEstacionamento;
        }

        public void setvalorEstacionamento(double valorEstacionamento)
        {
            this.valorEstacionamento = valorEstacionamento;
        }


        public double getvalorCouvert()
        {
            return valorCouvert;
        }

        public void setvalorCouvert(double valorCouvert)
        {
            this.valorCouvert = valorCouvert;
        }



        public double getvalorDescontoPromocional()
        {
            return valorDescontoPromocional;
        }

        public void setvalorDescontoPromocional(double valorDescontoPromocional)
        {
            this.valorDescontoPromocional = valorDescontoPromocional;
        }



        public double getvalorTotal()
        {
            return valorTotal;
        }

        public void setvalorTotal(double valorTotal)
        {
            this.valorTotal = valorTotal;
        }



        public Comanda()
        {
            id = 0;
            valorConsumo = 0.0;
            valorCouvert = 0.0;
            valorDescontoPromocional = 0.0;
            valorEstacionamento = 0.0;
            valorTotal = 0.0;
        }

        public Comanda(int id, double valorConsumo, double valorCouvert,
            double valorDescontoPromocional, double valorEstacionamento,
            double valorTotal)
        {
            this.id = id;
            this.valorConsumo = valorConsumo;
            this.valorCouvert = valorCouvert;
            this.valorDescontoPromocional = valorDescontoPromocional;
            this.valorEstacionamento = valorEstacionamento;
            this.valorTotal = valorTotal;
        }

        public Comanda(int id)
        {
            this.id = id;
        }

        public void verificarPromocao()
        {
            if (valorConsumo > 100)
            {
              setvalorDescontoPromocional(valorConsumo * 0.1);
                Console.WriteLine("Valor Promocional é de: " + getvalorDescontoPromocional());
            }

            else
            {
                Console.WriteLine("Não Possui valor Promocional!");
            }
        }

        public void lancarGastos()
        {
            setid(id+=1);

            Console.WriteLine("Digite o valor do consumo: ");
            setValorConsumo(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o valor do couvert: ");
            setvalorCouvert(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o valor do estacionamento: ");
            setvalorEstacionamento(double.Parse(Console.ReadLine()));

            setvalorDescontoPromocional(0);

            setvalorTotal(0);

        }

        public void listarComanda()
        {
            Console.WriteLine("id: " + id +
                "\nValor do Consumo: " + valorConsumo +
                "\nValor do Desconto Promocional: " + valorDescontoPromocional +
                "\nValor do Estacionamento: " + valorEstacionamento +
                "\nValor do Couvert: " + valorCouvert +
                "\nValor Total: " + valorTotal
                );
        }

    }
}
