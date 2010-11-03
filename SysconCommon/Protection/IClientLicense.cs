using System;

namespace SysconCommon.Protection
{
    public interface IClientLicense
    {
        bool IsTrial { get; }
        DateTime EffectiveStartDate { get; }
        DateTime EffectiveEndDate { get; }
        bool IsValid();
        bool LoadFile();
    }
}
