using System;

namespace OffSync.Apps.Practises.Timing
{
    public interface IClock
    {
        DateTime UtcNow { get; }
    }
}
