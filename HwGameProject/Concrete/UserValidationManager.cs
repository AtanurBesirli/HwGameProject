using System;
using System.Collections.Generic;
using System.Text;

namespace HwGameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Kamil" && gamer.LastName=="Kemir" )
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
