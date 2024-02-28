using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormWeek4
{
    class Human
    {
        protected string name;
        protected string id;
        protected string addr;
        protected DateTime bDay;
        protected string email;
        protected string phone;
        protected bool gender;

        public Human(string name, string addr, string id, DateTime bDay, string email, string phone, bool gender)
        {
            this.name = name;
            this.id = id;
            this.addr = addr;
            this.bDay = bDay;
            this.email = email;
            this.phone = phone;
            this.gender = gender;
        }

        public string Name { get { return name; } set { this.name = value;  } }
        public string Id { get { return id; } set { this.id = value; } }
        public string Addr { get { return addr; } set { this.addr = value; } }
        public DateTime BDay { get {  return bDay; } set { this.bDay = value; } }
        public String Email { get { return email; } set { this.email = value; } }
        public string Phone { get { return phone; } set { this.phone = value; } }
        public bool Gender { get { return gender; } set { this.gender = value; } }
    }
}
