using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Member
    {
        private string _name;
        private int _age;
        private bool _isStudent;
        private int _visits;
        public string Name { get { return _name; } set { value = _name; } }
        public int Age { get { return _age; } set { value = _age; } }
        public bool IsStudent { get { return _isStudent; } set { value = _isStudent; } }
        public int Visits { get { return _visits; } set { value = _visits; } }
        public Member(string name, int age, bool isStudent)
        {
            _name = name;
            _age = age;
            _isStudent = isStudent;
            _visits = 0;
        }
        public void CheckIn()
        {
            _visits++;
        }
        public string Describe()
        {
            string stuff = "";
            if (_isStudent)
            {
                stuff = "student";
            }
            else
            {
                stuff = "normal";
            }
            return $"{Name} ({Age} year old, {stuff}) - {Visits} visits";
        }
    }
}
