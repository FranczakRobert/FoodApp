using System;
using System.Collections.Generic;

namespace App
{
    public class Products
    {
        public Products()
        {
            

            list_products = new List<string>();
 


            

        }

        public void AddProducts(string ingridients)
        {
            list_products.Add(ingridients);
        }

        public void ShowRecipes(string odp)
        {
            
            bool end = true;
            while(end == true)
            {       string input;
                    input = odp.ToLower();
                    if(input == "spaghetti alla carbonara")
                    {
                        Carbonara carbonara = new Carbonara();
                        carbonara.ShowIngridiens();
                        carbonara.ShowRecipies();
                        break;
                    }
                    if(input == "kurczak z ryzem")
                    {
                        KurczakZRyzem kurczakZRyzem = new KurczakZRyzem();
                        kurczakZRyzem.ShowIngridiens();
                        kurczakZRyzem.ShowRecipies();
                        break;
                    }
                    if(input == "makaron z kurkami i boczkiem")
                    {
                        MakaronZKurkami makaronZKurkami = new MakaronZKurkami();
                        makaronZKurkami.ShowIngridiens();
                        makaronZKurkami.ShowRecipies();
                        break;
                    }
                    if(input == "spaghetti bolognese")
                    {
                        SpaghettiBolognese spaghettiBolognese = new SpaghettiBolognese();
                        spaghettiBolognese.ShowIngridiens();
                        spaghettiBolognese.ShowRecipies();
                        break;
                    }
                    if(input == "warzywne curry z dynią, kalafiorem i ciecierzycą")
                    {
                        WarzywneCurry warzywneCurry = new WarzywneCurry();
                        warzywneCurry.ShowIngridiens();
                        warzywneCurry.ShowRecipies();
                        break;
                    }
                    if(input == "sałatka z awokado i pieczonych batatów")
                    {
                        SalatkaZAwokado salatkaZAwokado = new SalatkaZAwokado();
                        salatkaZAwokado.ShowIngridiens();
                        salatkaZAwokado.ShowRecipies();
                        break;
                    }
                    if(input == "gratin z batatów")
                    {   
                        System.Console.WriteLine("GRATIN Z BATATÓW");
                        System.Console.WriteLine("SKŁANIKI");
                        System.Console.WriteLine("2 duże bataty");
                        System.Console.WriteLine("2 ząbki czosnku (lub 1 łyżeczka sproszkowanego)");
                        System.Console.WriteLine("1 gałązka rozmarynu (lub 1 łyżka suszonego) można zastąpić tymiankiem");
                        System.Console.WriteLine("sól i pieprz");
                        System.Console.WriteLine("1) Piekarnik nagrzać do 190 stopni C. Małe naczynie żaroodporne (o boku ok. 15 cm) posmarować oliwą. Bataty obrać i pokroić w melakserze na cienkie plasterki.");
                        System.Console.WriteLine("2) Czosnek przecisnąć przez praskę, wymieszać z posiekanymi listkami rozmarynu, solą i pieprzem.");
                        System.Console.WriteLine("3) Układać plasterki batatów w naczyniu, na zakładkę. Po 3 - 4 warstwach posypać mieszanką rozmarynu i czosnku i znów ułożyć 3 - 4 warstwy batatów. Zalać całość śmietanką.");
                        System.Console.WriteLine("4) Przykryć folią aluminiową i piec przez 45 minut, zdjąć folię i zapiekać jeszcze przez 15 minut. Udekorować rozmarynem, posypać ostrą papryką.");
                        break;
                    }

                    else
                    {
                        System.Console.WriteLine("Nie było takiej potrawy na liście!");
                    }
                System.Console.WriteLine("Wpisz ponownie pierwszy człon nazwy potrawy!");
                odp = Console.ReadLine();

            }
        }

        public List<string> list_products;



        
        
       
       
        
        
        
    }
    
}