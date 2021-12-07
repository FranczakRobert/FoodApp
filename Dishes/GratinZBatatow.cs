using System;
using System.Collections.Generic;

namespace App
{
    public class GratinZBatatow : IDishes
    {
        public GratinZBatatow()
        {  
            batat = new List<string>();
            pasujace_batat = new List<string>();


            batat.Add("batat");
            batat.Add("bataty");
            batat.Add("smietanka");
            batat.Add("śmietanka");
            batat.Add("smietana");
            batat.Add("śmietanka");
            batat.Add("papryka");
            batat.Add("papryka ostra");

        }

        public string name { get; set; } = "GRATIN Z BATATÓW \n \n";
        public string ingridiends { get; set; } = "SKŁADNIKI: \n"+
                                                   "2 duże bataty \n"+
                                                   "2 ząbki czosnku (lub 1 łyżeczka sproszkowanego) \n"+
                                                   "1 gałązka rozmarynu (lub 1 łyżka suszonego) można zastąpić tymiankiem \n"+
                                                   "sól i pieprz \n\n";

        public string recipe { get; set; } = 
                                            " 1) Piekarnik nagrzać do 190 stopni C. Małe naczynie żaroodporne (o boku ok. 15 cm) posmarować oliwą. Bataty obrać i pokroić w melakserze na cienkie plasterki.\n" +
                                            " 2) Czosnek przecisnąć przez praskę, wymieszać z posiekanymi listkami rozmarynu, solą i pieprzem.\n"+
                                            " 3) Układać plasterki batatów w naczyniu, na zakładkę. Po 3 - 4 warstwach posypać mieszanką rozmarynu i czosnku i znów ułożyć 3 - 4 warstwy batatów. Zalać całość śmietanką.\n"+
                                            " 4) Przykryć folią aluminiową i piec przez 45 minut, zdjąć folię i zapiekać jeszcze przez 15 minut. Udekorować rozmarynem, posypać ostrą papryką.\n \n \n";
                                           
                                            
        

        public void ShowIngridiens()
        {
            System.Console.WriteLine(ingridiends);
        }

        public void ShowRecipies()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(recipe);
        }

        public List<string> pasujace_batat;
        public List<string> batat;
    }
}
