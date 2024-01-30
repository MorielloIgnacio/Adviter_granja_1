using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace practica_29_01
{
    public class ComederoNormal
    {

        int espacioMaximo { get; set; }
        int stockRaciones { get; set; }
        int entregaDeRaciones { get; set; }
        int pesoPorRacion { get; set; }

        public ComederoNormal(int espacioMaximo, int stockRaciones, int entregaDeRaciones, int pesoPorRacion) {

            this.espacioMaximo = espacioMaximo;
            this.stockRaciones = stockRaciones;
            this.entregaDeRaciones = entregaDeRaciones;
            this.pesoPorRacion = pesoPorRacion;
        }


        public void ValidarAnimal(Animal animal)
        {

            if (animal.getHambre())
            {
                if (animal.getPeso() > espacioMaximo)
                {
                    Console.WriteLine("Tu animal es muy pesado no puede entrar a comer" + "\n");
                }


                else
                {
                    this.stockRaciones -= entregaDeRaciones;
                    animal.Comer(porciones());
                    Console.WriteLine("Tu animal comio en el comedero: " + this.porciones() + " Gramos de comida" + "\n");
                }
            }
            else
            {
                Console.WriteLine("Tu animal no tiene hambre por lo que no va a comer" + "\n");
            }

        }

        public int porciones()
        {
            int racionesEnGramos = this.entregaDeRaciones * this.pesoPorRacion;
            return racionesEnGramos;
        }

    }


}
