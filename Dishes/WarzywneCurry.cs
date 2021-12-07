using System;
using System.Collections.Generic;

namespace App
{
    public class WarzywneCurry : IDishes
    {
        public WarzywneCurry()
        {  
           curry = new List<string>();
           pasujace_curry = new List<string>();
            
            curry.Add("dynia");
            curry.Add("imbir");
            curry.Add("kalafior");
            curry.Add("passa pomidorowa");
            curry.Add("ciecierzyca");
            curry.Add("mleko kokosowe");
            

        }

        public string name { get; set; } = "WARZYWNE CURRY Z DYNIĄ, KALAFIOREM I CIECIERZYCĄ \n \n";
        public string ingridiends { get; set; } = "SKŁADNIKI: \n"+
                                                   "300 g dyni\n"+
                                                   "1 średnia cebula\n"+
                                                   "1 łyżka oleju roślinnego\n"+
                                                   "2 ząbki czosnku\n"+
                                                   "2 cm kawałek imbiru\n"+
                                                   "po 2 łyżeczki przyprawy curry i kurkumy\n"+
                                                   "1 łyżeczka mielonej papryki\n"+
                                                   "250 ml wody\n"+
                                                   "250 ml passaty pomidorowej \n"+
                                                   "300 g kalafiora \n"+
                                                   "300 g ciecierzycy z puszki \n"+
                                                   "250 ml mleka kokosowego\n\n";
                                              
        public string recipe { get; set; } = "PRZYGOTOWANIE: \n" +
                                            " 1) Dynię obrać ze skóry i pestek, miąższ pokroić w kostkę.\n" +
                                            " 2) Cebulę obrać i pokroić na cienkie półplasterki.\n" +
                                            " 3) Rozgrzać olej w większym garnku, dodać cebulę i zeszklić ją.\n"+
                                            " 4) Dodać obrany i starty czosnek oraz imbir. Mieszając smażyć przez 1 minutę.\n"+
                                            " 5) Dodać wszystkie przyprawy, wymieszać i chwilę razem podsmażać.\n"+
                                            " 6) Dodać wodę, passatę oraz dynię. Zagotować, doprawić solą oraz pieprzem. Gotować przez 20 minut bez przykrycia.\n"+
                                            " 7) Dodać kalafiora (pokrojonego w kostkę lub na małe różyczki), mleko kokosowe oraz ciecierzycę wraz z częścią zalewy.\n"+
                                            " 8) Wymieszać i gotować przez ok. 10 minut. Podawać z ugotowanym ryżem i świeżą kolendrą.\n \n";
                                            
        

        public void ShowIngredients()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(ingridiends);
        }

        public void ShowRecipies()
        {
            
            System.Console.WriteLine(recipe);
        }

        public List<string> pasujace_curry;
        public List<string> curry;
    }
}
