using HwGameProject.Concrete;
using System;

namespace HwGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { FirstName = "Kamil", LastName = "Kemir" });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign());

            GameManager gameManager = new GameManager();
            gameManager.Add(new Entities.Game());

            OrderManager orderManager = new OrderManager();
            orderManager.Sale(new Campaign());
        }
    }
}
