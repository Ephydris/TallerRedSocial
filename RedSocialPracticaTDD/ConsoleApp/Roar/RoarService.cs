

using System.Collections.Generic;

namespace ConsoleApp.Roar
{
    public class RoarService
    {
        private RoarListRepo _roarRepo = new RoarListRepo();
        public RoarService()
        {
            _roarRepo = new RoarListRepo();
        }
        public List<string> GetRoars(string newuser)
        {
           return _roarRepo.Find(newuser).ToStringList();
        }

        public void Roar(string newuser, string roar)
        {
            _roarRepo.AddRoar(newuser, roar);
            
        }
    }
}
