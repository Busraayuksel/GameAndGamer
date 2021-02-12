using GameAndGamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAndGamer.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
