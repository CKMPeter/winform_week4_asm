using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormWeek4
{
    class Student : Human
    {
        public Student(string name, string addr, string id, DateTime bDay, string email, string phone, bool gender) : base(name, addr, id, bDay, email, phone, gender) { }
    }
}
