using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectUpdatesDummy
{
    public class Customer
    {
        private int pk;
        private string name;
        private string details;
        private int versionPK;
        private bool isDeleted;

        public Customer(int pk, string name, string details, int versionPK, bool deleted)
        {
            this.pk = pk;
            this.name = name;
            this.details = details;
            this.versionPK = versionPK;
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

        public int VersionPK
        {
            get { return this.versionPK; }
            set { this.versionPK = value; }
        }

    }
}
