using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CustomerPortal.Shared.Enums
{
    public enum UserStatus
    {

        [Description("Pending")]
        Pending,
        [Description("Active")]
        Active,
        [Description("Suspended")]
        Suspended,
        [Description("Blocked")]
        Blocked
    }
}
