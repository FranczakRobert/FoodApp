using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Back back = new Back();
            back.TakeIngridients();
            back.ShowFood();
            System.Console.WriteLine("Czy chcesz zobaczyc które z podanych przez Ciebie składników pasują do poszczególnych potraw?");
            back.ShowIngredients();
            System.Console.WriteLine("Wpisz nazwę potrawy (bez polskich znaków), aby wyświetlić jej przygotowanie:");
            string odp = Console.ReadLine();
            back.ShowRecipes(odp);
            
            
        }
    }
}
