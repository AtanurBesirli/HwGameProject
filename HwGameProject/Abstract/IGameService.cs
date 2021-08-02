using HwGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGameProject.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Remove(Game game);
    }
}
