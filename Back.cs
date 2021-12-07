using System;
using System.Collections.Generic;

namespace App
{
    public class Back 
    {
        public Back()
        {
            list_products = new List<string>();
        }
        Carbonara carbonara = new Carbonara();
        KurczakZRyzem kurczakZRyzem = new KurczakZRyzem();
        MakaronZKurkami makaronZKurkami = new MakaronZKurkami();
        SpaghettiBolognese spaghettiBolognese = new SpaghettiBolognese();
        WarzywneCurry warzywneCurry = new WarzywneCurry();
        SalatkaZAwokado salatkaZAwokado = new SalatkaZAwokado();
        GratinZBatatow gratinZBatatow = new GratinZBatatow();

        public void AddProducts(string ingridients)
        {
            list_products.Add(ingridients);
        }

        public void TakeIngridients()
        {
            System.Console.WriteLine("Wypisz produkty spozywcze, które posiadasz:");
            System.Console.WriteLine("(Jezeli skończysz wpisywać produkty, wpisz 'Q' aby zakończyć i przejśc dalej)");
    
            bool flag = true;
            while(flag == true)
            {
                string input;
                string ingridiends = Console.ReadLine();
                input = ingridiends.ToLower();
                this.AddProducts(input);
                if(input == "q")
                break;
            }
        }

        int a =0,b =0,c =0,d =0,e =0,f=0,g=0;
        int parametr = 0; 
        int wybor0 = 0;
        public void LookingForRecipies(string nazwa, int parametr, List<string> lista, List<string> pasujace)
        {
            
           foreach(var item in list_products)
            {
                
                for (int i = 0; i < lista.Count; i++)
                {
                    if(nazwa == "KURCZAK Z RYZEM")
                    a = parametr;

                    if(nazwa == "SPAGHETTI ALLA CARBONARA")
                    b = parametr;

                    if(nazwa == "MAKARON Z KURKAMI I BOCZKIEM")
                    c = parametr;

                    if( nazwa == "SPAGHETTI BOLOGNESE")
                    d = parametr;

                    if(nazwa == "WARZYWNE CURRY Z DYNIĄ, KALAFIOREM I CIECIERZYCĄ")
                    e = parametr;

                    if(nazwa == "SAŁATKA Z AWOKADO I PIECZONYCH BATATÓW")
                    f = parametr;

                    if(nazwa == "GRATIN Z BATATÓW")
                    g = parametr;
                    
                    if(item == lista[i])
                    {
                        pasujace.Add(item);
                        parametr++;
                    }
                }
            if(parametr != 0)
            {
                wybor0++;
                System.Console.WriteLine($"{wybor0}) Przepis na: {nazwa} ");
                if(parametr == 1)
                System.Console.WriteLine($"Znaleziono {parametr} pasujący składnik na {lista.Count}\n \n \n \n");
                else if(parametr > 1 && parametr < 5)
                System.Console.WriteLine($"Znaleziono {parametr} pasujące składniki na {lista.Count}\n \n \n \n");
                else
                System.Console.WriteLine($"Znaleziono {parametr} pasujących składników na {lista.Count}\n \n \n \n");
                break;
                
            }
            
        }
       
    }
    public void ShowFood()
    {
        this.LookingForRecipies("KURCZAK Z RYZEM", parametr , kurczakZRyzem.kurczakzryzem, kurczakZRyzem.pasujace_skladniki_kurczak);
        this.LookingForRecipies("SPAGHETTI ALLA CARBONARA", parametr , carbonara.spaghettiCarbonara, carbonara.pasujace_skladniki_spaghetti);
        this.LookingForRecipies("MAKARON Z KURKAMI I BOCZKIEM", parametr, makaronZKurkami.makaron_z_kurkami, makaronZKurkami.pasujace_skladniki_kurki);
        this.LookingForRecipies("SPAGHETTI BOLOGNESE", parametr , spaghettiBolognese.bolognese , spaghettiBolognese.pasujace_bolognese);
        this.LookingForRecipies("WARZYWNE CURRY Z DYNIĄ, KALAFIOREM I CIECIERZYCĄ", parametr , warzywneCurry.curry, warzywneCurry.pasujace_curry);
        this.LookingForRecipies("SAŁATKA Z AWOKADO I PIECZONYCH BATATÓW", parametr, salatkaZAwokado.avocado, salatkaZAwokado.pasujace_avocado);
        this.LookingForRecipies("GRATIN Z BATATÓW", parametr , gratinZBatatow.batat, gratinZBatatow.pasujace_batat);
    }

