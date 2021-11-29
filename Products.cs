using System;
using System.Collections.Generic;
namespace App
{
    public class Products
    {
        public Products()
        {
            list_products = new List<string>();
            spaghettiCarbonara = new List<string>();
            kurczakzryzem = new List<string>();
            makaron_z_kurkami = new List<string>();
            bolognese = new List<string>();
            ciecierzyca = new List<string>();

            pasujace_skladniki_kurki = new List<string>();
            pasujace_skladniki_kurczak = new List<string>();
            pasujace_skladniki_spaghetti = new List<string>();
            pasujace_bolognese = new List<string>();
            pasujace_ciecierzyca = new List<string>();

            //spaghetti carbonara
            spaghettiCarbonara.Add("makaron");
            spaghettiCarbonara.Add("smietana");
            makaron_z_kurkami.Add("śmietana");
            spaghettiCarbonara.Add("parmezan");
            spaghettiCarbonara.Add("jajka");
            spaghettiCarbonara.Add("boczek");
            
            //Kurczak z ryzem
            kurczakzryzem.Add("ryz");
            kurczakzryzem.Add("oliwa");
            kurczakzryzem.Add("kurczak");
            kurczakzryzem.Add("cebula");
            kurczakzryzem.Add("papryka");

            //Makaron z kurkami
            makaron_z_kurkami.Add("kurki");
            makaron_z_kurkami.Add("grzyby");
            makaron_z_kurkami.Add("makaron");
            makaron_z_kurkami.Add("smietana");
            makaron_z_kurkami.Add("śmietana");
            makaron_z_kurkami.Add("boczek");

            //Bolognese
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

            //WARZYWNE CURRY Z DYNIĄ, KALAFIOREM I CIECIERZYCĄ
            ciecierzyca.Add("dynia");
            ciecierzyca.Add("imbir");
            ciecierzyca.Add("kalafior");
            ciecierzyca.Add("passa pomidorowa");
            ciecierzyca.Add("ciecierzyca");
            ciecierzyca.Add("mleko kokosowe");

        }

        public void AddProducts(string ingridients)
        {
            list_products.Add(ingridients);
        }

