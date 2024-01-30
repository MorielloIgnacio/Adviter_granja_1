using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_29_01
{
    public class Bebedero
    {
        int animalesAtendidos = 0;
        public void Hidratar(Animal animal)
        {
            
            if (animal.getSed()) {
                if (!NecesitaRecarga())
                {
                    Console.WriteLine($"El animal bebió");
                    animalesAtendidos++;
                }
                else
                {
                    Console.WriteLine("El bebedero necesita recarga");
                }
            }
            else
            {
                Console.WriteLine("El Animal no tiene sed");
            }
        }

        public bool NecesitaRecarga()
        {
            if (animalesAtendidos == 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Recargar()
        {
            if (NecesitaRecarga())
            {
                this.animalesAtendidos = 0;
                Console.WriteLine("El bebedero ha sido recargado \n");
            }
            else
            {
                Console.WriteLine("Todavia queda agua, no hace falta recargarlo \n");
            }
        }
    }
    }


