

using System.Collections.Generic;

namespace ConsoleApp.Roar
{
    public class RoarListRepo
    {
        private Dictionary<string, RoarList> _roars;

        public RoarListRepo()
        {
            _roars = new Dictionary<string, RoarList>();
        }

        public RoarList Find(string newuser)
        {

            if (_roars.ContainsKey(newuser))
            {
                return _roars[newuser];
            }
            return new RoarList();
        }

        public void AddRoar(string newuser, string roar)
        {
            if (!_roars.ContainsKey(newuser))
            {
                _roars.Add(newuser, new RoarList());
            }
            _roars[newuser].Add(roar);
        }
    }
}
