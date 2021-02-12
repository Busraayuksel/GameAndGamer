using GameAndGamer.Abstract;
using GameAndGamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAndGamer.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası eklendi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası güncellendi");
        }
    }
}
