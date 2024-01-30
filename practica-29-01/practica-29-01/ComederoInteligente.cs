using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_29_01
{
    internal class ComederoInteligente
    {
        decimal CapacidadMaxima;

        public ComederoInteligente(int CapacidadMaxima)
        {
            this.CapacidadMaxima = CapacidadMaxima;
        }

        public void ValidarAnimal(Animal animal)
        {

            if (animal.getHambre())
            {

                decimal ComidaADar = animal.getPeso() / 100;
                Console.WriteLine("Tu animal pesa " + animal.getPeso() + " Por lo que va a comer " + ComidaADar + " Gramos de comida");
                CapacidadMaxima -= ComidaADar;
                if (CapacidadMaxima < 0)
                {
                    Console.WriteLine("Al comedero no lo queda comida suficiente para alimentar a tu animal, por favor recargue!!");
                }
                else
                {
                    animal.Comer(ComidaADar);
                    Console.WriteLine("Al comedero ahora le queda " + CapacidadMaxima + " Gramos de comida");
                    necesitaRecarga();
                }


            }
            else { Console.WriteLine("Tu animal no tiene hambre"); }

        }


        public void necesitaRecarga()
        {
            if (this.CapacidadMaxima < 15000)
            {
                Console.WriteLine("El comedero necesita recarga, por favor recargue!");
            }
        }

    }
}