using System.Collections.Generic;
using ConsoleApp.Roar;
using NUnit.Framework;

namespace ConsoleApp.Test
{
    internal class RoarTest
    {
        private RoarService _roarService;
        private const string SampleRoar = "ROAR";
        private const string Newuser = "NewUser";
        private const string OtherSampleRoar = "MORE ROAR";
        private const string OtherNewuser = "OtherNewUser";

        [SetUp]
        public void SetpUpRoarsTest()
        {
            _roarService= new RoarService();
        }

        [Test]
        public void UserCanReadRoarsFromOtherUserWithoutRoars()
        {
            Assert.IsEmpty(_roarService.GetRoars(Newuser));
        }

        [Test]
        public void UserCanReadRoarsFromOtherUserWithOne()
        {
            _roarService.Roar(Newuser, SampleRoar);
            Assert.AreEqual(new List<string> { SampleRoar }, _roarService.GetRoars(Newuser));
        }
        [Test]
        public void UserCanReadRoarsFromTwoDiferentUsers()
        {
            _roarService.Roar(Newuser, SampleRoar);

            _roarService.Roar(OtherNewuser, OtherSampleRoar);
            Assert.AreEqual(new List<string> { SampleRoar }, _roarService.GetRoars(Newuser));
            Assert.AreEqual(new List<string> { OtherSampleRoar }, _roarService.GetRoars(OtherNewuser));
        }
    }
}