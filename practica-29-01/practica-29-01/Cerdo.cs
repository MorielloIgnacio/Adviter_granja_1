using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_29_01
{
    public class Cerdo : Animal
    {
        decimal mayorCantidadComida = 0;

        public Cerdo(decimal peso, bool vacuna, bool sed, bool hambre, int vecesComio) { 
        this.peso = peso;
            this.vacuna = vacuna;
            this.sed = sed;
            this.hambre = hambre;
            this.vecesComio = vecesComio;
        
        }


        public override void Comer(decimal cantidadComida)
        {
            if (cantidadComida > 200)
            {
                this.peso += cantidadComida - 200;


            }
            else if (cantidadComida > 1000)
            {
                this.hambre = false;
            }
            if (cantidadComida > mayorCantidadComida)
            {
                mayorCantidadComida = cantidadComida;
            }
            this.vecesComio++;
            if (this.vecesComio > 3)
            {
                Console.WriteLine("El cerdito tiene sed" + "\n");
                this.sed = true;
            }
        }

        public override void Beber()
        {
            this.sed = false;
            this.hambre = true;
        }
    }
}
