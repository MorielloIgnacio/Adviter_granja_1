﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_29_01
{
    abstract public class Animal
    {
        protected decimal peso { get; set; }
        public bool vacuna { get; set; } = false;
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

        public bool getSed()
        {
            return this.sed;
        }

        public bool getTieneVacuna()
        {
            return this.vacuna;
        }


        //public Animal(decimal peso, bool vacuna, bool sed, bool hambre, int vecesComio) 
        //{
        //    this.peso = peso;
        //    this.vacuna = vacuna;
        //    this.sed = sed;
        //    this.hambre = hambre;
        //    this.vecesComio = vecesComio;

        //}

        abstract public void Comer(decimal cantidadComida);

        abstract public void Beber();

    }
}
