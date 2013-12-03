using System;
using Core;
using NUnit.Framework;

namespace RedSocialPracticaTDD.Test
{
    [TestFixture]
    public class RegisterUserTest
    {
        private UserService _userManagement;
        private const string NEW_USER = "New User";

        [SetUp]
        public void TestSetUp()
        {
            _userManagement = new UserService(new UserRepo());
        }
        [Test]
        public void RegisterNonExistingUserReturnsNothing()
        {
            try
            {
                _userManagement.Register(NEW_USER);
            }
            catch (Exception)
            {

                Assert.Fail("Can't register user");
            }
        }

        [Test]
        public void RegisterExistingUserReturnsError()
        {
            _userManagement.Register(NEW_USER);

            Assert.Throws<Exception>(() => _userManagement.Register(NEW_USER));
        }
    }
}