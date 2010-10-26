using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common.Environment;
using SysconCommon.Common;
using SysconCommon.Accounting;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class EquipmentType : IEquipmentType
    {
        readonly private int _Recnum;

        public EquipmentType(int recnum)
        {
            _Recnum = recnum;
        }

        public int Recnum
        {
            get { return _Recnum; }
        }

        public string Name
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<string>("select typnme from eqptyp where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Notes
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<string>("select ntetxt from eqptyp where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
