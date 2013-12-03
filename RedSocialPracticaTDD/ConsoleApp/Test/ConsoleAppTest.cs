using Moq;
using NUnit.Framework;

namespace ConsoleApp.Test
{
    public class ConsoleTest
    {
        private Mock<IUserServiceProxy> _userProxy;
        private CommandExecuter _commandExecuter;
        [SetUp]
        public void ConseTestSetpUp()
        {
             _userProxy = new Mock<IUserServiceProxy>();
             _commandExecuter = new CommandExecuter(_userProxy.Object);
        }
        [Test]
        public void AddUserCommandCallAddinUserService()
        {


            _commandExecuter.ExecuteCommand("add newUser");
            _userProxy.Verify(x => x.Register("newUser"));
        }
        [Test]
        public void FollowUserCommandCallFollowInUserUserService()
        {
            _commandExecuter.ExecuteCommand("follow newUser OtherUser");
            _userProxy.Verify(x => x.Follow("newUser", "OtherUser"));
        }
        [Test]
        public void GetFollowersCommandCallGetFollowersInUserUserService()
        {
            _commandExecuter.ExecuteCommand("followers OtherUser");
            _userProxy.Verify(x => x.GetFollowers("OtherUser"));
        }
    }


}
