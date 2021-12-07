using System;
using System.Collections.Generic;

namespace App
{
    public class SalatkaZAwokado : IDishes
    {
        public SalatkaZAwokado()
        {  
           avocado = new List<string>();
            pasujace_avocado = new List<string>();

            avocado.Add("batat");
            avocado.Add("bataty");
            avocado.Add("granat");
            avocado.Add("rukola");
            avocado.Add("orzechy");
            avocado.Add("cytryna");
            avocado.Add("avocado");
            avocado.Add("awokado");

        }

        public string name { get; set; } = "SAŁATKA Z AWOKADO I PIECZONYCH BATATÓW \n \n";
        public string ingridiends { get; set; } = "SKŁADNIKI: \n"+
                                                   "1 batat, ok. 300 g\n"+
                                                   "sól / pieprz\n"+
                                                   "1 łyżka oliwy\n"+
                                                   "szczypta płatków chili i opcjonalnie gałązka rozmarynu\n"+
                                                   "50 g orzechów włoskich lub pekan\n"+
                                                   "1/2 owocu granatu\n"+
                                                   "1 awokado\n"+
                                                   "100 g rukoli\n\n\n"+
                                                   "SKŁADNIKI DO SOSU: \n"+
                                                   "1 łyżka musztardy miodowej lub dijon \n"+
                                                   "2 łyżeczki miodu lub syropu klonowego \n"+
                                                   "1 łyżka oliwy extra vergine \n"+
                                                   "1 łyżka soku z cytryny \n"+
                                                   "1 łyżka octu ryżowego lub winnego\n\n \n";
        public string recipe { get; set; } = "PRZYGOTOWANIE: \n" +
                                            " 1) Bataty obrać, pokroić w kosteczkę. Skropić oliwą, doprawić solą," +
                                            " pieprzem, chili i listkami rozmarynu jeśli ich używamy.\n" +
                                            " 2) Wymieszać i ułożyć na blaszce do pieczenia lub w naczyniu żaroodpornym, wstawić do piekarnika"+
                                            " nagrzanego do 200 stopni C i piec przez około 30 minut lub do miękkości. Na 10 minut przed końcem dodać do pieczenia orzechy.\n"+
                                            " 3) Wyłuskać owoce z granatu. Awokado obrać, usunąć pestkę i pokroić w kosteczkę.\n"+
                                            " 4) Na półmiskach wyłożyć rukolę, doprawić solą i pieprzem, dodać bataty z orzechami, awokado i granata.\n"+
                                            " 5) Wymieszać składniki sosu i polać po sałatce.\n \n \n";
                                           
                                            
        

        public void ShowIngredients()
        {
            System.Console.WriteLine(ingridiends);
        }

        public void ShowRecipies()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(recipe);
        }

        public List<string> pasujace_avocado;
        public List<string> avocado;
    }
}
