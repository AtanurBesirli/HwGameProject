using System;
using System.Collections.Generic;
using System.Text;

namespace HwGameProject
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Remove(Campaign campaign);
    }
}
