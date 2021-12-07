using System;
using System.Collections.Generic;

namespace App
{
    public class Back 
    {
        Carbonara carbonara = new Carbonara();
        KurczakZRyzem kurczakZRyzem = new KurczakZRyzem();
        MakaronZKurkami makaronZKurkami = new MakaronZKurkami();
        SpaghettiBolognese spaghettiBolognese = new SpaghettiBolognese();
        WarzywneCurry warzywneCurry = new WarzywneCurry();
        SalatkaZAwokado salatkaZAwokado = new SalatkaZAwokado();
        GratinZBatatow gratinZBatatow = new GratinZBatatow();
        Products products = new Products();

        int parametr = 0; 

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
                products.AddProducts(input);
                if(input == "q")
                break;
            }
        }

        int a =0,b =0,c =0,d =0,e =0,f=0,g=0;
        public void Compare(string nazwa, int parametr, List<string> lista, List<string> pasujace)
        {
            
           foreach(var item in products.list_products)
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
                    if(a > 0)
                    {
                        System.Console.Write("Pasujące składniki do potrawy KURCZAK Z RYZEM to: ");
                        for (int i = 0; i < kurczakZRyzem.pasujace_skladniki_kurczak.Count; i++)
                        {
                            System.Console.Write($" {kurczakZRyzem.pasujace_skladniki_kurczak[i]}");
                        }
                        System.Console.WriteLine("");
                    }

                    if(b > 0)
                    {
                        System.Console.Write("Pasujące składniki do potrawy SPAGHETTI ALLA CARBONARA to: ");
                        for (int i = 0; i < carbonara.pasujace_skladniki_spaghetti.Count; i++)
                        {
                            System.Console.Write($" {carbonara.pasujace_skladniki_spaghetti[i]}");
                        }
                        System.Console.WriteLine("\n\n");
                    }

                    if(c > 0)
                    {
                        System.Console.Write("Pasujące składniki do potrawy MAKARON Z KURKAMI I BOCZKIEM to: ");
                        for (int i = 0; i < makaronZKurkami.pasujace_skladniki_kurki.Count; i++)
                        {
                            System.Console.Write($" {makaronZKurkami.pasujace_skladniki_kurki[i]}");
                        }
                        System.Console.WriteLine("\n\n");
                    }
                    if(d > 0)
                    {
                        System.Console.Write("Pasujące składniki do potrawy SPAGHETTI BOLOGNESE to: ");
                        for (int i = 0; i < spaghettiBolognese.pasujace_bolognese.Count; i++)
                        {
                            System.Console.Write($" {spaghettiBolognese.pasujace_bolognese[i]}");
                        }
                        System.Console.WriteLine("\n\n");
                    }
                    if(e > 0)
                    {
                        System.Console.WriteLine("Pasujące składniki do potrawy WARZYWNE CURRY Z DYNIĄ, KALAFIOREM I CIECIERZYCĄ to: ");
                        for (int i = 0; i < warzywneCurry.pasujace_curry.Count; i++)
                        {
                            System.Console.Write($" {warzywneCurry.pasujace_curry[i]}");
                        }
                        System.Console.WriteLine("\n\n");
                    }
                    if( f > 0)
                    {
                        System.Console.WriteLine("Pasujące składniki do potrawy SAŁATKA Z AWOKADO I PIECZONYCH BATATÓW to: ");
                        for (int i = 0; i < salatkaZAwokado.pasujace_avocado.Count; i++)
                        {
                            System.Console.WriteLine($"{salatkaZAwokado.pasujace_avocado[i]}");
                        }
                        System.Console.WriteLine("\n\n");
                    }
                    if( g > 0)
                    {
                        System.Console.WriteLine("Pasujące składniki do potrawy GRATIN Z BATATÓW: ");
                        for (int i = 0; i < gratinZBatatow.pasujace_batat.Count; i++)
                        {
                            System.Console.WriteLine($"{gratinZBatatow.pasujace_batat[i]}");
                        }
                        System.Console.WriteLine("\n\n");
                    }
                }
                else if(input == "nie")
                {
                    break;
                }
            }
        }    
}
}