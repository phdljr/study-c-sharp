using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberForms.Entity
{
    internal class Member
    {
        private string name;
        private string password;

        public Member(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Password
        {
            get { return password; }
            private set { password = value; }
        }
    }
}
