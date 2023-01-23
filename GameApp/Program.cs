using System;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                Id = 1,
                Name = "Ceren",
                LastName = "Saldıran",
                BirthYear = "1999",
                NationalityId = "12121212121"
            };
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer);

            Game game = new Game()
            {
                Id = 1,
                GameName="Pubg",
                GamePrice=500
            };
            OrderManager orderManager = new OrderManager();
            orderManager.Buy(game,gamer);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign()
            {
                Id=1,
                CampaignName="Happy New Year",
                DiscountRate=50
            };

            campaignManager.Add(campaign, game);
        }
    }
}
