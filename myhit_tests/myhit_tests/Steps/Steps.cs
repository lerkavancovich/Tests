using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace myhit_tests.Steps
{
   public class Steps
    {
        IWebDriver driver;
        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void RegistrationMyHit(string username, string password, string email)
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            mainpage.OpenPage();
            mainpage.Registration(username, password, email);
        }

        public bool IsRegistered(string confirmtext)
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            return (mainpage.CheckRegistration().Equals(confirmtext));
        }

        public void LoginMyHit(string username, string password)
        {
            Pages.MainPage loginpage = new Pages.MainPage(driver);
            loginpage.OpenPage();
            loginpage.Login(username, password); 
        }

        public bool IsLoggedIn(string confirmtext)
        {
            Pages.MainPage loginpage = new Pages.MainPage(driver);
            return (loginpage.CheckLogin().Equals(confirmtext));
        }

        public void SearchFilm()
        {
            Pages.ProfilePage profilepage = new Pages.ProfilePage(driver);
            profilepage.OpenPage();
            profilepage.SearchFilm();
        }
        public bool IsFound(string FilmURL)
        {
            Pages.ProfilePage profilepage = new Pages.ProfilePage(driver);
            return (profilepage.CheckURL().Trim().ToLower().Equals(FilmURL));
        }

        public void LikeFilm()
        {
            Pages.ProfilePage profilepage = new Pages.ProfilePage(driver);
            profilepage.OpenPage();
            profilepage.LikeFilm();
        }

       
        public void UnlikeFilm()
        {
            Pages.ProfilePage profilepage = new Pages.ProfilePage(driver);
            profilepage.OpenPage();
            profilepage.UnlikeFilm();
        }

        
        public void CollectFilm()
        {
            Pages.ProfilePage profilepage = new Pages.ProfilePage(driver);
            profilepage.OpenPage();
            profilepage.CollectFilm();
        }

        public bool IsCollected(string FullFilmName)
        {
            Pages.ProfilePage profilepage = new Pages.ProfilePage(driver);
            return (profilepage.CheckCollect().Equals(FullFilmName));
        }

        public void UncollectFilm()
        {
            Pages.ProfilePage profilepage = new Pages.ProfilePage(driver);
            profilepage.OpenPage();
            profilepage.UncollectFilm();
        }

        public bool IsUncollected(string FullFilmName)
        {
            Pages.ProfilePage profilepage = new Pages.ProfilePage(driver);
            return (profilepage.CheckCollect().Equals(FullFilmName));
        }

        public void WatchFilm()
        {
            Pages.ProfilePage profilepage = new Pages.ProfilePage(driver);
            profilepage.OpenPage();
            profilepage.WatchedFilm();
        }

        public bool Iswatched(string FullFilmName)
        {
            Pages.ProfilePage profilepage = new Pages.ProfilePage(driver);
            return (profilepage.CheckWatched().Equals(FullFilmName));
        }

        public void UnwatchFilm()
        {
            Pages.ProfilePage profilepage = new Pages.ProfilePage(driver);
            profilepage.OpenPage();
            profilepage.UnwatchedFilm();
        }

        public bool IsUnwatched(string FullFilmName)
        {
            Pages.ProfilePage profilepage = new Pages.ProfilePage(driver);
            return (profilepage.CheckWatched().Equals(FullFilmName));
        }

        public void AddFriend()
        {
            Pages.OtherProfilePage otherprofilepage = new Pages.OtherProfilePage(driver);
            otherprofilepage.OpenPage();
            otherprofilepage.AddFriend();
        }

        public bool IsAdded(string FriendName)
        {
            Pages.OtherProfilePage otherprofilepage = new Pages.OtherProfilePage(driver);
            return (otherprofilepage.CheckFriend().Equals(FriendName));
        }

        public void CancelFriend()
        {
            Pages.OtherProfilePage otherprofilepage = new Pages.OtherProfilePage(driver);
            otherprofilepage.OpenPage();
            otherprofilepage.CancelFriend();
        }

        public void SendMessage()
        {
            Pages.OtherProfilePage otherprofilepage = new Pages.OtherProfilePage(driver);
            otherprofilepage.OpenPage();
            otherprofilepage.SendMessage();
        }

        public void EditNameSurname()
        {
            Pages.EditPage editpage = new Pages.EditPage(driver);
            editpage.OpenPage();
            editpage.EditNameSurname();
        }

        public bool IsChangedName(string fullname)
        {
            Pages.EditPage editpage = new Pages.EditPage(driver);
            return (editpage.CheckNameSurname().Equals(fullname));
        }

        public void EditInterests()
        {
            Pages.EditPage editpage = new Pages.EditPage(driver);
            editpage.OpenPage();
            editpage.EditInterests();
        }

        public bool IsChangedInterests(string interest)
        {
            Pages.EditPage editpage = new Pages.EditPage(driver);
            return (editpage.CheckInterests().Equals(interest));
        }
        public void EditPhoto()
        {
            Pages.EditPage editpage = new Pages.EditPage(driver);
            editpage.OpenPage();
            editpage.EditPicture();
        }

        public void EditPassword()
        {
            Pages.EditPage editpage = new Pages.EditPage(driver);
            editpage.OpenPage();
            editpage.EditPassword();
        }
    }


}
