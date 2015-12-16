using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectUpdatesDummy
{
    public class Update
    {
        private int pk;
        private int customerPK;
        private string comment;
        private int versionPK;
        private bool isDeleted;
        private DateTime? expectedDate;
        private DateTime? actualDate;
        private DateTime? contactedDate;
        private int? assignedTo;
        private bool contacted;
        private bool done;

        public Update(int pk, int versionPK, int customerPK, DateTime? expectedDate, DateTime? actualDate, string comment, bool deleted, int? assignedTo, bool? contacted, DateTime? contactedDate, bool? done)
        {
            this.pk = pk;
            this.customerPK = customerPK;
            this.expectedDate = expectedDate;
            this.actualDate = actualDate;
            this.comment = comment;
            this.versionPK = versionPK;
            isDeleted = deleted;
            this.assignedTo = assignedTo;
            this.contactedDate = contactedDate;
            if (contacted == null)
            {
                this.contacted = false;
            }
            else
            {
                this.contacted = (bool)contacted;
            }

            if (done == null)
            {
                this.done = false;
            }
            else
            {
                this.done = (bool)done;
            }
            

        }

        public int PK
        {
            get { return this.pk; }
            set { this.pk = value; }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public int VersionPK
        {
            get { return this.versionPK; }
            set { this.versionPK = value; }
        }

        public DateTime? ExpectedDate
        {
            get { return this.expectedDate; }
            set { this.expectedDate = value; }
        }

      

        public int CustomerPK
        {
            get { return this.customerPK; }
            set { this.customerPK = value; }
        }

        public bool IsDeleted
        {
            get { return this.isDeleted; }
            set { this.isDeleted = value; }
        }

        public string CustomerName
        {
            get { return Database.getCustomerName(customerPK); }
        }

        public string VersionID
        {
            get { return Database.getVersionID(versionPK); }
        }

        public int? Employee
        {
            get { return this.assignedTo; }
            set { this.assignedTo = value; }
        }

        public bool Contacted
        {
            get { return this.contacted; }
            set { this.contacted = value; }
        }

        public DateTime? ActualDate
        {
            get { return this.actualDate; }
            set { this.actualDate = value; }
        }

        public bool Done
        {
            get { return this.done;  }
            set { this.done = value; }
        }

        public DateTime? ContactedDate
        {
            get { return this.contactedDate; }
            set { this.contactedDate = value; }
        }
    }
}
