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
    public static class AdminChoiceController
    {
        public static WebbShopAPI api = new WebbShopAPI();
        
        public static void AdminMenuChoice(int adminId, int choice)
        {
            switch (choice)
            {
                case 1:
                    AdminBookMenu.ShowBookMenu(adminId);
                    break;

                case 2:
                    AdminCatMenu.ShowCatMenu(adminId);
                    break;
                
                case 3:
                    AdminUserMenu.ShowUserMenu(adminId);
                    break;
                
                case 4:
                    Message.SignOut();
                    api.LogOut(adminId);
                    break;

                default:
                    Message.ErrorInput();
                    break;
            }
        }

        public static void BookMenuChoice(int adminId, int choice)
        {
            switch (choice)
            {
                case 1:
                    AdminBookController.AddBook(adminId);
                    break;

                case 2:
                    AdminBookController.SetAmountBooks(adminId);
                    break;

                case 3:
                    AdminBookController.UpdateBook(adminId);
                    break;

                case 4:
                    
                    break;

                case 5:
                    AdminViews.AdminMenu(adminId);
                    break;

                default:
                    Message.ErrorInput();
                    break;
            }
        }
    }
}
