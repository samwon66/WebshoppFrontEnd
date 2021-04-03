using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebbshopFrontEnd.Views
{
    public static class Message
    {
        public static void ErrorInput() { Console.WriteLine("Ogiltig inmatning, var god och försöka igen."); }

        public static void SignOut() { Console.WriteLine("Du loggar ut nu."); }

        public static void BookNotExisted() { Console.WriteLine("Boken hittas inte."); }
    }
}

