using Inlämning2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebbshopFrontEnd.Views;
using WebbshopFrontEnd.Views.Admin;

namespace WebbshopFrontEnd.Controllers.AdminControllers
{
    public static class AdminBookController
    {
        public static WebbShopAPI api = new WebbShopAPI();

        /// <summary>
        /// Metod för att lägga till en bok.
        /// </summary>
        /// <param name="adminId"></param>
        public static void AddBook(int adminId)
        {
            api.Ping(adminId);
            Console.Write("Var god och ange bokens titel: ");
            string title = Console.ReadLine();
            Console.Write("Författare: ");
            string author = Console.ReadLine();
            Console.Write("Pris: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Antal böcker i lagret: ");
            int amount = int.Parse(Console.ReadLine());

            var newBook = api.AddBook(adminId, title, author, price, amount);
            if (!newBook) { Message.ErrorInput(); }
            Console.Clear();
        }

        /// <summary>
        /// Metod för att sätta antalet på en bok i lagret.
        /// </summary>
        /// <param name="adminId"></param>
        public static void SetAmountBooks(int adminId)
        {
            api.Ping(adminId);
            (int bookId, int amount) = AdminBookMenu.AmountInput();
            api.SetAmount(adminId, bookId, amount);
        }

        public static void UpdateBook(int adminId)
        {
            api.Ping(adminId);
            (int bookId, string title, string author, int price) = AdminBookMenu.UpdateBookInput();
            api.UpdateBook(adminId, bookId, title, author, price);
        }
    }
}
