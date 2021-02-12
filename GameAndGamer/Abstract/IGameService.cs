using GameAndGamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAndGamer.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
    }
}
