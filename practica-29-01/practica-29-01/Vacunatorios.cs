using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_29_01
{
    public class Vacunatorios
    {
        public int vacunasDisponibles;

        public Vacunatorios(int vacunasDisponibles) 
        {
            this.vacunasDisponibles = vacunasDisponibles;
        }
        public void Vacunar(Animal animal)
        {

            if (vacunasDisponibles > 0)
            {

                if (animal is Vaca)
                {
                    if (!animal.getTieneVacuna() )
                    {
                        animal.vacuna = true;
                        vacunasDisponibles--;
                        Console.WriteLine("Tu Vaca esta vacunada");
                    }
                    else
                    {
                        Console.WriteLine("Ya tiene 1 vacuna");

                    }
                }
                else if (animal is Cerdo)
                {
                    vacunasDisponibles--;
                    Console.WriteLine("Tu cerdo esta vacunada");
                }
                else
                {
                    Console.WriteLine("No vamos a vacunar a tu gallina");
                }
            }
        
            RecargarVacunas();
        }
        public void RecargarVacunas() 
        {
          vacunasDisponibles = 50;

         Console.WriteLine("Ya se recargo tu Vacunatorio");


        }

    }
            
    
    }
