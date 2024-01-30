using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_29_01
{
    public class Gallina : Animal
    {

        public Gallina(decimal peso, bool vacuna, int vecesComio) 
        {   
            this.peso = peso;
            this.vacuna = vacuna;
            this.vecesComio = vecesComio;
            this.hambre = true;
            this.sed = false;
        }

        public override void Comer(int cantidadComida) 
        {

            this.vecesComio++;
            Console.WriteLine($"La gallina comio {this.vecesComio} veces" + "\n");
        }
        public override void Beber()
        {
            throw new NotImplementedException();
        }

    }
}
