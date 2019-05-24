using System;
using System.ComponentModel;

namespace TaxiAPI.Domain.Models
{
    [Flags]
    public enum EType : byte
    {
        [Description("R")]
        Regular = 1,

        [Description("S")]
        Spacious = 2,

        [Description("L")]
        Luxurious = 4,

    }
}
