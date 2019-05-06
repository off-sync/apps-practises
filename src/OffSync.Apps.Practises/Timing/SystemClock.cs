using System;

namespace OffSync.Apps.Practises.Timing
{
    public class SystemClock :
        IClock
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
