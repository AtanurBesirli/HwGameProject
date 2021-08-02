using System;
using System.Collections.Generic;
using System.Text;

namespace HwGameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Kampanya Kaldırıldı");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Yenilendi");
        }
    }
}
