using Inlämning2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebbshopFrontEnd.Models;
using WebbshopFrontEnd.Views;

namespace WebbshopFrontEnd.Controllers.UserControllers
{
    public static class UserChoiceController
    {
        public static WebbShopAPI api = new WebbShopAPI();

        public static void UserChoice(int userId, int choice)
        {
            switch (choice)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    Message.SignOut();
                    api.LogOut(userId);
                    //Start.RunStart();
                    break;

                default:
                    Message.ErrorInput();
                    break;
            }
        }
    }
}
