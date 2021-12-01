using System;
using System.Collections.Generic;

namespace App
{
    public class Back
    {
        Products products = new Products();
        int q = 0;
        int w = 0;
        int x = 0;
        int r = 0;
        int c = 0;
        int a = 0;
        int b = 0;

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
                    if(q > 0)
                    {
                        System.Console.Write("Pasujące składniki do potrawy KURCZAK Z RYZEM to: ");
                        for (int i = 0; i < products.pasujace_skladniki_kurczak.Count; i++)
                        {
                            System.Console.Write($" {products.pasujace_skladniki_kurczak[i]}");
                        }
                        System.Console.WriteLine("");
                    }

                    if(x > 0)
                    {
                        System.Console.Write("Pasujące składniki do potrawy SPAGHETTI ALLA CARBONARA to: ");
                        for (int i = 0; i < products.pasujace_skladniki_spaghetti.Count; i++)
                        {
                            System.Console.Write($" {products.pasujace_skladniki_spaghetti[i]}");
                        }
                        System.Console.WriteLine("\n\n");
                    }

                    if(w > 0)
                    {
                        System.Console.Write("Pasujące składniki do potrawy MAKARON Z KURKAMI I BOCZKIEM to: ");
                        for (int i = 0; i < products.pasujace_skladniki_kurki.Count; i++)
                        {
                            System.Console.Write($" {products.pasujace_skladniki_kurki[i]}");
                        }
                        System.Console.WriteLine("\n\n");
                    }
                    if(r > 0)
                    {
                        System.Console.Write("Pasujące składniki do potrawy SPAGHETTI BOLOGNESE to: ");
                        for (int i = 0; i < products.pasujace_bolognese.Count; i++)
                        {
                            System.Console.Write($" {products.pasujace_bolognese[i]}");
                        }
                        System.Console.WriteLine("\n\n");
                    }
                    if(c > 0)
                    {
                        System.Console.WriteLine("Pasujące składniki do potrawy WARZYWNE CURRY Z DYNIĄ, KALAFIOREM I CIECIERZYCĄ to: ");
                        for (int i = 0; i < products.pasujace_ciecierzyca.Count; i++)
                        {
                            System.Console.Write($" {products.pasujace_ciecierzyca[i]}");
                        }
                        System.Console.WriteLine("\n\n");
                    }
                    if( a > 0)
                    {
                        System.Console.WriteLine("Pasujące składniki do potrawy SAŁATKA Z AWOKADO I PIECZONYCH BATATÓW to: ");
                        for (int i = 0; i < products.pasujace_avocado.Count; i++)
                        {
                            System.Console.WriteLine($"{products.pasujace_avocado[i]}");
                        }
                        System.Console.WriteLine("\n\n");
                    }
                    if( b > 0)
                    {
                        System.Console.WriteLine("Pasujące składniki do potrawy GRATIN Z BATATÓW: ");
                        for (int i = 0; i < products.pasujace_batat.Count; i++)
                        {
                            System.Console.WriteLine($"{products.pasujace_batat[i]}");
                        }
                        System.Console.WriteLine("\n\n");
                    }
                }
                else if(input == "nie")
                {
                    break;
                }
                else
                {
                    stop = false;
                }
            }
        }

        public void Compare()
        {
            //Kurczak z ryzem
            foreach(var item in products.list_products)
            {
                for (int i = 0; i < products.kurczakzryzem.Count; i++)
                {
                    if(item == products.kurczakzryzem[i])
                    {
                        products.pasujace_skladniki_kurczak.Add(item);
                        q++;
                    }
                    
                }
                //Makaron z kurkami
                for (int i = 0; i < products.makaron_z_kurkami.Count; i++)
                {
                    if(item == products.makaron_z_kurkami[i])
                    {
                        products.pasujace_skladniki_kurki.Add(item);
                        w++;
                    }
                    
                }
                //Spaghetti Carbonare
                for (int i = 0; i < products.spaghettiCarbonara.Count; i++)
                {
                    if(item == products.spaghettiCarbonara[i])
                    {
                        products.pasujace_skladniki_spaghetti.Add(item);
                        x++;
                    }
                }
                //Bolognese
                for (int i = 0; i < products.bolognese.Count; i++)
                {
                    if(item == products.bolognese[i])
                    {
                        products.pasujace_bolognese.Add(item);
                        r++;
                    }
                }  
                //ciecierzyca
                for (int i = 0; i < products.ciecierzyca.Count; i++)
                {
                    if(item == products.ciecierzyca[i])
                    {
                        products.pasujace_ciecierzyca.Add(item);
                        c++;
                    }
                }
                //Avocado
                for (int i = 0; i < products.avocado.Count; i++)
                {
                    if(item == products.avocado[i])
                    {
                        products.pasujace_avocado.Add(item);
                    }
                }
                //Batat
                for (int i = 0; i < products.batat.Count; i++)
                {
                    if(item == products.batat[i])
                    {
                        products.pasujace_batat.Add(item);
                    }
                }

            }

            //Kurczak z ryzem
            int kurczak = products.kurczakzryzem.Count;
            if(q != 0)
            {
                System.Console.WriteLine("Przepis na: KURCZAK Z RYZEM ");
                if(q == 1)
                System.Console.WriteLine($"Znaleziono {q} pasujący składnik na {kurczak}\n \n \n \n");
                else if(q > 1 && q < 5)
                System.Console.WriteLine($"Znaleziono {q} pasujące składniki na {kurczak}\n \n \n \n");
                else
                System.Console.WriteLine($"Znaleziono {q} pasujących składników na {kurczak}\n \n \n \n");
            }
            //Makaron z kurkami
            int kurki = products.makaron_z_kurkami.Count;
            if(w != 0)
            {
                System.Console.WriteLine("Przepis na: MAKARON Z KURKAMI I BOCZKIEM");
                if(w == 1)
                System.Console.WriteLine($"Znaleziono {w} pasujący składnik na {kurki -2}\n \n \n \n");
                else if(w > 1 && w < 5)
                System.Console.WriteLine($"Znaleziono {w} pasujące składniki na {kurki -2}\n \n \n \n");
                else
                System.Console.WriteLine($"Znaleziono {w} pasujących składników na {kurki -2}\n \n \n \n");
            }
            //Spaghetti carbonare
            int carbonare = products.spaghettiCarbonara.Count;
            if(x != 0)
            {
                System.Console.WriteLine("Przepis na: SPAGHETTI ALLA CARBONARA");
                if(x == 1)
                System.Console.WriteLine($"Znaleziono {x} pasujący składnik na {carbonare -1}\n \n \n \n");
                else if(x > 1 && x < 5)
                System.Console.WriteLine($"Znaleziono {x} pasujące składniki na {carbonare -1}\n \n \n \n");
                else
                System.Console.WriteLine($"Znaleziono {x} pasujących składników na {carbonare -1}\n \n \n \n");
            }
            //bolognese
            int bolognese = products.bolognese.Count;
            if(r != 0)
            {
                System.Console.WriteLine("Przepis na: SPAGHETTI BOLOGNESE");
                if(r == 1)
                System.Console.WriteLine($"Znaleziono {r} pasujący składnik na {bolognese -2}\n \n \n \n");
                else if(r > 1 && r < 5)
                System.Console.WriteLine($"Znaleziono {r} pasujące składniki na {bolognese -2}\n \n \n \n");
                else
                System.Console.WriteLine($"Znaleziono {r} pasujących składników na {bolognese -2}\n \n \n \n");
            }

            //ciecierzyca
            int ciecierzca = products.ciecierzyca.Count;
            if(c != 0)
            {
                System.Console.WriteLine("Przepis na: WARZYWNE CURRY Z DYNIĄ, KALAFIOREM I CIECIERZYCĄ");
                if(c == 1)
                System.Console.WriteLine($"Znaleziono {c} pasujący składnik na {ciecierzca}\n \n \n \n");
                else if(r > 1 && r < 5)
                System.Console.WriteLine($"Znaleziono {c} pasujące składniki na {ciecierzca}\n \n \n \n");
                else
                System.Console.WriteLine($"Znaleziono {c} pasujących składników na {ciecierzca}\n \n \n \n");
            }
            //Avocado
            int avocado = products.avocado.Count;
            if( a!= 0)
            {
                System.Console.WriteLine("Przepis na: SAŁATKA Z AWOKADO I PIECZONYCH BATATÓW");
                if(a == 1)
                System.Console.WriteLine($"Znaleziono {a} pasujący składnik na {avocado}\n \n \n \n");
                else if(r > 1 && r < 5)
                System.Console.WriteLine($"Znaleziono {a} pasujące składniki na {avocado}\n \n \n \n");
                else
                System.Console.WriteLine($"Znaleziono {a} pasujących składników na {avocado}\n \n \n \n");
            }
            //Batat
            int batat = products.batat.Count;
            if(b != 0)
            {
                System.Console.WriteLine("Przepis na: GRATIN Z BATATÓW");
                if(b == 1)
                System.Console.WriteLine($"Znaleziono {b} pasujący składnik na {batat}\n \n \n \n");
                else if(r > 1 && r < 5)
                System.Console.WriteLine($"Znaleziono {b} pasujące składniki na {batat}\n \n \n \n");
                else
                System.Console.WriteLine($"Znaleziono {b} pasujących składników na {batat}\n \n \n \n");
            }
        }
    }
}