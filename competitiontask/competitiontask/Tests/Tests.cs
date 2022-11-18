using Competition.Global;
using Competition.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition.Tests
{
    internal class Tests : Global.Base
    {
        ManageListings manageListingObj;
        public Tests()
        {
            manageListingObj = new ManageListings();
        }
        [Test]
        public void EnterShareSkill()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            manageListingObj.AddListing();
            verifyAddListing();
        }

        [Test]
        public void EditListing()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            manageListingObj.EditListing();
            verifyEditListing();
        }
        [Test]
        public void DeleteListing()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            manageListingObj.DeleteListing();
            verifyEditListing();
        }

        public void verifyEditListing()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);

        }


        public void verifyAddListing()
        {
            //Assert.AreEqual(epxectedResult, ActualResult, "expected result and actual result do not match");

        }

    }
}




