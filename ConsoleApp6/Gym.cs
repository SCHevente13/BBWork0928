using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Gym
    {
        private string _name;
        private List<Membership> _memberships;
        public string Name { get { return _name; } set { value = _name; } }
        public List<Membership> Memberships { get { return _memberships; } }
        public Gym(string name)
        {
            _name = name;
            _memberships = new List<Membership>();
        }
        public void AddMembership(Membership membership)
        {
            _memberships.Add(membership);
        }
        public int TotalIncome()
        {
            int total = 0;
            foreach (Membership membership in _memberships)
            {
                total += membership.TotalCost();
            }
            return total;
        }
        public Member MostActive()
        {
            return _memberships.OrderByDescending(x => x.Owner.Visits).Select(x => x.Owner).First();
        }
        public Membership BestValue()
        {
            return _memberships.OrderBy(x => x.PricePerVisit()).First();
        }
    }
}
