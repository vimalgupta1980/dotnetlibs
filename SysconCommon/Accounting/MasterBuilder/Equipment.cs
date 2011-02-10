using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common;
using SysconCommon.Common.Environment;
using SysconCommon.Accounting;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class Equipment : IEquipment
    {
        private int _Recnum;

        public Equipment(int recnum)
        {
            _Recnum = recnum;
        }

        public int EquipmentNumber
        {
            get { return _Recnum; }
        }

        public string Name {
            get {
                return Cache.CacheResult(() =>
                    {
                        var nme = Connections.GetScalar<string>("select eqpnme from eqpmnt where recnum = {0}", EquipmentNumber);
                        return nme;
                    });
            }
        }

        public IEquipmentType EquipmentType
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    var typrec = Connections.GetScalar<int>("select eqptyp from eqpmnt where recnum = {0}", EquipmentNumber);
                    return typrec == 0 ? null : new EquipmentType(typrec);
                }, EquipmentNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
