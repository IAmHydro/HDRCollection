using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;

namespace HDRHelper
{
    public class BuffHelper
    {
        public static bool IsLockedInPlace(BuffInstance buff)
        {
            return buff.IsStunOrSuppressed || buff.IsKnockup || buff.IsRoot || buff.IsSuppression;
        }
    }
}
