

namespace RedSocialPracticaTDD.Core
{
    public interface IUserRepo
    {
        void Add(string newUser);
        bool ExistUser(string user);
        User Find(string user);
    }
}
