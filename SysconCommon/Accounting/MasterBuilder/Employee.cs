using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting.MasterBuilder
{
    class Employee : IEmployee
    {
        public Employee(int id)
        {
            this.Recnum = id;
        }

        public int Recnum { get; set; }

        public string FirstName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string LastName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string MiddleName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
