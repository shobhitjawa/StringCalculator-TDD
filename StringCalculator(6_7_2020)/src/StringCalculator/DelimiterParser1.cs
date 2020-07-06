using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator
{
    public interface DelimiterParser1
    {
        /// <summary>
        /// Takes the string sequence then extracts and appends any custom delimiters to the array of valid delimiters 
        /// </summary>
        /// <param name="stringNumbers">The numbers string</param>
        /// <remarks>
 
        /// </remarks>
        IEnumerable<string> Parse(string stringNumbers);
    }
}
