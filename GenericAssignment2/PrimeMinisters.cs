using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment2
{
    class PrimeMinisters
    {
        private SortedDictionary<int, string> _primeMinisters;
        public PrimeMinisters()
        {
            _primeMinisters = new SortedDictionary<int, string>();
        }
        public void Add(int year,string name )
        {
            int current_year = DateTime.Now.Year;
            if (year < 1947 && year > current_year)
                throw new CustomeException($"You entered wrong year\nPlease enter between 1947 to {current_year}");
            _primeMinisters.Add(year, name);
        }
        public SortedDictionary<int,string>GetAll()
        {
            return _primeMinisters;
        }
        public string Get(int year)
        {
            if (!_primeMinisters.ContainsKey(year))
                return "";
            return _primeMinisters[year];
        }
    }
}
