using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common;
using SysconCommon.Common.Environment;
using SysconCommon.Accounting;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class EquipmentLineItem : IEquipmentLineItem
    {
        readonly private int _Recnum, _LineNumber;

        public EquipmentLineItem(int recnum, int linnum)
        {
            _Recnum = recnum;
            _LineNumber = linnum;
        }

        public int Recnum
        {
            get { return _Recnum; }
        }

        public int LineNumber
        {
            get { return _Recnum; }
        }

        public IEquipment Equipment
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    var eqpnum = Connections.GetScalar<int>(
                        "select eqpnum from tmeqln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                    return eqpnum == 0 ? null : new Equipment(eqpnum);
                }, Recnum, LineNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal OperatedRate
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>(
                        "select oprrte from tmeqln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                }, Recnum, LineNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal StandbyRate
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>(
                        "select stdrte from tmeqln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                }, Recnum, LineNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal IdleRate
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>(
                        "select idlrte from tmeqln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                }, Recnum, LineNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal MinimumHours
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>(
                        "select minhrs from tmeqln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                }, Recnum, LineNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
