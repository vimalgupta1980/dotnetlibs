﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common;
using SysconCommon.Accounting;
using SysconCommon.Common.Environment;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class TimeAndMaterialLineItem : ITimeAndMaterialLineItem
    {
        public TimeAndMaterialLineItem(int recnum, int linnum)
        {
            this.Recnum = recnum;
            this.LineNumber = linnum;
        }

        public int Recnum { get; set; }
        public int LineNumber { get; set; }

        public IEmployee Employee
        {
            get
            {
                return Cache.CacheResult<IEmployee>(() =>
                {
                    var empnum = Connections.GetScalar<int>(
                        "select empnum from tmemln where recnum = {0} and linnum = {1}", Recnum, LineNumber);

                    return empnum == 0 ? null : new Employee(empnum);
                }, Recnum, LineNumber);
            }   
            set
            {
                throw new NotImplementedException();
            }
        }

        public ICostCode CostCode
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return new CostCode(Connections.GetScalar<int>(
                        "select cstcde from tmemln where recnum = {0} and linnum = {1}", Recnum, LineNumber));
                }, Recnum, LineNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal PayRate1
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>(
                        "select rate01 from tmemln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                }, Recnum, LineNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal PayRate2
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>(
                        "select rate02 from tmemln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                }, Recnum, LineNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal PayRate3
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>(
                        "select rate03 from tmemln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                }, Recnum, LineNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal MinHours
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>(
                        "select minhrs from tmemln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                }, Recnum, LineNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
