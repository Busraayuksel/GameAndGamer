using GameAndGamer.Abstract;
using GameAndGamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAndGamer.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationManager _userValidationManager;
        public GamerManager(IUserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationManager.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt işlemi tamamlandı.");
            }
            else
            {
                Console.WriteLine("Kayıt işlemi başarısız.");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
