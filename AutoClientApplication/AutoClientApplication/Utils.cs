using System;

namespace AutoClientApplication {

    class Utils {

        public class Pair<T, U> {
            public Pair() {}

            public Pair(T first, U second) {
                First = first;
                Second = second;
            }

            public T First { get; set; }
            public U Second { get; set; }
        };

        public static string SecondsToMinuteFormat(int seconds) {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return SecondsToHours(time);
        }

        public static string SecondsToHours(TimeSpan time) {
            return time.Hours > 0 ? string.Format("{0:D2}h:{1:D2}m:{2:D2}s", time.Hours, time.Minutes, time.Seconds) :
                   time.Minutes > 0 ? string.Format("{0:D2}m:{1:D2}s", time.Minutes, time.Seconds) :
                                      string.Format("{0:D2}s", time.Seconds);
        }
    }
}
