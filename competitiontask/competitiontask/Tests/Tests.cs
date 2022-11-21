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
    

    [TestFixture]
        internal class Test : Global.Base
        {


        ManageListings manageListingsObj;

            [Category("Sprint1")]
            [Test, Order(1)]
            public void TC1_EnterShareSkill()
            {
                test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
                manageListingsObj = new ManageListings();
                manageListingsObj.AddShareSkill(2, "ManageListings");

            }
            [Test, Order(2)]
            public void Tc2_ValidateEnterListings()
            {
                test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
                manageListingsObj = new ManageListings();
            manageListingsObj.ValidateListings(2, "ManageListings");
            }


            [Test, Order(3)]
            public void TC3_EditShareSkill()
            {
                test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
                manageListingsObj = new ManageListings();
                manageListingsObj.EditListings(2, 3, "ManageListings");

            }
            [Test, Order(4)]
            public void TC4_ValidateEditListings()
            {
                test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
                manageListingsObj = new ManageListings();
                manageListingsObj.ValidateListings(3, "ManageListings");
            }
            [Test, Order(5)]
            public void TC5_DeleteListings()
            {

                test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
                manageListingsObj = new ManageListings();
                manageListingsObj.DeleteListings(3, "ManageListings");
            }

            [Test, Order(6)]
            public void TC6_ValidateDeleteListings()
            {
                test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
                manageListingsObj = new ManageListings();
                manageListingsObj.ValidateDelete(3, "ManageListings");
            }

            [Test, Order(7)]
            public void TC7_InvaidTest1()
            {
               test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
               manageListingsObj = new ManageListings();
            manageListingsObj.InvalidTestListings1(2, 3, "InvalidTest");
            }

            [Test, Order(8)]
            public void TC8_InvalidTest2()
            { 
               test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
                manageListingsObj = new ManageListings();
               manageListingsObj.InvalidTestListings2(4, 5, "InvalidTest");
            }




























        //    ManageListings manageListingObj;
        //public Tests()
        //{
        //    manageListingObj = new ManageListings();
        //}
        //[Test, Order(1)]
        //public void EnterShareSkill()
        //{
        //    test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        //    manageListingObj.AddListing();
        //    verifyAddListing();
        //}
        //[Test,Order(2)]
        //public void ViewListing()
        //{
        //    test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        //    manageListingObj.ViewListing();
        //    verifyAddListing();
        //}

        //[Test,Order(3)]
        //public void EditListing()
        //{
        //    test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        //    manageListingObj.EditListing();
        //    verifyEditListing();
        //}
        //[Test,Order(4)]
        //public void DeleteListing()
        //{
        //    test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        //    manageListingObj.DeleteListing();
        //    verifyEditListing();
        //}

        //public void verifyEditListing()
        //{
        //    test = extent.CreateTest(TestContext.CurrentContext.Test.Name);

        //}


        //public void verifyAddListing()
        //{
        //    test = extent.CreateTest(TestContext.CurrentContext.Test.Name);

        //    //Assert.AreEqual(epxectedResult, ActualResult, "expected result and actual result do not match");

        //}

    }
}




