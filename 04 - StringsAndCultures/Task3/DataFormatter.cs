using System;
using System.Globalization;
using System.Collections.Generic;

namespace Task3
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-05 12:11:02</DateOfCreation>
    /// <summary>
    /// Contains methods necessary for formatting the given values according to the entered cultures.
    /// </summary>
    public class DataFormatter
    {
        private const string AlignmentParameters = " {0, -8} | {1, -22} | {2, -13} |";
        private const string FormattingParameter = "N";

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-10-07 13:07:24</DateOfCreation>
        /// <summary>
        /// Contains some of the Microsoft locale Ids.
        /// </summary>
        public enum LocaleIDs
        {
            /// <summary>
            /// Locale ID of English (United States).
            /// </summary>
            US = 1033,
            /// <summary>
            /// Locale ID of English (United Kingdom). 
            /// </summary>
            GB = 2057,
            /// <summary>
            /// Locale ID of Russian.
            /// </summary>
            RU = 1049,
            /// <summary>
            /// Locale ID of French Standard.
            /// </summary>
            FR = 1036,
            /// <summary>
            /// Locale ID of German Standard.
            /// </summary>
            DE = 1031
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:11:02</DateOfCreation>
        /// <summary>
        /// Returns data formatted according to selected cultures.
        /// </summary>
        /// <param name="arrayOfStrings">String array.</param>
        /// <returns>Formatted string array.</returns>
        public string[] GetFormattedValues(string[] arrayOfStrings)
        {
            List<string> listOfFormattedValues = new List<string>();
            foreach (var element in arrayOfStrings)
            {
                int localeID = FindValidCulture(element);
                if (Enum.IsDefined(typeof(LocaleIDs), localeID))
                {
                    string formattedValues = FormatValues(localeID);
                    listOfFormattedValues.Add(formattedValues);
                }
            }
            return listOfFormattedValues.ToArray();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:11:02</DateOfCreation>
        /// <summary>
        /// Checks whether the given value is a valid name of a culture or not.
        /// </summary>
        /// <param name="cultureName">Culture name.</param>
        /// <returns>The name of a culture.</returns>
        public int FindValidCulture(string cultureName)
        {
            int localeID = 0;
            switch (cultureName)
            {
                case "US":
                    localeID = (int)LocaleIDs.US;
                    break;
                case "GB":
                    localeID = (int)LocaleIDs.GB;
                    break;
                case "RU":
                    localeID = (int)LocaleIDs.RU;
                    break;
                case "FR":
                    localeID = (int)LocaleIDs.FR;
                    break;
                case "DE":
                    localeID = (int)LocaleIDs.DE;
                    break;
                default:
                    break;
            }
            return localeID;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:11:02</DateOfCreation>
        /// <summary>
        /// Formats required information according to a locale ID.
        /// </summary>
        /// <param name="localeID">Locale ID.</param>
        /// <returns>Formatted string values.</returns>
        public string FormatValues(int localeID)
        {
            double value = 12345.6789;
            DateTime localDate = DateTime.Now;
            var country = new CultureInfo(localeID);
            var dateTime = localDate.ToString(country);
            var number = value.ToString(FormattingParameter, CultureInfo.GetCultureInfo(localeID));
            var formattedValues = String.Format(AlignmentParameters, country.Name, dateTime, number);
            return formattedValues;
        }
    }
}
