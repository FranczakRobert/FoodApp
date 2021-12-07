using System;
using System.Collections.Generic;

namespace App
{
    public class MakaronZKurkami : IDishes
    {
        public MakaronZKurkami()
        {  
          makaron_z_kurkami = new List<string>();
          pasujace_skladniki_kurki = new List<string>();

            makaron_z_kurkami.Add("kurki");
            makaron_z_kurkami.Add("grzyby");
            makaron_z_kurkami.Add("makaron");
            makaron_z_kurkami.Add("smietana");
            makaron_z_kurkami.Add("śmietana");
            makaron_z_kurkami.Add("boczek");

        }

        public string name { get; set; } = "MAKARON Z KURKAMI I BOCZKIEM \n \n";
        public string ingridiends { get; set; } = "SKŁADNIKI: \n"+
                                                   "250 g świeżych kurek\n"+
                                                   "250 g boczku wędzonego\n"+
                                                   "1 cebula\n"+
                                                   "250 ml śmietany 18%\n"+
                                                   "300 g makaronu\n"+
                                                   "odrobina masła)\n";

        public string recipe { get; set; } = 
                                            " 1) Makaron gotujemy al dente, a cebulę pokrojoną w drobną kostkę podsmażany na odrobinie masła. Do zeszklonej cebulki należy dodać boczek i całość chwilę przesmażyć. \n" +
                                            " 2) Następnie do sosu dodajemy kurki, a po chwili również śmietaną. Co ważne, śmietanę mieszamy wcześniej w 2 łyżkami z wody od makaronu. Całość mieszamy do połączenia. Sos przyprawiamy na patelni solą i pieprzem. Dodajemy ugotowany makaron.\n";
        

        public void ShowIngredients()
        {
            System.Console.WriteLine(ingridiends);
        }

        public void ShowRecipies()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(recipe);
        }

        public List<string> pasujace_skladniki_kurki;
        public List<string> makaron_z_kurkami;
    }
}
