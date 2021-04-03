using Inlämning2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebbshopFrontEnd.Views.Admin
{
    public static class AdminCatMenu
    {
        public static WebbShopAPI api = new WebbShopAPI();
        
        public static void ShowCatMenu(int adminId)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("************************");
                Console.WriteLine("*   Adminstratörsmeny  *");
                Console.WriteLine("************************\n");
                Console.WriteLine("Du har följande val");
                Console.WriteLine("[1]  Lägg till en kategori");
                Console.WriteLine("[2]  Lägg till kategori på en bok");
                Console.WriteLine("[3]  Uppdatera kategori");
                Console.WriteLine("[4]  Ta bort kartegori som saknas böcker");
                Console.WriteLine("[5]  Tillbaka till adminstratörmenyn.");
            }
        }
    }
}
