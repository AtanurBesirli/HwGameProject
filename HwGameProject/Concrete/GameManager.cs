using HwGameProject.Abstract;
using HwGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi");
        }

        public void Remove(Game game)
        {
            Console.WriteLine("Oyun Kaldırıldı");

        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Yenilendi");
        }
    }
}
