using System.Collections.Generic;
using NUnit.Framework;
using RedSocialPracticaTDD.Core;

namespace RedSocialPracticaTDD.Test
{
    public class FollowUserTest
    {
        private UserService _userService;
        private const string NEW_USER = "New User";
        private const string ANOTHER_NEW_USER = "Another New User";
        private const string MORE_NEW_USER = "More New User";

        [SetUp]
        public void TestSetUp()
        {
            _userService = new UserService(new UserRepo());

            _userService.Register(NEW_USER);
            _userService.Register(MORE_NEW_USER);
            _userService.Register(ANOTHER_NEW_USER);
        }

        [Test]
        public void UserCanFollowOtherUser()
        {
            _userService.Follow(NEW_USER, ANOTHER_NEW_USER);
            Assert.AreEqual(new List<string> { NEW_USER }, _userService.GetFollowers(ANOTHER_NEW_USER));
        }
        [Test]
        public void UserCanFollowMoreThanOneUser()
        {
            _userService.Follow(NEW_USER, MORE_NEW_USER);
            _userService.Follow(ANOTHER_NEW_USER, MORE_NEW_USER);
            Assert.AreEqual(new List<string> { NEW_USER, ANOTHER_NEW_USER }, _userService.GetFollowers(MORE_NEW_USER));
        }
    }
}