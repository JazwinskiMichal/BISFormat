using BISFormat.Models;

namespace BISFormat.Interfaces
{
    public interface IStringTest
    {
        /// <summary>
        /// Method to check does given string matches given conditions
        /// </summary>
        /// <param name="text">Text to be checked</param>
        /// <param name="conditionSwitch">Condition switch</param>
        /// <param name="condition">given condition</param>
        /// <param name="caseSensitive">true if check with case sensitive</param>
        /// <returns>True if given string matches given conditions</returns>
        bool TestString(string text, StringTestEnum conditionSwitch, string condition, bool caseSensitive);
    }
}
