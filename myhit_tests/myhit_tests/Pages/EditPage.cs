using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace myhit_tests.Pages
{
    public class EditPage
    {
        private const string BASE_URL = "https://my-hit.org/user/unit_test/";
        private const string photourl = "https://2ch.hk/ne/src/95528/14645498211760.jpg";

        private const string name = "Unit";
        private const string surname = "Test";
        private const string interest = "Star wars";
        private const string old_pass = "unit_test_bstu";
        private const string new_pass = "unit_test_bstu";

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div:nth-child(1) > div > a:nth-child(3)")]
        public IWebElement EditProfileButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='first_name']")]
        public IWebElement EditName;

        [FindsBy(How = How.XPath, Using = "//*[@id='last_name']")]
        public IWebElement EditSurname;

        [FindsBy(How = How.XPath, Using = "//*[@id='tab1']/form/div[6]/button")]
        public IWebElement SaveEditButton;

        [FindsBy(How = How.CssSelector, Using = " body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > h4")]
        public IWebElement NameSurname;
       
        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > div > ul > li:nth-child(3) > a")]
        public IWebElement InterestsTab;

        [FindsBy(How = How.XPath, Using = "//*[@id='interest']")]
        public IWebElement Interests;

        [FindsBy(How = How.XPath, Using = "//*[@id='tab3']/form/div[12]/button")]
        public IWebElement SaveInterestsButton;

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div:nth-child(1) > ul:nth-child(6) > li:nth-child(2) > span > a")]
        public IWebElement InterestsPage;

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > div > ul > li:nth-child(4) > a")]
        public IWebElement PhotoTab;

        [FindsBy(How = How.XPath, Using = " //*[@id='photo_url']")]
        public IWebElement PhotoURL;

        [FindsBy(How = How.CssSelector, Using = "#photo_url")]
        public IWebElement PhotoURLButton;

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > div > ul > li:nth-child(6) > a")]
        public IWebElement EditPasswordTab;

        [FindsBy(How = How.XPath, Using = "//*[@id='tab6']/div/div/a")]
        public IWebElement EditPasswordButtonTab;

        [FindsBy(How = How.XPath, Using = "//*[@id='pass_old']")]
        public IWebElement OldPassword;

        [FindsBy(How = How.XPath, Using = "//*[@id='pass_new'])")]
        public IWebElement NewPassword;

        [FindsBy(How = How.XPath, Using = "//*[@id='user_pass_modify']/div[3]/button")]
        public IWebElement SavePasswordButton;

        public IWebDriver driver;
     
          public EditPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
       public void OpenPage()
       {
           driver.Navigate().GoToUrl(BASE_URL);
       }

       public void EditNameSurname()
       {
           EditProfileButton.Click();
           EditName.SendKeys(name);
           EditSurname.SendKeys(surname);
           SaveEditButton.Click();
           driver.Navigate().GoToUrl(BASE_URL);
       }

       public string CheckNameSurname()
       {
           return NameSurname.Text;
       }

       public void EditInterests()
       {
           EditProfileButton.Click();
           InterestsTab.Click();
           Interests.SendKeys(interest);
           SaveInterestsButton.Click();
           driver.Navigate().GoToUrl(BASE_URL);
       }

       public string CheckInterests()
       {
           return InterestsPage.Text;
       }

       public void EditPicture()
       {
           EditProfileButton.Click();
           PhotoTab.Click();
           PhotoURL.SendKeys(photourl);
           PhotoURLButton.Click();
           driver.Navigate().GoToUrl(BASE_URL);
       }

       public void EditPassword()
       {
           EditProfileButton.Click();
           EditPasswordTab.Click();
           EditPasswordButtonTab.Click();
           OldPassword.SendKeys(old_pass);
           NewPassword.SendKeys(new_pass);
           SavePasswordButton.Click();
       }
    }
}
