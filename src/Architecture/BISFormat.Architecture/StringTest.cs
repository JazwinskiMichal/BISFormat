using BISFormat.Interfaces;
using BISFormat.Models;

namespace BISFormat.Architecture
{
    public class StringTest : IStringTest
    {
        public bool TestString(string text, StringTestEnum conditionSwitch, string condition, bool caseSensitive)
        {
            bool result = false;
            StringComparison stringComparison = caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

            if(!string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(condition))
            {
                switch (conditionSwitch)
                {
                    case StringTestEnum.IsEqual:
                        result = text.Equals(condition, stringComparison);
                        break;
                    case StringTestEnum.StartsWith:
                        result = text.StartsWith(condition, stringComparison);
                        break;
                    case StringTestEnum.EndsWith:
                        result = text.EndsWith(condition, stringComparison);
                        break;
                    case StringTestEnum.Contains:
                        result = text.Contains(condition, stringComparison);
                        break;
                    default:
                        break;
                }
            }

            return result;
        }
    }
}
