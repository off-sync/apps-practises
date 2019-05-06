using System;

namespace OffSync.Apps.Practises.Logging
{
    public interface ILogger
    {
        void Log(
            LogLevels level,
            string message);

        ILogger WithException(
            Exception exception);

        ILogger WithField(
            string name,
            object value);
    }
}
