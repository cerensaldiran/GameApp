using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine(campaign.DiscountRate+"% "+campaign.CampaignName+ " is added!"+" New Price is "+(game.GamePrice*campaign.DiscountRate/100));
        }

        public void Delete(Campaign campaign, Game game)
        {
            
        }

        public void Update(Campaign campaign, Game game)
        {
            
        }
    }
}
