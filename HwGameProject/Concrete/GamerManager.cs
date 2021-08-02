using System;
using System.Collections.Generic;
using System.Text;

namespace HwGameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager (IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Oyuncu Kayıt Edildi.");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Bilgileri Güncellendi.");
        }

    }
}
