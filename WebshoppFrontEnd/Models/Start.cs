using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebbshopFrontEnd.Controllers;
using WebbshopFrontEnd.Views;

namespace WebbshopFrontEnd.Models
{
    public class Start
    {
        public void RunStart()
        {
            LoginController.SignIn();
        }
    }
}
