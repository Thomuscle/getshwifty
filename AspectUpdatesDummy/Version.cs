using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectUpdatesDummy
{
    public class Version
    {
        private int pk;
        private string id;
        private string description;
        private int type;
        private DateTime release_Date;
        private bool isDeleted;

        public enum TypeEnum { Release = 1, Hotfix = 2 };

        public Version(int pk, string id, string description, int type, DateTime release_date, bool deleted)
        {
            this.pk = pk;
            this.id = id;
            this.description = description;
            this.type = type;
            this.release_Date = release_date;
            isDeleted = deleted;

        }

        public int PK
        {
            get { return this.pk; }
            set { this.pk = value; }
        }

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Type
        {
            get {TypeEnum typeEnum = (TypeEnum)this.type;
            return typeEnum.ToString();
            }
            set { this.type = Convert.ToInt32(value); }
        }

        public DateTime ReleaseDate
        {
            get { return this.release_Date; }
            set { this.release_Date = value;  }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
    }
}
