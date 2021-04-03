
namespace WebshoppFrontEnd
{
    using Inlämning2.Database;
    using System;
    using WebbshopFrontEnd.Controllers;
    using WebbshopFrontEnd.Models;

    static class Program
    {
        static void Main(string[] args)
        {
            Seeder.Seed();
            Start.RunStart();
        }
    }
}
