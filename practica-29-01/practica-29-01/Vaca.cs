using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_29_01
{
    public class Vaca : Animal
    {
        public Vaca(decimal peso, bool vacuna, bool sed, bool hambre, int vecesComio) {
            this.peso = peso;
            this.vacuna = vacuna;
            this.sed = sed; 
            this.hambre = hambre;
            this.vecesComio = vecesComio;
        }

        

        public override void Comer(int cantidadComida) 
        {
            this.peso += cantidadComida / 3;
            this.sed = true;
            this.TieneHambre();
            Console.WriteLine("La vaca comio" + " Ahora pesa: " + this.peso + "\n");
        }
        public override void Beber() 
        {

            this.sed = false;
            this.peso -= 500 ;
            this.TieneHambre();
            Console.WriteLine("La vaca bebio" + " Ahora pesa: " + this.peso + "\n");
        }
        
        public void TieneHambre()
        {
            if (this.peso> 200000) {
                this.hambre=false;
                Console.WriteLine("Tu vaca no tiene hambre" + "\n");
            } else { this.hambre=true; Console.WriteLine("Tu vaca tiene hambre" + "\n"); }
        }

        public void Caminata() 
        {
            this.peso -= 3000;
           this.TieneHambre();
            Console.WriteLine("La vaca camino" + " Ahora pesa: " + this.peso + "\n");
        }



    }
}
