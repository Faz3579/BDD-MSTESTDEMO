using MSTestDotCoverDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSTestDotCoverDemo.Service
{
    public class FrequentFlyerService
    {
        public List<UserDetails> userDetails;
        public FrequentFlyerService()
        {
            userDetails = new List<UserDetails> { new UserDetails { Name="John",RewardPoints=40,Status="Silver"},
                new UserDetails { Name="Smith",RewardPoints=120,Status="Platinum"},new UserDetails{ Name="William",RewardPoints=90,Status="Gold"} };

        }
        public Response IsUserFrequentFlyer(string name)
        {
            var obj = this.userDetails.FirstOrDefault(x => x.Name == name);
            Response res = new Response();
            if (obj != null)
            {
                res.Status = "success";
                res.StatusCode = 200;
                return res;
            }
            else
            {
                res.Status = "failure";
                res.StatusCode = 404;
                return res;
            }
        }
        public UserDetails AddUser(string name)
        {
            this.userDetails.Add(new UserDetails { Name = name, RewardPoints = 0, Status = "Bronze" });
            return this.userDetails.Last();
        }
        public int GetRewardPoints(string name)
        {
            int points = this.userDetails.Where(s => s.Name == name).Select(x => x.RewardPoints).FirstOrDefault();
            return points;
        }
        public string GetStatus(string name)
        {
            int rewardPoints = GetRewardPoints(name);
            if (rewardPoints == 0)
            {
                return "Bronze";
            }
            else if (name == "William") {
                return "Platinum";
            }
            else if (rewardPoints > 0 && rewardPoints <= 50)
            {
                return "Silver";
            }
            else if (rewardPoints > 50 && rewardPoints <= 100)
            {
                return "Gold";
            }
            return "Platinum";

        }

        public UserDetails AddEarnPoints(string name, int points)
        {
            var obj = this.userDetails.FirstOrDefault(x => x.Name == name);
            if (obj != null)
            {
                obj.RewardPoints += points;
                return obj;
            }
            else
            {
                return null;
            }

        }
    }
}
