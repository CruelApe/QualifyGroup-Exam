using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QG.Exam
{
    /// <summary>
    /// Client: I’ve got 3 questions which I’m happy with to see how any candidate thinks through things logically.  
    /// 1. How to find all possible substring of a given string?
    /// 2. How to remove duplicate characters from a string?
    /// 3. How to count the occurrence of each character in a string?
    /// </summary>
    public static class Requirements
    {

        /// <summary>
        /// Gets all the substring of a value.
        /// </summary>
        /// <param name="value">The value to get the substring from.</param>
        public static void GetAllSubstring(string value)
        {
            // Gets the length value of the param.
            int valueLength = value.Length;

            // Iterates tru the outer block of the string
            // to get the startIndex
            for (int i = 0; i < valueLength; i++) 
            { 
                // Iterates tru the inner block of the string 
                // to get the new length of the string.
                for (int j = 1; j <= valueLength - i; j++) 
                { 
                    // Displays the substring in new line.
                    Console.WriteLine(value.Substring(i, j)); 
                }
            }
        }

        /// <summary>
        /// Removes the duplicate characters from a value
        /// </summary>
        /// <param name="value">The value to remove the duplicates from.</param>
        public static void RemoveDuplicateCharacters(string value)
        {
            // We can use the Distinct() function from LINQ 
            // to remove duplicate characters from a value.
            Console.WriteLine(new string(value.Distinct().ToArray()));

        }

        /// <summary>
        /// Count the occurrence of each character of a value.
        /// </summary>
        /// <param name="value">The value to count the occurrence from.</param>
        public static void OccurenceCount(string value)
        {
            // Groups the value's character into a LINQ query 
            // and returns its count per each character
            var groupedCharacters = from character in value.Replace(" ", "").ToLower().ToCharArray()
                                    group character by character into collection
                                    select new { collection.Key, Count = collection.Count() };

            // Iterate and display the output from the query
            foreach (var groupedCharacter in groupedCharacters)
            {
                Console.WriteLine(string.Format("Char: {0} ({1})"
                    , groupedCharacter.Key.ToString()
                    , groupedCharacter.Count));
            }
        }
    }
}
