using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp6
{
    internal class Membership
    {
        private Member _owner;
        private int _monthlyPrice;
        private int _months;
        public Member Owner { get { return _owner; } set { value = _owner; } }
        public int MonthlyPrice { get { return _monthlyPrice; } set { value = _monthlyPrice; } }
        public int Months { get { return _months; } set { value = _months; } }
        public Membership(Member owner, int monthlyPrice, int months)
        {
            _owner = owner;
            _monthlyPrice = monthlyPrice;
            _months = months;
        }
        public double TotalCost()
        {
            if (_owner.IsStudent)
            {
                return _monthlyPrice * 0.2 * _months;
            }
            return MonthlyPrice * Months;
        }

    }
}
