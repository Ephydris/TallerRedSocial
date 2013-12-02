using System.Collections.Generic;
using NUnit.Framework;
using RedSocialPracticaTDD.Core;

namespace RedSocialPracticaTDD.Test
{
    public class FollowUserTest
    {
        private UserService _userManagement;
        private const string NEW_USER = "New User";
        private const string ANOTHER_NEW_USER = "Another New User";
        private const string MORE_NEW_USER = "More New User";

        [SetUp]
        public void TestSetUp()
        {
            _userManagement = new UserService(new UserRepo());

            _userManagement.Register(NEW_USER);
            _userManagement.Register(MORE_NEW_USER);
            _userManagement.Register(ANOTHER_NEW_USER);
        }

        [Test]
        public void UserCanFollowOtherUser()
        {
            _userManagement.Follow(NEW_USER, ANOTHER_NEW_USER);
            Assert.AreEqual(new List<string> { NEW_USER }, _userManagement.GetFollowers(ANOTHER_NEW_USER));
        }
        [Test]
        public void UserCanFollowMoreThanOneUser()
        {
            _userManagement.Follow(NEW_USER, MORE_NEW_USER);
            _userManagement.Follow(ANOTHER_NEW_USER, MORE_NEW_USER);
            Assert.AreEqual(new List<string> { NEW_USER, ANOTHER_NEW_USER }, _userManagement.GetFollowers(MORE_NEW_USER));
        }
    }
}