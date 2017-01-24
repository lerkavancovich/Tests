using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace myhit_tests.Pages
{
    public class MainPage
    {
        private const string BASE_URL = "https://my-hit.org/";
        private const string PR_URL = "https://my-hit.org/user/unit_test/";

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/ul[2]/li/button")]
        public IWebElement LoginButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='defaultModal']/div/div/div[2]/div/div[1]/ul/li[2]/a")]
        public IWebElement RegistrationTab;

        [FindsBy(How = How.XPath, Using = "//*[@id='reg_login']")]
        public IWebElement UsernameElement;

        [FindsBy(How = How.XPath, Using = "//*[@id='reg_pass']")]
        public IWebElement PasswordElement;

        [FindsBy(How = How.XPath, Using = "//*[@id='reg_email']")]
        public IWebElement EmailElement;

        [FindsBy(How = How.XPath, Using = "//*[@id='user_register_form']/div[2]/button")]
        public IWebElement ConfirmButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/div[2]/h1")]
        public IWebElement ConfirmLabel;

        [FindsBy(How = How.XPath, Using = "//*[@id='login']")]
        public IWebElement LoginUsername;

        [FindsBy(How = How.XPath, Using = "//*[@id='pass']")]
        public IWebElement LoginPassword;

        [FindsBy(How = How.XPath, Using = "//*[@id='user_login_form']/div[2]/button")]
        public IWebElement LoginButtonConfirm;

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > h1")]
        public IWebElement LoginConfirmLabel;
        
        public IWebDriver driver;

       public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
       public void OpenPage()
       {
           driver.Navigate().GoToUrl(BASE_URL);
       }
       public void Registration(string username, string password, string email)
       {
           LoginButton.Click();
           RegistrationTab.Click();
           UsernameElement.SendKeys(username);
           PasswordElement.SendKeys(password);
           EmailElement.SendKeys(email);
           ConfirmButton.Click();  
       }

       public string CheckRegistration()
       {
           return ConfirmLabel.Text;
       }

       public void Login(string username, string password)
       {
           LoginButton.Click();
           LoginUsername.SendKeys(username);
           LoginPassword.SendKeys(password);
           LoginButtonConfirm.Click();
           driver.Navigate().GoToUrl(PR_URL);
       }
       public string CheckLogin()
       {
           return LoginConfirmLabel.Text;
       }
    }
}
