namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Provides various static methods to manipulate string data.
    /// <list type="bullet">
    /// <item> 
    /// <description>ToMd5Hash,</description> 
    /// </item> 
    /// <item> 
    /// <description>ToBoolean,</description> 
    /// </item>
    /// <item> 
    /// <description>ToShort,</description> 
    /// </item> 
    /// <item> 
    /// <description>ToInteger,</description> 
    /// </item>
    /// <item> 
    /// <description>ToLong,</description> 
    /// </item>
    /// <item> 
    /// <description>ToDateTime,</description> 
    /// </item>
    /// <item> 
    /// <description>CapitalizeFirstLetter,</description> 
    /// </item>
    /// <item>
    /// <description>ConvertCyrillicToLatinLetters,</description>
    /// </item>
    /// <item>
    /// <description>ConvertLatinToCyrillicKeyboard,</description>
    /// </item>
    /// <item>
    /// <description>ToValidUsername,</description>
    /// </item>
    /// <item>
    /// <description>ToValidLatinFileName,</description>
    /// </item>
    /// <item>
    /// <description>GetFirstCharacters,</description>
    /// </item>
    /// <item>
    /// <description>GetFileExtension,</description>
    /// </item>
    /// <item>
    /// <description>ToContentType,</description>
    /// </item>
    /// <item>
    /// <description>ToByteArray,</description>
    /// </item>
    /// </list> 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// A static method that converts string data to byte array and outputs hexadecimal string array.
        /// </summary>
        /// <param name="input">The string data, which the method will operate on.</param>
        /// <returns>Hexadecimal string</returns>
        public static string ToMd5Hash(this string input)
        {          
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// A static method, that checks if string input is contained in predefined array.
        /// </summary>
        /// <param name="input">The string data, which the method will operate on.</param>
        /// <returns>Boolean value</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// A static method, that converts string input to short primitive data type.
        /// </summary>
        /// <param name="input">The string data to be converted.</param>
        /// <returns>Short primitive data type, if applicable, and null, if not.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// A static method, that converts string input to integer primitive data type
        /// </summary>
        /// <param name="input">The string data to be converted.</param>
        /// <returns>Integer primitive data type, if applicable, and null, if not.</returns>     
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// A static method, that converts string input to long primitive data type
        /// </summary>
        /// <param name="input">The string data to be converted.</param>
        /// <returns>Long primitive data type, if applicable, and null, if not.</returns> 
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// A static method, that converts string input to DateTime data type
        /// </summary>
        /// <param name="input">The string data to be converted.</param>
        /// <returns>DateTime data type, if applicable, and null, if not.</returns> 
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// A static method, that capitalizes the first letter of a string.
        /// </summary>
        /// <param name="input">The string, which first letter will be capitalized.</param>
        /// <returns>The input string with capital first letter.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Takes the first letter and capitalizes it. Then attatches it to the rest of the old string.
            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// A static method, that returns substring from a longer string, using predefined start and end positions.
        /// </summary>
        /// <param name="input">The string, from which the result will be derived.</param>
        /// <param name="startString">The start position of the result string.</param>
        /// <param name="endString">The end position of the result string.</param>
        /// <param name="startFrom">An index, which indicates where the search starts from (default value is 0)</param>
        /// <returns>The required substring or empty string.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);

            // Resets startFrom default value
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// A static method that converts a string with cyrillic characters into a string with latin characters.
        /// </summary>
        /// <param name="input">The string data to be converted.</param>
        /// <returns>A string composed by latin characters.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };

            // Replaces each character from the predifined bulgarianLetters array 
            // with the corresponding one from the latinRepresentationsOfBulgarianLetters array.
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// A static method that converts a string with latin characters into a string with cyrillic characters.
        /// </summary>
        /// <param name="input">The string data to be converted.</param>
        /// <returns>A string composed by latin characters.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            // Replaces each character from the predifined latinRepresentationsOfBulgarianLetters array 
            // with the corresponding one from the bulgarianLetters array.
            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// A static method, that converts string input string to a legit username.
        /// </summary>
        /// <param name="input">The string data to be converted.</param>
        /// <returns>The input string converted to valid username (string)</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// A static method, that formats string input properly and converts it to a valid file name.
        /// </summary>
        /// <param name="input">The string data to be converted.</param>
        /// <returns>The input string converted to valid file name (string)</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// A static method, that returns a specified number of characters in the beginning of the input.
        /// </summary>
        /// <param name="input">The string data to be converted.</param>
        /// <param name="charsCount">The number of character to be extracted.</param>
        /// <returns>Substring, containing the specified number of initial characters.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            // Checks, if the required characters' count is not greater than the input's length
            // and returns substring using the smaller number.
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// A static method, that returns the extension of a file.
        /// </summary>
        /// <param name="fileName">The file, which extension is to be extracted.</param>
        /// <returns>The file's extension or empty string.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            // Splits the file name by '.' and keeps the parts in an array.
            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);

            // If only one string has been extracted - no extension.
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// A static method, that return the file's content, according to its extension.
        /// </summary>
        /// <param name="fileExtension">The extension of the file upon which the method will be called.</param>
        /// <returns>Returns the content of the corresponding file, or "application/octet-stream", if unknown. </returns>
        public static string ToContentType(this string fileExtension)
        {
            // Creates a dictionary with keys - file extensions and values - content of the corresponding extension.
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };

            // Check, if the input file extension is contained in the dictionary.
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// A static method, that converts string input to a byte array.
        /// </summary>
        /// <param name="input">The string data to be converted.</param>
        /// <returns>A byte array.</returns>
        public static byte[] ToByteArray(this string input)
        {
            // Creates byte array with length, according to the input's length ( sizeof(char) = 2 ).
            var bytesArray = new byte[input.Length * sizeof(char)];

            // Coppies input to the newly created byte array with input's chars in byte representation.
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
