using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.FirstName = "Şahika";
            gamer.LastName = "Ercan";
            gamer.NationalityId = "15874525213";
            gamer.DateOfBirth= 1993;
 
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Save(gamer);
            gamerManager.Delete(gamer);
            gamerManager.Update(gamer);

            Game game = new Game();
            game.GameId = 1;
            game.GameName = "Game1";
            game.GamePrice = 100;

            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Delete(game);
            gameManager.Update(game);

            Campaign campaign = new Campaign();
            campaign.CampaignId = 1;
            campaign.CampaignName = "Discount 20";
            campaign.DiscountRate = 20;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Save(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game, gamer);
            salesManager.CampaignSales(game, gamer, campaign);

            Console.ReadKey();
        }
    }
}
