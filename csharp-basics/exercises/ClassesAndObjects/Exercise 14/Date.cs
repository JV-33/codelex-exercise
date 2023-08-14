using System;
using System.Globalization;

namespace Exercise_14
{
	public class Date
	{
        private const string DutchCultureCode = "nl-NL";

        /// <summary>
        /// Returns the name of a weekday in Dutch for a given date.
        /// </summary>

        public static  string GetCurantData(int year, int month, int day)
		{
            DateTime dt = new DateTime(year, month, day);
            CultureInfo dutchCulture = CultureInfo.GetCultureInfo(DutchCultureCode);
            return dutchCulture.DateTimeFormat.GetDayName(dt.DayOfWeek).ToLower();
        }
	}
}

