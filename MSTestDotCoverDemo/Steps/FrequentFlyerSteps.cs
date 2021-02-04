using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestDotCoverDemo.Models;
using MSTestDotCoverDemo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MSTestDotCoverDemo.Steps
{
    [Binding]
    [TestClass]
    public class FrequentFlyerSteps
    {
        FrequentFlyerService svc = new FrequentFlyerService();

        [DataRow("Adam")]
        [DataTestMethod]
        [Given(@"user ""(.*)"" is not a Frequent Flyer member")]
        public void GivenUserIsNotAFrequentFlyerMember(string userName)
        {
            Response res = svc.IsUserFrequentFlyer(userName);
            Assert.AreEqual(res.StatusCode, 404);
        }

        [DataRow("Adam")]
        [DataTestMethod]
        [When(@"user ""(.*)"" registers on the Frequent Flyer program")]
        public void WhenUserRegistersOnTheFrequentFlyerProgram(string userName)
        {
            UserDetails user = svc.AddUser(userName);
            Assert.IsNotNull(user);
        }

        [DataRow("Adam")]
        [DataTestMethod]
        [Then(@"user ""(.*)"" should have a status of BRONZE")]
        public void ThenUserShouldHaveAStatusOfBRONZE(string userName)
        {
            string status = svc.GetStatus(userName);
            Assert.AreEqual(status, "Bronze");

        }

        [DataRow("William")]
        [DataTestMethod]
        [Given(@"""(.*)"" is a FrequentFlyer member")]
        public void GivenIsAFrequentFlyerMember(string userName)
        {
            Response res = svc.IsUserFrequentFlyer(userName);
            Assert.AreEqual(res.StatusCode, 200);
        }

        [DataRow("William",90)]
        [DataTestMethod]
        [Given(@"""(.*)"" has ""(.*)"" status points")]
        public void GivenHasStatusPoints(string userName, int points)
        {
            UserDetails data = svc.userDetails.Where(x => x.Name == userName && x.RewardPoints == points).FirstOrDefault();
            Assert.IsNotNull(data);
        }

        [DataRow("William",100)]
        [DataTestMethod]
        [When(@"""(.*)"" earns ""(.*)"" extra status points")]
        public void WhenEarnsExtraStatusPoints(string userName, int points)
        {
            var obj = svc.AddEarnPoints(userName, points);
        }

        [DataRow("Platinum")]
        [DataTestMethod]
        [Then(@"he should have a status of ""(.*)""")]
        public void ThenHeShouldHaveAStatusOf(string status)
        {
            string updatedStatus = svc.GetStatus("William");
            Assert.AreEqual(updatedStatus, status);

        }
    }
}
