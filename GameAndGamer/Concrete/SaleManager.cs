using GameAndGamer.Abstract;
using GameAndGamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAndGamer.Concrete
{
    class SaleManager : ISaleService
    {
        public void CampaignSale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + game.GameName + " " + campaign.CampaignName + " kampanyasıyla oyunu satın aldı.");
        }

        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " 'ı " + gamer.FirstName + " satın aldı.");
        }
    }
}
