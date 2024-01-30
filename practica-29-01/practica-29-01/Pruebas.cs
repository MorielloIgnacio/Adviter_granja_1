using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace practica_29_01
{

    class TestClass
    {
        static void Main(string[] args)
        {

            Vaca lola = new Vaca(200100, false, false, false, 0);

            lola.Caminata();
            lola.Comer(50000);
            lola.Beber();

            Cerdo cerdito = new Cerdo(3000,false,false,true,0);
            Gallina gallinita = new Gallina(2500, false, 0);
            ComederoNormal comedero = new ComederoNormal(150000, 60, 10, 100);

            comedero.ValidarAnimal(lola);
            comedero.ValidarAnimal(cerdito);
            comedero.ValidarAnimal(cerdito);
            comedero.ValidarAnimal(cerdito);
            comedero.ValidarAnimal(cerdito);
            comedero.ValidarAnimal(cerdito);
            cerdito.Beber();
            comedero.ValidarAnimal(cerdito);
            comedero.ValidarAnimal(gallinita);

            ConfigurationManager.AppSettings["variable"].ToString();
            Console.ReadKey();
        }
        
    }

}
