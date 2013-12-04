
using System.Collections.Generic;

namespace ConsoleApp.Roar
{
    public class RoarList
    {
        private List<string> _roarList;

        public RoarList()
        {
            _roarList = new List<string>();
        }

        public List<string> ToStringList()
        {
            return _roarList;
        }

        public void Add(string roar)
        {
            _roarList.Add(roar);
        }
    }
}