        public void ShowRecipes(string odp)
        {
            bool end = true;
            while(end == true)
            {

                    if(odp == "spaghetti")
                    {
                        System.Console.WriteLine("SPAGHETTI ALLA CARBONARA");
                        System.Console.WriteLine("Oryginalny włoski przepis na makaron carbonara z boczkiem i sosem na bazie jajek. Prawdziwa carbonara nie zawiera śmietanki! \n");
                        System.Console.WriteLine("SKŁADNIKI: ");
                        System.Console.WriteLine("2 jajka");
                        System.Console.WriteLine("100 g boczku (wędzonego lub suszonego - pancetty)");
                        System.Console.WriteLine("150 g makaronu spaghetti");
                        System.Console.WriteLine("2 ząbki czosnku");
                        System.Console.WriteLine("2 łyżki drobno posiekanej natki pietruszki");
                        System.Console.WriteLine("30 g sera Pecorino (lub Parmezanu lub Grana Padano)");
                        System.Console.WriteLine("sól i świeżo zmielony czarny pieprz \n \n");
                        System.Console.WriteLine("PRZYGOTOWANIE ");
                        System.Console.WriteLine(" 1) Makaron ugotować al dente w osolonej wodzie. Jajka sparzyć wrzątkiem, wbić do głębokiego talerza, doprawić solą i roztrzepać widelcem.");
                        System.Console.WriteLine(" 2) Na patelnię włożyć pokrojony w kosteczkę boczek i podsmażyć na małym ogniu przez kilka minut aż się lekko zrumieni. Dodać starty czosnek oraz posiekaną natkę pietruszki i smażyć jeszcze przez kilkanaście sekund.");
                        System.Console.WriteLine("3) Trzymając patelnię na małym ogniu dodać makaron i wymieszać. Odstawić z ognia, dodać połowę sera i doprawić świeżo zmielonym pieprzem.");
                        System.Console.WriteLine("4) Makaron polać roztrzepanymi jajkami i wymieszać. Jajka nie mogą całkowicie się ściąć, mają utworzyć kremowy sos i tylko trochę zgęstnieć od gorącego makaronu.");
                        System.Console.WriteLine(" 5) Wyłożyć na talerze i posypać pozostałym serem.");
                        break;
                    }
                    if(odp == "kurczak")
                    {
                        System.Console.WriteLine("KURCZAK Z RYZEM");
                        System.Console.WriteLine("Ryż z kurczakiem jest to również dobry pomysł na obiad poza domem. Spokojnie możemy zrobić ten posiłek rano, spakować do pudełka i skonsumować za kilka godzin! \n");
                        System.Console.WriteLine("SKŁADNIKI: ");
                        System.Console.WriteLine("200g ryzu");
                        System.Console.WriteLine("oliwa z oliwek");
                        System.Console.WriteLine("olej");
                        System.Console.WriteLine("papryka w prosku");
                        System.Console.WriteLine("200g piersi z kurczaka");
                        System.Console.WriteLine("przyprawy (sól, pieprz)");
                        System.Console.WriteLine("2 papryki");
                        System.Console.WriteLine("1 cebula");
                        System.Console.WriteLine("200g kukurydzy \n \n");
                        System.Console.WriteLine("PRZYGOTOWANIE ");
                        System.Console.WriteLine("1. Zaczynamy od ugotowania ryżu zgodnie z instrukcją podaną na opakowaniu.");
                        System.Console.WriteLine("2. Mięso dokładnie myjemy i osuszamy na ręczniku papierowym. Kroimy w drobną kosteczkę.");
                        System.Console.WriteLine("3. Mięso przekładamy do miski i posypujemy wybranymi przez siebie przyprawami. My doprawiliśmy je papryką w proszku i solą.");
                        System.Console.WriteLine("4. Smażymy mięso na oleju. Raz na jakiś czas mieszamy.");
                        System.Console.WriteLine("5. W tym czasie, myjemy i kroimy warzywa. Paprykę i cebulę kroimy w kostkę, a kukurydzę odsączamy (jeżeli była w puszcze).");
                        System.Console.WriteLine("6. Na patelnię wylewamy kilka kropel oliwy z oliwek. Wrzucamy tam cebulę i smażymy chwilę, aż lekko się nie zeszkli. Po tym czasie wrzucamy pozostałe warzywa. Możemy doprawić je solą i pieprzem.");
                        System.Console.WriteLine("7. Kiedy ryż już się ugotuje przesypujemy go do miski. Wrzucamy tam ugotowane warzywa i mięso i całość mieszamy. Mozemy podawać na talerz.");
                        System.Console.WriteLine("8. Inną propozycją podania jest wyłożenie na talerz ryżu i nasypania na wierzch warzyw i mięsa.");
                        break;
                    }
                    if(odp == "kurki")
                    {
                        System.Console.WriteLine("MAKARON Z KURKAMI I BOCZKIEM");
                        System.Console.WriteLine("Makaron z kurkami w sosie śmietanowym to punkt obowiązkowy jakże krótkiego sezonu na kurki. Jego przygotowanie trwa tyle, co czas gotowania makaronu");
                        System.Console.WriteLine("SKŁADNIKI: ");
                        System.Console.WriteLine("250 g świeżych kurek");
                        System.Console.WriteLine("250 g boczku wędzonego");
                        System.Console.WriteLine("1 cebula");
                        System.Console.WriteLine("250 ml śmietany 18%");
                        System.Console.WriteLine("300 g makaronu");
                        System.Console.WriteLine("odrobina masła\n\n");
                        System.Console.WriteLine("PRZTGOTOWANIE: ");
                        System.Console.WriteLine("1) Makaron gotujemy al dente, a cebulę pokrojoną w drobną kostkę podsmażany na odrobinie masła. Do zeszklonej cebulki należy dodać boczek i całość chwilę przesmażyć. ");
                        System.Console.WriteLine("2) Następnie do sosu dodajemy kurki, a po chwili również śmietaną. Co ważne, śmietanę mieszamy wcześniej w 2 łyżkami z wody od makaronu. Całość mieszamy do połączenia. Sos przyprawiamy na patelni solą i pieprzem. Dodajemy ugotowany makaron.");
                        break;
                    }
                    if(odp == "bolognese")
                    {
                        System.Console.WriteLine("SPAGHETTI BOLOGNESE");
                        System.Console.WriteLine("SKŁADNIKI: ");
                        System.Console.WriteLine("150 g boczku");
                        System.Console.WriteLine("1 cebula");
                        System.Console.WriteLine("2 łodygi selera naciowego");
                        System.Console.WriteLine("1 marchewka");
                        System.Console.WriteLine("2 łyżki oliwy");
                        System.Console.WriteLine("500 g mielonego mięsa");
                        System.Console.WriteLine("1 szklanka czerwonego wina");
                        System.Console.WriteLine("1 szklanka gorącego bulionu");
                        System.Console.WriteLine("4 łyżki koncentratu pomidorowego");
                        System.Console.WriteLine("1 puszka obranych pomidorów");
                        System.Console.WriteLine("1/2 szklanki mleka");
                        System.Console.WriteLine("makaron spaghetti (75 g / porcję)");
                        System.Console.WriteLine("tarty parmezan\n\n");
                        System.Console.WriteLine("PRZYGOTOWANIE: ");
                        System.Console.WriteLine("1) Boczek pokroić w drobną kostkę i włożyć na dużą patelnię, ");
                        System.Console.Write("wytopić na małym ogniu aż się zrumieni. Przesunąć na bok, w wytopiony ");
                        System.Console.Write("tłuszcz włożyć drobno posiekaną cebulę i zeszklić. Dodać drobno posiekany");
                        System.Console.Write(" seler naciowy i startą marchewkę. Obsmażyć, następnie wszystko przełożyć do garnka.");
                        System.Console.WriteLine("2) Na patelnię wlać oliwę i obsmażyć mięso. Obsmażone mięso przełożyć do garnka z boczkiem");
                        System.Console.Write(" i warzywami. Wlać wino i gotować mieszając ok. 5 minut. Dodać gorący bulion i koncentrat pomidorowy,");
                        System.Console.Write(" wymieszać. Dodać pomidory z puszki, doprawić solą i pieprzem. Drewnianą łyżką rozdrobnić pomidory i wymieszać.");
                        System.Console.WriteLine("3) Przykryć i gotować na małym ogniu przez minimum 2 godziny, od czasu do czasu mieszając.");
                        System.Console.Write(" W połowie gotowania dodać mleko. Podawać z ugotowanym makaronem spaghetti posypując tartym parmezanem.");
                        System.Console.WriteLine();
                        break;
                    }
                    if(odp == "ciecierzyca")
                    {
                        System.Console.WriteLine("WARZYWNE CURRY Z DYNIĄ, KALAFIOREM I CIECIERZYCĄ");
                        System.Console.WriteLine("SKŁADNIKI");
                        System.Console.WriteLine("300 g dyni");
                        System.Console.WriteLine("1 średnia cebula");
                        System.Console.WriteLine("1 łyżka oleju roślinnego");
                        System.Console.WriteLine("2 ząbki czosnku");
                        System.Console.WriteLine("2 cm kawałek imbiru");
                        System.Console.WriteLine("po 2 łyżeczki przyprawy curry i kurkumy");
                        System.Console.WriteLine("1 łyżeczka mielonej papryki");
                        System.Console.WriteLine("250 ml wody");
                        System.Console.WriteLine("250 ml passaty pomidorowej");
                        System.Console.WriteLine("300 g kalafiora");
                        System.Console.WriteLine("300 g ciecierzycy z puszki");
                        System.Console.WriteLine("250 ml mleka kokosowego\n\n");
                        System.Console.WriteLine("PRZYGOTOWANIE: ");
                        System.Console.WriteLine("1) Dynię obrać ze skóry i pestek, miąższ pokroić w kostkę.");
                        System.Console.WriteLine("2) Cebulę obrać i pokroić na cienkie półplasterki.");
                        System.Console.WriteLine("3) Rozgrzać olej w większym garnku, dodać cebulę i zeszklić ją.");
                        System.Console.WriteLine("4) Dodać obrany i starty czosnek oraz imbir. Mieszając smażyć przez 1 minutę.");
                        System.Console.WriteLine("5) Dodać wszystkie przyprawy, wymieszać i chwilę razem podsmażać.");
                        System.Console.WriteLine("6) Dodać wodę, passatę oraz dynię. Zagotować, doprawić solą oraz pieprzem. Gotować przez 20 minut bez przykrycia.");
                        System.Console.WriteLine("7) Dodać kalafiora (pokrojonego w kostkę lub na małe różyczki), mleko kokosowe oraz ciecierzycę wraz z częścią zalewy.");
                        System.Console.WriteLine("8) Wymieszać i gotować przez ok. 10 minut. Podawać z ugotowanym ryżem i świeżą kolendrą.");
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





        public List<string> pasujace_ciecierzyca;
        public List<string> pasujace_bolognese;
        public List<string> pasujace_skladniki_kurczak;
        public List<string> pasujace_skladniki_kurki;
        public List<string> pasujace_skladniki_spaghetti;


        public List<string> list_products;



        public List<string> ciecierzyca;
        public List<string> bolognese;
        public List<string> makaron_z_kurkami;
        public List<string> spaghettiCarbonara;
        public List<string> kurczakzryzem;

    }
    
}