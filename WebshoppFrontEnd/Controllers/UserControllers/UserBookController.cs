using Inlämning2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebbshopFrontEnd.Views;

namespace WebbshopFrontEnd.Controllers.UserControllers
{
    public static class UserBookController
    {
        public static WebbShopAPI api = new WebbShopAPI();

        /// <summary>
        /// Metod för hitta böcker i en kategori.
        /// </summary>
        /// <param name="userId"></param>
        public static void GetBooksInCat(int userId)
        {
            api.Ping(userId);

            UserCatController.ListAllCategory(userId);
            Console.Write("Var god och ange en kategori för visning: ");
            var catId = int.Parse(Console.ReadLine());
            var books = api.GetCategory(catId);
            UserView.ShowBooks(books); 
            
        }

        /// <summary>
        /// Metod för att hitta tillgängliga böcker i en kategori.
        /// </summary>
        /// <param name="userId"></param>
        public static void GetBooksAvaliable(int userId)
        {
            api.Ping(userId);

            UserCatController.ListAllCategory(userId);
            Console.Write("Vilken kategori vill du söka böcker i: ");
            var catId = int.Parse(Console.ReadLine());
            var books = api.GetAvaliableBooks(catId);
            UserView.ShowBooks(books);

        }

        public static void SearchBook(int userId)
        {
            api.Ping(userId);

            Console.Write("Var god ange ett sökord för boken som du söker: ");
            var keyword = Console.ReadLine();
            var books = api.GetBooks(keyword);
            UserView.ShowBooks(books);
            if (books.Count == 0) 
            {
                Message.BookNotExisted();
                return;
            }
            else
            {
                Console.Write("Ange bokens Id för att välja: ");
                var book = api.GetBook(int.Parse(Console.ReadLine()));
                Console.WriteLine(book.ToString()); 
            }
            
        }

        public static void SearchBookByAuthor(int userId)
        {
            api.Ping(userId);

            var books = api.GetAuthor(UserView.ShowSearchAuthor());
            UserView.ShowBooks(books);

        }
    }
}