    int wybor = 0;
    public void CompareIngredients(string nazwa, int parametr, List<string> pasujaceSkladniki)
    {
        if(parametr > 0)
            {
                wybor++;
                System.Console.Write($" \n{wybor}) Pasujące składniki do potrawy {nazwa} to: ");

                for (int i = 0; i < pasujaceSkladniki.Count; i++)
                {
                    System.Console.Write($" {pasujaceSkladniki[i]}");
                }
                System.Console.WriteLine("\n");
            }
    }
          public void ShowIngredients()
        {  
            bool stop = false;
            while(stop == false)
            {
                string input;
                stop = true;
                System.Console.WriteLine("Odpowiedz: tak/nie: ");
                string odp0 = Console.ReadLine();
                input =  odp0.ToLower();
                if(input == "tak")
                {
                    this.CompareIngredients("KURCZAK Z RYZEM", a , kurczakZRyzem.pasujace_skladniki_kurczak);
                    this.CompareIngredients("SPAGHETTI ALLA CARBONARA", b , carbonara.pasujace_skladniki_spaghetti);
                    this.CompareIngredients("MAKARON Z KURKAMI I BOCZKIEM", c , makaronZKurkami.pasujace_skladniki_kurki);
                    this.CompareIngredients("SPAGHETTI BOLOGNESE", d , spaghettiBolognese.pasujace_bolognese);
                    this.CompareIngredients("WARZYWNE CURRY Z DYNIĄ, KALAFIOREM I CIECIERZYCĄ", e , warzywneCurry.pasujace_curry);
                    this.CompareIngredients("SAŁATKA Z AWOKADO I PIECZONYCH BATATÓW", f , salatkaZAwokado.pasujace_avocado);
                    this.CompareIngredients("GRATIN Z BATATÓW", g , gratinZBatatow.pasujace_batat);
                    break;
                }
                if(input == "nie")
                {
                    stop = true;
                }
                else
                {
                    stop = false;
                }
            }
        }   
        public void ShowRecipes(string odp)
        {

            wybor =1;
            bool end = true;
            while(end == true)
            {       int input;
                    input = int.Parse(odp);
                    if(a > 0 && input == wybor)
                    {
                        System.Console.WriteLine("\n");
                        kurczakZRyzem.ShowIngredients();
                        kurczakZRyzem.ShowRecipies();
                        break;
                    }
                    else if( a > 0)
                    {
                        wybor++;
                    }
                    if(b > 0 && input == wybor)
                    {
                        System.Console.WriteLine("\n");
                        carbonara.ShowIngredients();
                        carbonara.ShowRecipies();
                        break;
                    }
                    else if( b > 0)
                    {
                        wybor++;
                    }
                    if(c > 0 && input == wybor)
                    {
                        System.Console.WriteLine("\n");
                        makaronZKurkami.ShowIngredients();
                        makaronZKurkami.ShowRecipies();
                        break;
                    }
                    else if( c > 0)
                    {
                        wybor++;
                    }
                    if(d > 0 && input == wybor)
                    {
                        System.Console.WriteLine("\n");
                        spaghettiBolognese.ShowIngredients();
                        spaghettiBolognese.ShowRecipies();
                        break;
                    }
                    else if( d > 0)
                    {
                        wybor++;
                    }
                    if(e > 0 && input == wybor)
                    {
                        System.Console.WriteLine("\n");
                        warzywneCurry.ShowIngredients();
                        warzywneCurry.ShowRecipies();
                        break;
                    }
                    else if( e > 0)
                    {
                        wybor++;
                    }
                    if(f > 0 && input == wybor)
                    {
                        System.Console.WriteLine("\n");
                        salatkaZAwokado.ShowIngredients();
                        salatkaZAwokado.ShowRecipies();
                        break;
                    }
                    else if( f > 0)
                    {
                        wybor++;
                    }
                    if(g > 0 && input == wybor)
                    {   
                        System.Console.WriteLine("\n");
                        gratinZBatatow.ShowIngredients();
                        gratinZBatatow.ShowRecipies();
                        break;
                    }
                    else if( g > 0)
                    {
                        wybor++;
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