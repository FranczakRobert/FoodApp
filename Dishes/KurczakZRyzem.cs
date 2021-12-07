using System;
using System.Collections.Generic;

namespace App
{
    public class KurczakZRyzem : IDishes
    {
        public KurczakZRyzem()
        {  
            kurczakzryzem = new List<string>();
           pasujace_skladniki_kurczak = new List<string>();

            
            kurczakzryzem.Add("ryz");
            kurczakzryzem.Add("oliwa");
            kurczakzryzem.Add("kurczak");
            kurczakzryzem.Add("cebula");
            kurczakzryzem.Add("papryka");
            

        }

        public string name { get; set; } = "KURCZAK Z RYZEM \n \n";
        public string ingridiends { get; set; } = "SKŁADNIKI: \n"+
                                                   "200g ryzu\n"+
                                                   "oliwa z oliwek\n"+
                                                   "olej\n"+
                                                   "papryka w prosku\n"+
                                                   "200g piersi z kurczaka\n"+
                                                   "przyprawy (sól, pieprz)\n"+
                                                   "2 papryki\n"+
                                                   "1 cebula\n"+
                                                   "200g kukurydzy \n \n";

        public string recipe { get; set; } = "PRZYGOTOWANIE: \n" +
                                            " 1) Zaczynamy od ugotowania ryżu zgodnie z instrukcją podaną na opakowaniu.\n" +
                                            " 2) Mięso dokładnie myjemy i osuszamy na ręczniku papierowym. Kroimy w drobną kosteczkę.\n" +
                                            " 3) Mięso przekładamy do miski i posypujemy wybranymi przez siebie przyprawami. My doprawiliśmy je papryką w proszku i solą.\n"+
                                            " 4) Smażymy mięso na oleju. Raz na jakiś czas mieszamy.\n"+
                                            " 5) W tym czasie, myjemy i kroimy warzywa. Paprykę i cebulę kroimy w kostkę, a kukurydzę odsączamy (jeżeli była w puszcze).\n"+
                                            " 6) Na patelnię wylewamy kilka kropel oliwy z oliwek. Wrzucamy tam cebulę i smażymy chwilę, aż lekko się nie zeszkli. Po tym czasie wrzucamy pozostałe warzywa. Możemy doprawić je solą i pieprzem.\n"+
                                            " 7) Kiedy ryż już się ugotuje przesypujemy go do miski. Wrzucamy tam ugotowane warzywa i mięso i całość mieszamy. Mozemy podawać na talerz.\n"+
                                            " 8) Inną propozycją podania jest wyłożenie na talerz ryżu i nasypania na wierzch warzyw i mięsa.\n";
                                            
        

        public void ShowIngredients()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(ingridiends);
        }

        public void ShowRecipies()
        {
            
            System.Console.WriteLine(recipe);
        }

        public List<string> pasujace_skladniki_kurczak;
        public List<string> kurczakzryzem;
    }
}
