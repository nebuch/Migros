using System;
using System.Threading;

namespace MonoLightTech.UnityUtil
{
    public static class UniqueId
    {
        private static long _currentNumber;

        public static long Integer()
        {
            // TODO: Also use 'MAC id' for global uniqueness

            var threadId = Thread.CurrentThread.ManagedThreadId;
            var timestamp = Timestamp.ToUnixMs(DateTime.Now);
            _currentNumber++;

            return threadId ^ timestamp ^ _currentNumber;
        }

        public static string String()
        {
            return Integer().ToString("X");
        }
    }
}