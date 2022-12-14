using Competition.Global;
using OpenQA.Selenium;
using static Competition.Global.GlobalDefinitions;

namespace Competition.Pages
{
    internal class ManageListings
    {
        #region Manage listing's page objects

        //Click on Manage Listings Link
        private IWebElement manageListingsTab => driver.FindElement(By.XPath("//a[@href='/Home/ListingManagement']"));

        //View the listing
        private IWebElement viewIcon => driver.FindElement(By.XPath("(//i[@class='eye icon'])[1]"));

        //Edit the listing
        private IWebElement edit => driver.FindElement(By.XPath("(//i[@class='outline write icon'])[1]"));

        //Delete the listing
        private IWebElement delete => driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));


        //Click on Yes or No
        private IWebElement clickActionsButton => driver.FindElement(By.XPath("//div[@class='actions']"));

        //Click on Yes
        private IWebElement YesButton => driver.FindElement(By.XPath("//div[@class='actions']//button[2]"));
        #endregion

        internal void Listings()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");

        }

        public void AddShareSkill(int rowNumber, string Excelsheet)
        {
            //Get the values from shareskill
            ShareSkill shareSkillObj = new ShareSkill();
            wait(1);
            //Read date from Excel sheet
            shareSkillObj.EnterShareSkill(rowNumber, Excelsheet);
            wait(2);

        }

        public void ValidateListings(int rowNumber, string Excelsheet)
        {
            //Get the values from shareskill
            ShareSkill shareSkillObj = new ShareSkill();
            Thread.Sleep(3000);
            //Click on Manage listings tab
            manageListingsTab.Click();

            //Click on view icon
            Thread.Sleep(2000);
            viewIcon.Click();
            Thread.Sleep(2000);

            //calling the verify share skill
            shareSkillObj.ValidateShareSkill(rowNumber, Excelsheet);
            wait(2);
        }


        public void EditListings(int rowNumber1, int rowNumber3, string Excelsheet)
        {
            //Get the values from shareskill
            ShareSkill shareSkillObj = new ShareSkill();
            //Click on manage listings tab
            Thread.Sleep(2000);
            manageListingsTab.Click();

            //Populate the Excel sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath, Excelsheet);

            //Read Data from manage listings page
            string ExpectedTitle = ExcelLib.ReadData(rowNumber1, "Title");

            Thread.Sleep(2000);
            edit.Click();
            wait(1);

            shareSkillObj.EditShareSkill(rowNumber3, Excelsheet);
        }


        public void DeleteListings(int rowNumber, string Excelsheet)
        {
            //Click on Manage Listings tab
            manageListingsTab.Click();
            wait(1);

            //populate the excel sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath, Excelsheet);
            string ListingToDelete = ExcelLib.ReadData(rowNumber, "Title");

            wait(3);
            //Click on Delete Button
            clickActionsButton.Click();
            Thread.Sleep(1000);

            //Click on Yes button         
            YesButton.Click();
            Thread.Sleep(1000);
        }


        public void ValidateDelete(int rowNumber1, string Excelsheet)
        {
            //Click on Manage Listings tab
            manageListingsTab.Click();
            wait(1);
            //Populate the Excel sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath, Excelsheet);
            wait(2);
            //Read Data from manage listings page
            string ExpectedTitle = ExcelLib.ReadData(rowNumber1, "Title");

        }

        public void InvalidTestListings1(int rowNumber1, int rowNumber2, string Excelsheet)
        {
            ShareSkill shareSkillObj = new ShareSkill();

            //Populate the Excel sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath, Excelsheet);
            wait(2);
            shareSkillObj.InvalidShareskill1(rowNumber1, Excelsheet);
            wait(2);

            shareSkillObj.AssertTC1_ErrorMessage(rowNumber2);
        }

        public void InvalidTestListings2(int rowNumber1, int rowNumber2, string Excelsheet)
        {
            ShareSkill shareSkillObj = new ShareSkill();

            //Populate the Excel sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath, Excelsheet);

            wait(2);
            shareSkillObj.InvalidShareskill2(rowNumber1, Excelsheet);
            wait(2);

            shareSkillObj.AssertTC2_ErrorMessage(rowNumber2);
        }










        //ShareSkill shareSkillObj;
        //ManageListings manageListingObj;
        //public ManageListings()
        //{
        //    shareSkillObj = new ShareSkill();
        //}

        //public void AddListing()
        //{
        //    shareSkillObj.EnterShareSkill();
        //}

        //public void ViewListing()
        //{
        //   // manageListingObj.ViewListing();
        //}

        //public void EditListing()
        //{
        //    shareSkillObj.EditShareSkill();
        //}

        //public void DeleteListing()
        //{
        //    manageListingObj.DeleteListing();
        //}


    }
}
