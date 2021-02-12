using GameAndGamer.Abstract;
using GameAndGamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAndGamer.Concrete
{
    class IUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.FirstName == "Büşra" && gamer.LastName == "Yüksel" && gamer.DateOfBirth == "01.11.2001" && gamer.NationaltyNumber == "111111111111")
            {
                return true;               
            }
            if (gamer.Id == 2 && gamer.FirstName == "Ayşe" && gamer.LastName == "Yılmaz" && gamer.DateOfBirth == "13.12.1999" && gamer.NationaltyNumber == "2222222222")
            {
                return true;
            }
            else
            {
                return false;
            }         
        }
    }
}
