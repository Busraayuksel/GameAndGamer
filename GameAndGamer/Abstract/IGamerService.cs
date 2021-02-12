using GameAndGamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAndGamer.Abstract
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
    }
}
