
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


//LOGIN
IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("http://localhost:5000/");
driver.Manage().Window.Maximize();

IWebElement SignIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
SignIn.Click();

IWebElement EmailAddress = driver.FindElement(By.XPath("//input[@name='email']"));
EmailAddress.SendKeys("mymarsproject22@gmail.com");

IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));
Password.SendKeys("mars123$");

IWebElement RememberMe = driver.FindElement(By.XPath("//input[@name='rememberDetails']"));
RememberMe.Click();
IWebElement Login = driver.FindElement(By.XPath("/html/body/div[2]//div[1]//div[4]/button"));
Login.Click();

//SHARESKILL
Thread.Sleep(1000);
IWebElement GoToShareSkill = driver.FindElement(By.XPath("//div/section[1]/div/div[2]/a"));
GoToShareSkill.Click();
Thread.Sleep(1000);

IWebElement AddTitle = driver.FindElement(By.XPath("//div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
AddTitle.SendKeys("TestAnalyst");

var Category = driver.FindElement(By.Name("categoryId"));
var selectElement = new SelectElement(Category);
selectElement.SelectByValue("6");

Thread.Sleep(1000);
var SubCategory = driver.FindElement(By.Name("subcategoryId"));
var selectOption = new SelectElement(SubCategory);
selectOption.SelectByValue("4");
