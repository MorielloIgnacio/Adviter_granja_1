using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_29_01
{
    abstract public class Animal
    {
        protected decimal peso { get; set; }
        protected bool vacuna { get; set; } = false;
        protected bool sed{ get; set; } = false;
        protected bool hambre { get; set; } = false;
        protected int vecesComio { get; set; } = 0;

        public decimal getPeso()
        {
            return this.peso;
        }

        public bool getHambre()
        {
            return this.hambre;
        }



        //public Animal(decimal peso, bool vacuna, bool sed, bool hambre, int vecesComio) 
        //{
        //    this.peso = peso;
        //    this.vacuna = vacuna;
        //    this.sed = sed;
        //    this.hambre = hambre;
        //    this.vecesComio = vecesComio;

        //}

        abstract public void Comer(int cantidadComida);

        abstract public void Beber();

    }
}
