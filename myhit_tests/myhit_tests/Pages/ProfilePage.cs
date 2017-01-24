using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace myhit_tests.Pages
{
    public class ProfilePage

    {
        private const string BASE_URL = "https://my-hit.org/";
        private const string COLLECT_URL = "https://my-hit.org/user/unit_test/want/";
        private const string WATCHED_URL = "https://my-hit.org/user/unit_test/watched/";

        private const string FilmName = "Голос монстра";

        [FindsBy(How = How.XPath, Using = "//*[@id='search-navbar-q']")]
        public IWebElement Search;

        [FindsBy(How = How.CssSelector, Using = "body > div.autocomplete-suggestions > div > a:nth-child(2)")]
        public IWebElement GoTo;

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > div:nth-child(12) > div > div.btn-group.rating-control > button.btn.btn-info.btn-rating-up-big")]
        public IWebElement Like;

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > div:nth-child(12) > div > div.btn-group.rating-control > button.btn.btn-info.btn-rating-down-big")]
        public IWebElement Unlike;

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > div:nth-child(12) > div > button.btn.btn-info.btn-watch-want-big")]
        public IWebElement Collect;

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > div:nth-child(12) > div > button.btn.btn-info.btn-watch-want-big.active")]
        public IWebElement Uncollect;

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > div:nth-child(12) > div > button.btn.btn-info.btn-watch-watched-big")]
        public IWebElement Watched;

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > div:nth-child(12) > div > button.btn.btn-info.btn-watch-watched-big.active")]
        public IWebElement Unwatched;

        [FindsBy(How = How.CssSelector, Using = "body > div.container > div > div.col-xs-10.col-md-8.conten.fullstory > div > div.col-xs-9 > b > a")]
        public IWebElement FullFilmName;

        public IWebDriver driver;

       
       public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
       public void OpenPage()
       {
           driver.Navigate().GoToUrl(BASE_URL);
       }
       public void SearchFilm()
       {
           Search.SendKeys(FilmName);
           GoTo.Click(); 
       }

       public string CheckURL()
       {
           return driver.Url;
       }
       public void LikeFilm()
       {
           SearchFilm();
           Like.Click();
       }


       public void UnlikeFilm()
       {
           SearchFilm();
           Unlike.Click();
       }

       public void CollectFilm()
       {
           SearchFilm();
           Collect.Click();
           driver.Navigate().GoToUrl(COLLECT_URL);
       }

       public string CheckCollect()
       {
           return FullFilmName.Text;
       }

       public void UncollectFilm()
       {
           SearchFilm();
           Uncollect.Click();
           driver.Navigate().GoToUrl(COLLECT_URL);
       }

 
       public void WatchedFilm()
       {
           SearchFilm();
           Watched.Click();
           driver.Navigate().GoToUrl(WATCHED_URL);
       }

       public string CheckWatched()
       {
           return FullFilmName.Text;
       }
       public void UnwatchedFilm()
       {
           SearchFilm();
           Unwatched.Click();
           driver.Navigate().GoToUrl(WATCHED_URL);
       }

    }
}
