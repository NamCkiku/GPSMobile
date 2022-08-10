using BA_Mobile.Core.Resources;
using System;

namespace BA_Mobile.Core.Extension
{
    public static class TimeExtension
    {
        public static string SecondsToString(this int secs)
        {
            TimeSpan time = TimeSpan.FromSeconds(secs);

            string answer = string.Empty;

            if (time.Days > 0)
            {
                if (time.Days > 1)
                {
                    answer = string.Format("{0} {1} ", time.Days, CommonResource.Common_Label_Day);
                }
                else
                {
                    answer = string.Format("{0} {1} ", time.Days, CommonResource.Common_Label_Day);
                }
            }

            if (time.Hours > 0)
            {
                if (time.Hours > 1)
                {
                    answer += string.Format("{0} {1} ", time.Hours, CommonResource.Common_Label_Hour);
                }
                else
                {
                    answer += string.Format("{0} {1} ", time.Hours, CommonResource.Common_Label_Hour);
                }
            }
            if (time.Minutes > 0 || time.Minutes == 0)
            {
                if (time.Minutes > 1)
                {
                    answer += string.Format("{0} {1}", time.Minutes, CommonResource.Common_Label_Minute);
                }
                else
                {
                    answer += string.Format("{0} {1}", time.Minutes, CommonResource.Common_Label_Minute);
                }
            }
            else
            {
                answer += string.Format("{0} {1}", 0, CommonResource.Common_Label_Minute);
            }

            return answer;
        }

        public static string SecondsToStringShort(this int secs)
        {
            TimeSpan time = TimeSpan.FromSeconds(secs);

            string answer;

            if (time.Days > 0)
            {
                answer = string.Format("{0}{1} {2}{3} {4}{5}",
                               time.Days, "N",
                               time.Hours, "H",
                               time.Minutes, "P");
            }
            else if (time.Hours > 0)
            {
                answer = string.Format("{0}{1} {2}{3}",
                               time.Hours, "H",
                               time.Minutes, "P");
            }
            else
            {
                answer = string.Format("{0}{1}",
                               time.Minutes, "P");
            }

            return answer;
        }

        public static string MinutesToStringShort(this int minutes)
        {
            TimeSpan time = TimeSpan.FromMinutes(minutes);

            string answer;

            if (time.Days > 0)
            {
                answer = string.Format("{0} {1} {2} {3} {4} {5}",
                              time.Days, CommonResource.Common_Label_Days,
                              time.Hours, CommonResource.Common_Label_Hours,
                              time.Minutes, CommonResource.Common_Label_Minutes);
            }
            else if (time.Hours > 0)
            {
                answer = string.Format("{0} {1} {2} {3}",
                               time.Hours, CommonResource.Common_Label_Hours,
                               time.Minutes, CommonResource.Common_Label_Minutes);
            }
            else
            {
                answer = string.Format("{0} {1}",
                               time.Minutes, CommonResource.Common_Label_Minutes);
            }

            return answer;
        }
    }
}