using GameAndGamer.Concrete;
using GameAndGamer.Entities;
using System;

namespace GameAndGamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { Id = 123, GameName = "Pubg", GameCategory = "Savaş" };
            Game game2 = new Game() { Id = 123, GameName =" Satranç", GameCategory = "Zeka" };
            Game game3 = new Game() { Id = 123, GameName = "City Island", GameCategory = "Şehir Kurma" };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            Console.WriteLine("------------------");

            GamerManager gamerManager1 = new GamerManager(new IUserValidationManager());
            Gamer gamer1 = new Gamer() { Id = 1, FirstName = "Büşra", LastName = "Yüksel", DateOfBirth = "01.11.2001", NationaltyNumber = "111111111111" };
            GamerManager gamerManager2 = new GamerManager(new IUserValidationManager());
            Gamer gamer2 = new Gamer() { Id = 2, FirstName = "Ayşe", LastName = "Yılmaz", DateOfBirth = "13.12.1999", NationaltyNumber = "22222222222" };

            Console.WriteLine("------------------");

            Campaign campaign1 = new Campaign() { CampaignName = "Yeni üyeye özel", Discount = 10 };
            Campaign campaign2 = new Campaign() { CampaignName = "Yeni yıla özel", Discount = 5 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);

            Console.WriteLine("------------------");

            Console.WriteLine(gamer1.FirstName + " " + gamer1.LastName + "'in bilgilerini Konrol etme tamamlandı");
            Console.WriteLine(gamer2.FirstName + " " + gamer2.LastName + "'in bilgilerini Konrol etme tamamlandı");

            Console.WriteLine("------------------");

            SaleManager saleManager = new SaleManager();
            saleManager.CampaignSale(game1,gamer1,campaign1);
            saleManager.Sale(game3,gamer2);
        }
    }
}
