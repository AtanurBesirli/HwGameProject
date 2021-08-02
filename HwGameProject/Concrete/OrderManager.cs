using HwGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGameProject
{
    class OrderManager : Abstract.IOrderService
    {
        public void Sale(Campaign campaign)
        {
            Console.WriteLine("Oyun indirimi");
        }
    }
}
