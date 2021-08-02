using System;
using System.Collections.Generic;
using System.Text;

namespace HwGameProject
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Remove(Gamer gamer);

    }
}
