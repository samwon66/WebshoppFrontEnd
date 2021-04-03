﻿using Inlämning2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebbshopFrontEnd.Views;

namespace WebbshopFrontEnd.Controllers.UserControllers
{
    public static class UserCatController
    {
        public static WebbShopAPI api = new WebbShopAPI();

        /// <summary>
        /// Metod för att lista alla kategorier.
        /// </summary>
        /// <param name="userId"></param>
        public static void ListAllCategory(int userId)
        {
            api.Ping(userId);

            var cat = api.GetCategories();
            UserView.ShowAllCategory(cat);
        }

        /// <summary>
        /// Metod för att söka kategori med sökord.
        /// </summary>
        /// <param name="userId"></param>
        public static void SearchCategories(int userId)
        {
            api.Ping(userId);

            var cat = api.GetCategories(UserView.ShowSearchCat());
            UserView.ShowAllCategory(cat);
        }
        
    }
}
