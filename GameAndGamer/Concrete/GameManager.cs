using GameAndGamer.Abstract;
using GameAndGamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAndGamer.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameCategory + " Türündeki " + game.GameName + " Oyunu Eklendi");
        }

        public void Update(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
