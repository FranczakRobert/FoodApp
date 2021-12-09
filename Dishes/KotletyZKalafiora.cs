using System;
using System.Collections.Generic;

namespace App
{
    public class KotletyZKalafiora : IDishes
    {
        public KotletyZKalafiora()
        {  
            kalafior = new List<string>();
            pasujace_kalafior = new List<string>(); 

            
            kalafior.Add("kasza");
            kalafior.Add("kasza jaglana");
            kalafior.Add("mleko");
            kalafior.Add("kalafior");
            kalafior.Add("jajka");
            kalafior.Add("cebula");
            kalafior.Add("olej");
            

        }

        public string name { get; set; } = "KOTLETY Z KALAFIORA I KASZY JAGLANEJ \n";
        public string ingridiends { get; set; } =   "SKŁADNIKI: \n\n"+
                                                    "kasza jaglana 100 gramów \n"+
                                                    "mleko 100 mililitrów "+
                                                    "mąka z ciecierzycy 50 gramów"+
                                                    "nieduży kalafior 1 sztuka\n"+
                                                    "olej rzepakowy 100 mililitrów\n"+
                                                    "Rosół z kury 1 sztuka\n"+
                                                    "Curry 1 łyżeczka\n"+
                                                    "cebula 1 sztuka\n"+
                                                    "kolendra 1 pęczek\n"+
                                                    "jajka 2 sztuki\n"+
                                                    "Pieprz czarny z Wietnamu mielony Knorr 1 szczypta\n"+
                                                    "bułka tarta 100 gramów\n"+
                                                    "pestki dyni 50 gramów\n"+
                                                    "Chili z Indii Knorr 0.5 łyżeczki\n\n\n"+

                                                    "SKŁADNIKI DO SOSU: \n"+
                                                    "Majonez Hellmann's Babuni 2 łyżki\n"+
                                                    "Czosnek z USA Knorr 1 łyżeczka\n"+
                                                    "jogurt naturalny 200 mililitrów \n"+
                                                    "cytryna 0.5 sztuki\n\n\n";
        public string recipe { get; set; } = "PRZYGOTOWANIE: \n" +
                                            " 1) Kasze jaglaną ugotuj w 200 ml wody,100 ml mleka z kostką rosołową do miękkości. Kasza może być lekko rozgotowania.\n" +
                                            " 2) 2 jaja ugotuj na twardo obierz posiekaj nożem z grubsza. Cebulę pokrój w kostkę, przesmaż na odrobinie oleju. Pestki dyni upraż na suchej patelni.\n"+
                                            " 3) Surowego kalafiora posiekaj nożem powinien być mocno rozdrobniony. Posiekaj pęczek kolendry.\n"+
                                            " 4) W misce połącz ciepła kaszę , jajka , kalafiora pestki dyni, cebulę, mąkę, kolendrę, pieprz , curry, chili . Wszystkie składniki dokładnie wymieszaj w razie potrzeby dopraw odrobiną soli do smaku.\n"+
                                            " 5) Z masy uformuj ma kotleciki obtocz je z wierzchu w bułce obsmaż na złoty kolor na patelni. Kotleciki podawaj z dipem czosnkowym.\n" +
                                            " 6) Jogurt połącz majonezem z sokiem z połówki cytryny i czosnkiem. Kotleciki podawaj z ulubioną sałatką.\n";


        public void ShowIngredients()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(ingridiends);
        }

        public void ShowRecipies()
        {
            System.Console.WriteLine(recipe);
        }



        public List<string> pasujace_kalafior;
        public List<string> kalafior;
    }
}
