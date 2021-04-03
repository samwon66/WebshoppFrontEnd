using Inlämning2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebbshopFrontEnd.Controllers.AdminControllers;

namespace WebbshopFrontEnd.Views.Admin
{
    public static class AdminBookMenu
    {
        public static WebbShopAPI api = new WebbShopAPI();

        /// <summary>
        /// Visa Admin när bokens antal ska sättas.
        /// </summary>
        /// <returns></returns>
        public static (int, int) AmountInput()
        {
            Console.Write("Ange ett sökord på bokens title som du söker: ");
            var books = api.GetBooks(Console.ReadLine());
            Console.WriteLine("Hitta följande bok/böcker");
            foreach (var b in books) { Console.WriteLine($"BokID: {b.BookId} - Titel: {b.Title}"); }
            Console.Write("Var god och ange bokens ID som du vill ändra antal: ");
            var bookId = int.Parse(Console.ReadLine());
            Console.Write("Ange vilket antal du vill ändra i lagret: ");
            var amount = int.Parse(Console.ReadLine());
            return (bookId, amount);
        }

        /// <summary>
        /// Visa meny för att ta bort en bok.
        /// </summary>
        public static void DeleteBookMenu()
        {

        }

        /// <summary>
        /// Visa admins bokmeny
        /// </summary>
        /// <param name="adminId"></param>
        public static void ShowBookMenu(int adminId)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("************************");
                Console.WriteLine("*   Adminstratörsmeny  *");
                Console.WriteLine("************************\n");
                Console.WriteLine("Du har följande val");
                Console.WriteLine("[1]  Lägg till en bok");
                Console.WriteLine("[2]  Lägg till antal böcker i lagret.");
                Console.WriteLine("[3]  Uppdatera information om en bok.");
                Console.WriteLine("[4]  Ta bort en bok.");
                Console.WriteLine("[5]  Tillbaka till adminstratörmenyn.");
            }

            try
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice == 5)
                {
                    AdminViews.AdminMenu(adminId);
                    loop = false;
                }
                else { AdminChoiceController.BookMenuChoice(adminId, choice); }
            }
            catch { Message.ErrorInput(); }
        }

        /// <summary>
        /// Visa meny för att uppdatera en bok.
        /// </summary>
        /// <returns></returns>
        public static (int, string, string, int) UpdateBookInput()
        {
            Console.Write("Ange ett sökord för boken som du vill uppdatera: ");
            var books = api.GetBooks(Console.ReadLine());
            Console.WriteLine("Hitta följande bok/böcker");
            foreach (var b in books) { Console.WriteLine($"BokID: {b.BookId} - Titel: {b.Title}"); }
            if (books.Count == 0)
            {
                Message.BookNotExisted();
                Console.Clear();
            }
            Console.Write("Var god och ange bokens ID som du vill updatera: ");
            var bookId = int.Parse(Console.ReadLine());
            Console.Write("Ange titel: ");
            var title = Console.ReadLine();
            Console.Write("Författare: ");
            var author = Console.ReadLine();
            Console.Write("Pris: ");
            var price = int.Parse(Console.ReadLine());
            return (bookId, title, author, price);

        }
    }
}
