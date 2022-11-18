using OpenQA.Selenium;
using static Competition.Global.GlobalDefinitions;

namespace Competition.Pages
{
    internal class ManageListings
    {
        #region Manage listing's page objects
        //ShareSkill Button
        private IWebElement btnShareSkill => driver.FindElement(By.LinkText("Share Skill"));

        //Manage Listings
        private IWebElement manageListingsLink => driver.FindElement(By.XPath("//a[@href='/Home/ListingManagement']"));

        //Message warning no listing
        private IWebElement warningMessage => driver.FindElement(By.XPath("//h3[contains(text(),'You do not have any service listings!')]"));

        //Title
        private IList<IWebElement> Titles => driver.FindElements(By.XPath("//div[@id='listing-management-section']//tbody/tr/td[3]"));

        //View button
        private IWebElement view => driver.FindElement(By.XPath("(//i[@class='eye icon'])[1]"));

        //Edit button
        private IWebElement edit => driver.FindElement(By.XPath("(//i[@class='outline write icon'])[1]"));

        //Yes/No button
        private IList<IWebElement> clickActionsButton => driver.FindElements(By.XPath("//div[@class='actions']/button"));

        //Save button
        private IWebElement btnSave => driver.FindElement(By.XPath("//input[@value='Save']"));
        #endregion

        ShareSkill shareSkillObj;
        ManageListings manageListingObj;
        public ManageListings()
        {
            shareSkillObj = new ShareSkill();
        }

        public void AddListing()
        {
            shareSkillObj.EnterShareSkill();
        }

        public void ViewListing()
        {
           // manageListingObj.ViewListing();
        }

        public void EditListing()
        {
            shareSkillObj.EditShareSkill();
        }

        public void DeleteListing()
        {
            manageListingObj.DeleteListing();
        }


    }
}
