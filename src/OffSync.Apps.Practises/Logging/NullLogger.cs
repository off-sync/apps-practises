using System;

namespace OffSync.Apps.Practises.Logging
{
    public class NullLogger :
        ILogger
    {
        public void Log(
            LogLevels level,
            string message)
        {
            // do nothing
        }

        public ILogger WithException(
            Exception exception)
        {
            return this;
        }

        public ILogger WithField(
            string name,
            object value)
        {
            return this;
        }
    }
}
