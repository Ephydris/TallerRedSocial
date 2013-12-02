using System;
using FluentAssertions;
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
                 Assert.Fail();
             }
         }
    }
}
