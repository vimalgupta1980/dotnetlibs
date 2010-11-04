using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common;
using SysconCommon.Accounting;
using SysconCommon.Common.Environment;

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
                return Cache.CacheResult(() => Connections.GetScalar<string>(
                    "select fstnme from employ where recnum = {0}", Recnum).NullToBlank().Trim(), Recnum);
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
                return Cache.CacheResult(() => Connections.GetScalar<string>(
                    "select lstnme from employ where recnum = {0}", Recnum).NullToBlank().Trim(), Recnum);
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
                return Cache.CacheResult(() => Connections.GetScalar<string>(
                    "select midini from employ where recnum = {0}", Recnum).NullToBlank().Trim(), Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
