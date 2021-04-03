using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebbshopFrontEnd.Views
{
    public static class StartView
    {
         public static void StartMenu()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("*   Välkommen till vår webbshop  *");
            Console.WriteLine("**********************************\n");
            Console.WriteLine("För att utnyttja vår webbshop, måste du vara inloggad.");
            Console.WriteLine("Tryck enter för att fortsätta.");
            Console.ReadKey();



        }
    }
}
