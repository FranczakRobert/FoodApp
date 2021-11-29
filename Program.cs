using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products();
            Back back = new Back();
            back.TakeIngridients();
            back.Compare();
            System.Console.WriteLine("Czy chcesz zobaczyc które z podanych przez Ciebie składników pasują do poszczególnych potraw?");
            string odp0 = Console.ReadLine();
            back.Show(odp0);
            System.Console.WriteLine("Napisz pierwszy człon (słowo) potrawy, aby wyświetlić jej przygotowanie:");
            string odp = Console.ReadLine();
            products.ShowRecipes(odp);
            
            
        }
    }
}
