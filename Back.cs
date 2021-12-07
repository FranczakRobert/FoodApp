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
        public void Compare(string nazwa, int parametr, List<string> lista, List<string> pasujace)
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
                System.Console.WriteLine($"Przepis na: {nazwa} ");
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
        this.Compare("KURCZAK Z RYZEM", parametr , kurczakZRyzem.kurczakzryzem, kurczakZRyzem.pasujace_skladniki_kurczak);
        this.Compare("SPAGHETTI ALLA CARBONARA", parametr , carbonara.spaghettiCarbonara, carbonara.pasujace_skladniki_spaghetti);
        this.Compare("MAKARON Z KURKAMI I BOCZKIEM", parametr, makaronZKurkami.makaron_z_kurkami, makaronZKurkami.pasujace_skladniki_kurki);
        this.Compare("SPAGHETTI BOLOGNESE", parametr , spaghettiBolognese.bolognese , spaghettiBolognese.pasujace_bolognese);
        this.Compare("WARZYWNE CURRY Z DYNIĄ, KALAFIOREM I CIECIERZYCĄ", parametr , warzywneCurry.curry, warzywneCurry.pasujace_curry);
        this.Compare("SAŁATKA Z AWOKADO I PIECZONYCH BATATÓW", parametr, salatkaZAwokado.avocado, salatkaZAwokado.pasujace_avocado);
        this.Compare("GRATIN Z BATATÓW", parametr , gratinZBatatow.batat, gratinZBatatow.pasujace_batat);
    }


    public void PasujaceSkladniki(string nazwa, int parametr, List<string> pasujaceSkladniki)
    {
        if(parametr > 0)
            {
                System.Console.Write($" \nPasujące składniki do potrawy {nazwa} to: ");

                for (int i = 0; i < pasujaceSkladniki.Count; i++)
                {
                        System.Console.Write($" {pasujaceSkladniki[i]}");
                }
                System.Console.WriteLine("\n");
            }
    }
          public void Show()
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
                    this.PasujaceSkladniki("KURCZAK Z RYZEM", a , kurczakZRyzem.pasujace_skladniki_kurczak);
                    this.PasujaceSkladniki("SPAGHETTI ALLA CARBONARA", b , carbonara.pasujace_skladniki_spaghetti);
                    this.PasujaceSkladniki("MAKARON Z KURKAMI I BOCZKIEM", c , makaronZKurkami.pasujace_skladniki_kurki);
                    this.PasujaceSkladniki("SPAGHETTI BOLOGNESE", d , spaghettiBolognese.pasujace_bolognese);
                    this.PasujaceSkladniki("WARZYWNE CURRY Z DYNIĄ, KALAFIOREM I CIECIERZYCĄ", e , warzywneCurry.pasujace_curry);
                    this.PasujaceSkladniki("SAŁATKA Z AWOKADO I PIECZONYCH BATATÓW", f , salatkaZAwokado.pasujace_avocado);
                    this.PasujaceSkladniki("GRATIN Z BATATÓW", g , gratinZBatatow.pasujace_batat);
                }
                else if(input == "nie")
                {
                    break;
                }
            }
        }   
        public void ShowRecipes(string odp)
        {
            
            bool end = true;
            while(end == true)
            {       string input;
                    input = odp.ToLower();
                    if(input == "spaghetti alla carbonara")
                    {
                        
                        carbonara.ShowIngridiens();
                        carbonara.ShowRecipies();
                        break;
                    }
                    if(input == "kurczak z ryzem")
                    {
                       
                        kurczakZRyzem.ShowIngridiens();
                        kurczakZRyzem.ShowRecipies();
                        break;
                    }
                    if(input == "makaron z kurkami i boczkiem")
                    {
                        
                        makaronZKurkami.ShowIngridiens();
                        makaronZKurkami.ShowRecipies();
                        break;
                    }
                    if(input == "spaghetti bolognese")
                    {
                        
                        spaghettiBolognese.ShowIngridiens();
                        spaghettiBolognese.ShowRecipies();
                        break;
                    }
                    if(input == "warzywne curry z dynią, kalafiorem i ciecierzycą")
                    {
                        
                        warzywneCurry.ShowIngridiens();
                        warzywneCurry.ShowRecipies();
                        break;
                    }
                    if(input == "sałatka z awokado i pieczonych batatów")
                    {
                        
                        salatkaZAwokado.ShowIngridiens();
                        salatkaZAwokado.ShowRecipies();
                        break;
                    }
                    if(input == "gratin z batatów")
                    {   
                        
                        gratinZBatatow.ShowIngridiens();
                        gratinZBatatow.ShowRecipies();
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