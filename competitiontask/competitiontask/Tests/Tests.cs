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
        [Test, Order(1)]
        public void EnterShareSkill()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            manageListingObj.AddListing();
            verifyAddListing();
        }
        [Test,Order(2)]
        public void ViewListing()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            manageListingObj.ViewListing();
            verifyAddListing();
        }

        [Test,Order(3)]
        public void EditListing()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            manageListingObj.EditListing();
            verifyEditListing();
        }
        [Test,Order(4)]
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
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Assert.AreEqual(epxectedResult, ActualResult, "expected result and actual result do not match");

        }

    }
}




