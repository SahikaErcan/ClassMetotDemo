using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign has been deleted.");
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign has been added.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign has been updated.");
        }
    }
}
