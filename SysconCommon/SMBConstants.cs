using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon
{
    public static class SMBConstants
    {
        public static string[] CalcMethods
        {
            get
            {
                return new string[] {
                    "Unused", // 0 - never used
                    "% Gross Pay (unadjusted)", // 1
                    "% Total Taxable Wages", // 2
                    "% Gross + Paygroup Benefits", // 3
                    "% Reg Pay (reg hours only)", // 4
                    "% Reg Pay (all hours)", // 5
                    "% Disposable Income (net)", // 6
                    "% Other Calculation", // 7
                    "Per Hour (all hours)", // 8
                    "Per Hour (reg hours only)", // 9
                    "Per Day", // 10
                    "Per Pay Period", // 11
                    "Reg/Ovt/Prm (0*,1*,1*)", // 12
                    "Reg/Ovt/Prm (0*,1.5*,2*)", // 13
                    "Reg/Ovt/Prm (1*,1.5*,1.5*)", // 14
                    "Reg/Ovt/Prm (1*,1.5*,2*)", // 15
                    "Reg/Ovt/Prm (1*,2*,2*)", // 16
                    "Tables", // 17
                    "Variable (manual calc)", // 18
                };
            }
        }

        public static string[] CalculationTypes
        {
            get
            {
                return new string[] {
                    "Unused", // 0
                    "Deduct From Emp.", // 1
                    "Add to Gross", // 2
                    "Employer Cost", // 3
                    "Add/Deduct", // 4
                    "Accrue Hours", // 5
                };
            }
        }
    }
}
