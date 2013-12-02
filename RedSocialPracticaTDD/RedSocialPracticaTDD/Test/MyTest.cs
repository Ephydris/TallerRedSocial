using System;
using NUnit.Framework;

namespace RedSocialPracticaTDD.Test
{
    [TestFixture]
    public class MyTest
    {
        [Test]
        public void RegisterNonExistingUserReturnsNothing()
        {
            UserManagement userManagement = new UserManagement();
            try
            {
                userManagement.Register("New User");
            }
            catch (Exception)
            {
                Assert.Fail("Can't register user");
            }
        }

        [Test]
        public void RegisterExistingUserReturnsError()
        {
            UserManagement userManagement = new UserManagement();
            userManagement.Register("New User");

            Assert.Throws<Exception>(() => userManagement.Register("New User"));

        }
    }
}