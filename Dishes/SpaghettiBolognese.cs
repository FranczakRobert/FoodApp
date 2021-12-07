using System;
using System.Collections.Generic;

namespace App
{
    public class SpaghettiBolognese : IDishes
    {
        public SpaghettiBolognese()
        {  
           bolognese = new List<string>();
           pasujace_bolognese = new List<string>();

            bolognese.Add("boczek");
            bolognese.Add("cebula");
            bolognese.Add("marchewka");
            bolognese.Add("mieso");
            bolognese.Add("mielone");
            bolognese.Add("pomidory");
            bolognese.Add("pomidor");
            bolognese.Add("mleko");
            bolognese.Add("makaron");
            bolognese.Add("parmezan");
            bolognese.Add("seler");

        }

        public string name { get; set; } = "SPAGHETTI BOLOGNESE \n \n";
        public string ingridiends { get; set; } = "SKŁADNIKI: \n"+
                                                   "150 g boczku\n"+
                                                   "1 cebula\n"+
                                                   "2 łodygi selera naciowego\n"+
                                                   "1 marchewka\n"+
                                                   "2 łyżki oliwy\n"+
                                                   "500 g mielonego mięsa\n"+
                                                   "1 szklanka czerwonego wina\n"+
                                                   "4 łyżki koncentratu pomidorowego\n"+
                                                   "1 szklanka gorącego bulionu\n"+
                                                   "1 puszka obranych pomidorów\n"+
                                                   "1/2 szklanki mleka\n"+
                                                   "makaron spaghetti (75 g / porcję)\n"+
                                                   "tarty parmezan\n \n";

        public string recipe { get; set; } = "PRZYGOTOWANIE: \n" +
                                            " 1) Boczek pokroić w drobną kostkę i włożyć na dużą patelnię, " +
                                            " wytopić na małym ogniu aż się zrumieni. Przesunąć na bok, w wytopiony " +
                                            " tłuszcz włożyć drobno posiekaną cebulę i zeszklić. Dodać drobno posiekany"+
                                            " seler naciowy i startą marchewkę. Obsmażyć, następnie wszystko przełożyć do garnka.\n"+
                                            " 2) Na patelnię wlać oliwę i obsmażyć mięso. Obsmażone mięso przełożyć do garnka z boczkiem."+
                                            "  i warzywami. Wlać wino i gotować mieszając ok. 5 minut. Dodać gorący bulion i koncentrat pomidorowy,"+
                                            " wymieszać. Dodać pomidory z puszki, doprawić solą i pieprzem. Drewnianą łyżką rozdrobnić pomidory i wymieszać.\n"+
                                            " 3) Przykryć i gotować na małym ogniu przez minimum 2 godziny, od czasu do czasu mieszając."+
                                            "  W połowie gotowania dodać mleko. Podawać z ugotowanym makaronem spaghetti posypując tartym parmezanem";
                                            
        

        public void ShowIngredients()
        {
            System.Console.WriteLine(ingridiends);
        }

        public void ShowRecipies()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(recipe);
        }

        public List<string> pasujace_bolognese;
        public List<string> bolognese;
    }
}
