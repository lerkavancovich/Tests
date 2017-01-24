using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace myhit_tests.Pages
{
    public class OtherProfilePage
    {
        private const string BASE_URL = "https://my-hit.org/user/tanyapet/";
        private const string FRNDS_URL = "https://my-hit.org/user/unit_test/friend/";

        private const string message = "Hello";

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > div.pull-right > div.col-xs-12.text-center > button")]
        public IWebElement AddButton;

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div:nth-child(1) > noindex > ul > li:nth-child(2) > a")]
        public IWebElement SendButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='msg-content']")]
        public IWebElement TextArea;

        [FindsBy(How = How.XPath, Using = "//*[@id='msg-new-form']/div[3]/button")]
        public IWebElement SendMessageButton;

        [FindsBy(How = How.XPath, Using = " //*[@id='user-tanyapet']/div[2]/ul/li[1]/b/a")]
        public IWebElement FriendName;
       
        public IWebDriver driver;

        public OtherProfilePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
       public void OpenPage()
       {
           driver.Navigate().GoToUrl(BASE_URL);
       }

       public void AddFriend()
       {
           AddButton.Click();
           driver.Navigate().GoToUrl(FRNDS_URL);
       }
       public string CheckFriend()
       {
           return FriendName.Text;
       }
       public void CancelFriend()
       {
           AddButton.Click();
       }

       public void SendMessage()
       {
           SendButton.Click();
           TextArea.SendKeys(message);
           SendMessageButton.Click();
       }
    }
}
