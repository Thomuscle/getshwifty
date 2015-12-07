using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectUpdatesDummy
{
    public class Employee
    {
        private int pk;
        private string name;
        private bool isDeleted;


        public Employee(int pk, string name, bool deleted)
        {
            this.pk = pk;
            this.name = name;
            isDeleted = deleted;

        }

        public int PK
        {
            get { return this.pk; }
            set { this.pk = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
