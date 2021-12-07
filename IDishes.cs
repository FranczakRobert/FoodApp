using System;
using System.Collections.Generic;

namespace App
{
    interface  IDishes
    {
        string name {get; set;}
        string recipe {get; set;}
        string ingridiends {get; set;}

        void ShowRecipies();
        void ShowIngridiens();

    }
}
