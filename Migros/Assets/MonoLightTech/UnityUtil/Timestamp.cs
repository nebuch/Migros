using System;

namespace MonoLightTech.UnityUtil
{
    public static class Timestamp
    {
        public static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

        public static int ToUnix(DateTime time) { return (int)(time - UnixEpoch).TotalSeconds; }
        public static int To(DateTime time, DateTime epoch) { return (int)(time - epoch).TotalSeconds; }

        public static DateTime FromUnix(int timestamp) { return UnixEpoch.AddSeconds(timestamp); }
        public static DateTime From(int timestamp, DateTime epoch) { return epoch.AddSeconds(timestamp); }

        public static long ToUnixMs(DateTime time) { return (long)((time - UnixEpoch).TotalSeconds * 1000); }
        public static long ToMs(DateTime time, DateTime epoch) { return (long)((time - epoch).TotalSeconds * 1000); }

        public static DateTime FromUnixMs(long timestamp) { return UnixEpoch.AddSeconds(timestamp); }
        public static DateTime FromMs(long timestamp, DateTime epoch) { return epoch.AddSeconds(timestamp); }
    }
}