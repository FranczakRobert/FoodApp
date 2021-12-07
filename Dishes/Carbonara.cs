using System;
using System.Collections.Generic;

namespace App
{
    public class Carbonara : IDishes
    {
        public Carbonara()
        {  
            spaghettiCarbonara = new List<string>();
            pasujace_skladniki_spaghetti = new List<string>(); 


            spaghettiCarbonara.Add("makaron");
            spaghettiCarbonara.Add("smietana");
            spaghettiCarbonara.Add("parmezan");
            spaghettiCarbonara.Add("jajka");
            spaghettiCarbonara.Add("boczek");

        }

        public string name { get; set; } = "SPAGHETTI ALLA CARBONARA \n";
        public string ingridiends { get; set; } = "SKŁADNIKI: \n"+
                                                   "2 jajka\n"+
                                                   "100 g boczku (wędzonego lub suszonego - pancetty)\n"+
                                                   "150 g makaronu spaghetti\n"+
                                                   "2 ząbki czosnku\n"+
                                                   "2 łyżki drobno posiekanej natki pietruszki\n"+
                                                   "30 g sera Pecorino (lub Parmezanu lub Grana Padano)\n"+
                                                   "sól i świeżo zmielony czarny pieprz \n \n";
        public string recipe { get; set; } = "Oryginalny włoski przepis na makaron carbonara z boczkiem i sosem na bazie jajek. Prawdziwa carbonara nie zawiera śmietanki! \n" +
                                            " 1) Makaron ugotować al dente w osolonej wodzie. Jajka sparzyć wrzątkiem, wbić do głębokiego talerza, doprawić solą i roztrzepać widelcem.\n" +
                                            " 2) Na patelnię włożyć pokrojony w kosteczkę boczek i podsmażyć na małym ogniu przez kilka minut aż się lekko zrumieni. Dodać starty czosnek oraz posiekaną natkę pietruszki i smażyć jeszcze przez kilkanaście sekund.\n" +
                                            " 3) Trzymając patelnię na małym ogniu dodać makaron i wymieszać. Odstawić z ognia, dodać połowę sera i doprawić świeżo zmielonym pieprzem.\n"+
                                            " 4) Makaron polać roztrzepanymi jajkami i wymieszać. Jajka nie mogą całkowicie się ściąć, mają utworzyć kremowy sos i tylko trochę zgęstnieć od gorącego makaronu.\n"+
                                            " 5) Wyłożyć na talerze i posypać pozostałym serem.";
        

        public void ShowIngredients()
        {
            System.Console.WriteLine(ingridiends);
        }

        public void ShowRecipies()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(recipe);
        }



        public List<string> pasujace_skladniki_spaghetti;
        public List<string> spaghettiCarbonara;
    }
}
