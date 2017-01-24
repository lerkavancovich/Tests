using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myhit_tests.Tests
{
    [TestClass]
    public class TestsForMyHit
    {
        private Steps.Steps steps = new Steps.Steps();

        private const string username = "unit_test";
        private const string password = "unit_test_bstu";
        private const string email = "unit_test_test@gmail.com";
        private const string ConfirmText = "Поздравляем!";
        private const string ConfirmLoginText = "Вход, успешно выполнен";
        private const string fullname = "Unit Test";
        private const string interest = "Star wars";
        private const string FriendName = "tanyapet";
        private const string FullFilmName = "Голос монстра / A Monster Calls";

        private const string FilmURL = "https://my-hit.org/film/415570/";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void RegisterMyHit()
        {
            steps.RegistrationMyHit(username, password, email);
            NUnit.Framework.Assert.True(steps.IsRegistered(ConfirmText));
        }

        [Test]
        public void LoginMyHit()
        {
            steps.LoginMyHit(username, password);
            NUnit.Framework.Assert.True(steps.IsLoggedIn(username));
        }

        [Test]
        public void SearchMyHit()
        {
            steps.LoginMyHit(username, password);
            steps.SearchFilm();
            NUnit.Framework.Assert.True(steps.IsFound(FilmURL));
        }

        [Test]
        public void LikeMyHit()
        {
            steps.LoginMyHit(username, password);
            steps.SearchFilm();
            steps.LikeFilm();  
        }

        [Test]
        public void UnlikeMyHit()
        {
            steps.LoginMyHit(username, password);
            steps.SearchFilm();
            steps.UnlikeFilm();
        }

        [Test]
        public void CollectMyHit()
        {
            steps.LoginMyHit(username, password);
            steps.SearchFilm();
            steps.CollectFilm();
            NUnit.Framework.Assert.True(steps.IsCollected(FullFilmName));
        }

        [Test]
        public void UncollectMyHit()
        {
            steps.LoginMyHit(username, password);
            steps.SearchFilm();
            steps.UncollectFilm();
            NUnit.Framework.Assert.False(steps.IsCollected(FullFilmName));
        }
        [Test]
        public void WatchMyHit()
        {
            steps.LoginMyHit(username, password);
            steps.SearchFilm();
            steps.WatchFilm();
            NUnit.Framework.Assert.True(steps.Iswatched(FullFilmName));
        }

        [Test]
        public void UnwatchMyHit()
        {
            steps.LoginMyHit(username, password);
            steps.SearchFilm();
            steps.UnwatchFilm();
            NUnit.Framework.Assert.False(steps.Iswatched(FullFilmName));
        }

        [Test]
        public void AddFriend()
        {
            steps.LoginMyHit(username, password);
            steps.AddFriend();
            NUnit.Framework.Assert.True(steps.IsAdded(FriendName));
        }

        [Test]
        public void UnfriendMyHit()
        {
            steps.LoginMyHit(username, password);
            steps.CancelFriend();
            NUnit.Framework.Assert.False(steps.IsAdded(FriendName));
        }

        [Test]
        public void SendMessage()
        {
            steps.LoginMyHit(username, password);
            steps.SendMessage(); 
        }

        [Test]
        public void ChangeFullName()
        {
            steps.LoginMyHit(username, password);
            steps.EditNameSurname();
            NUnit.Framework.Assert.True(steps.IsChangedName(fullname));
        }

        [Test]
        public void ChangeInterests()
        {
            steps.LoginMyHit(username, password);
            steps.EditInterests();
            NUnit.Framework.Assert.True(steps.IsChangedInterests(interest));
        }

        [Test]
        public void EditPhoto()
        {
            steps.LoginMyHit(username, password);
            steps.EditPhoto();
        }

        [Test]
        public void EditPassword()
        {
            steps.LoginMyHit(username, password);
            steps.EditPassword();
        }
    }
}
