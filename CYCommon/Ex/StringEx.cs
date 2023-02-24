using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CYCommon.Ex
{

    public static class StringEx
    {
        public const string DefaultCryptString = "!@#$%^&*";

        public const string StructLayoutString = "[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]";

        public static string DealPath(this string dir)
        {
            return dir.IsNullOrEmpty() ? dir : ((dir[dir.Length - 1] == Path.DirectorySeparatorChar) ? dir : (dir + Path.DirectorySeparatorChar));
        }

        public static string FormatString(this int decimalcount)
        {
            if (decimalcount <= 0)
            {
                return "0";
            }

            return "0." + "0".Repet(decimalcount);
        }

        public static bool EqualsIgnoreCase(this string value, params string[] strs)
        {
            foreach (string b in strs)
            {
                if (string.Equals(value, b, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool EqualsIgnoreCase(this string value, string comparestring)
        {
            return string.Equals(value, comparestring, StringComparison.OrdinalIgnoreCase);
        }

        public static bool ToBoolean(this string s, bool def = false)
        {
            bool result;
            return bool.TryParse(s, out result) ? result : def;
        }

        public static char ToChar(this string s, char def = '\0')
        {
            char result;
            return char.TryParse(s, out result) ? result : def;
        }

        public static decimal ToDecimal(this string s, decimal def = 0m)
        {
            decimal result;
            return decimal.TryParse(s, out result) ? result : def;
        }

        public static double ToDouble(this string s, double def = 0.0)
        {
            double result;
            return double.TryParse(s, out result) ? result : def;
        }

        public static float ToFloat(this string s, float def = 0f)
        {
            float result;
            return float.TryParse(s, out result) ? result : def;
        }

        public static byte ToByte(this string s, byte def = 0)
        {
            byte result;
            return byte.TryParse(s, out result) ? result : def;
        }

        public static sbyte ToSByte(this string s, sbyte def = 0)
        {
            sbyte result;
            return sbyte.TryParse(s, out result) ? result : def;
        }

        public static short ToShort(this string s, short def = 0)
        {
            short result;
            return short.TryParse(s, out result) ? result : def;
        }

        public static ushort ToUShort(this string s, ushort def = 0)
        {
            ushort result;
            return ushort.TryParse(s, out result) ? result : def;
        }

        public static int ToInt(this string s, int def = 0)
        {
            int result;
            return int.TryParse(s, out result) ? result : def;
        }

        public static uint ToUInt(this string s, uint def = 0u)
        {
            uint result;
            return uint.TryParse(s, out result) ? result : def;
        }

        public static long ToLong(this string s, long def = 0L)
        {
            long result;
            return long.TryParse(s, out result) ? result : def;
        }

        public static ulong ToULong(this string s, ulong def = 0uL)
        {
            ulong result;
            return ulong.TryParse(s, out result) ? result : def;
        }

        public static DateTime ToDateTime(this string s, DateTime def = default(DateTime))
        {
            DateTime result;
            return DateTime.TryParse(s, out result) ? result : def;
        }

        public static DateTime ToDateTime(this string s, string formatString)
        {
            return DateTime.ParseExact(s, formatString, CultureInfo.InvariantCulture);
        }

        public static DateTime ToDateTimeEx(this string s, string formatString, DateTime def = default(DateTime))
        {
            int year = def.Year;
            int month = def.Month;
            int day = def.Day;
            int hour = def.Hour;
            int minute = def.Minute;
            int second = def.Second;
            int millisecond = def.Millisecond;
            if (formatString.Contains("yyyy"))
            {
                year = s.Substring(formatString.IndexOf("yyyy", StringComparison.CurrentCulture), 4).ToInt();
            }
            else if (formatString.Contains("yy"))
            {
                year = 2000 + s.Substring(formatString.IndexOf("yy", StringComparison.CurrentCulture), 2).ToInt();
            }

            if (formatString.Contains("MM"))
            {
                month = s.Substring(formatString.IndexOf("MM", StringComparison.CurrentCulture), 2).ToInt();
            }

            if (formatString.Contains("dd"))
            {
                day = s.Substring(formatString.IndexOf("dd", StringComparison.CurrentCulture), 2).ToInt();
            }

            if (formatString.Contains("HH"))
            {
                hour = s.Substring(formatString.IndexOf("HH", StringComparison.CurrentCulture), 2).ToInt();
            }

            if (formatString.Contains("mm"))
            {
                minute = s.Substring(formatString.IndexOf("mm", StringComparison.CurrentCulture), 2).ToInt();
            }

            if (formatString.Contains("ss"))
            {
                second = s.Substring(formatString.IndexOf("ss", StringComparison.CurrentCulture), 2).ToInt();
            }

            if (formatString.Contains("fff"))
            {
                millisecond = s.Substring(formatString.IndexOf("fff", StringComparison.CurrentCulture), 3).ToInt();
            }

            try
            {
                return new DateTime(year, month, day, hour, minute, second, millisecond);
            }
            catch
            {
                return def;
            }
        }

        public static Guid ToGuid(this string s, Guid def = default(Guid))
        {
            Guid result;
            return Guid.TryParse(s, out result) ? result : def;
        }

        public static bool IsBoolean(this string s)
        {
            bool result;
            return bool.TryParse(s, out result);
        }

        public static bool IsChar(this string s)
        {
            char result;
            return char.TryParse(s, out result);
        }

        public static bool IsDecimal(this string s)
        {
            decimal result;
            return decimal.TryParse(s, out result);
        }

        public static bool IsDouble(this string s)
        {
            double result;
            return double.TryParse(s, out result);
        }

        public static bool IsFloat(this string s)
        {
            float result;
            return float.TryParse(s, out result);
        }

        public static bool IsByte(this string s)
        {
            byte result;
            return byte.TryParse(s, out result);
        }

        public static bool IsSByte(this string s)
        {
            sbyte result;
            return sbyte.TryParse(s, out result);
        }

        public static bool IsShort(this string s)
        {
            short result;
            return short.TryParse(s, out result);
        }

        public static bool IsUShort(this string s)
        {
            ushort result;
            return ushort.TryParse(s, out result);
        }

        public static bool IsInt(this string s)
        {
            int result;
            return int.TryParse(s, out result);
        }

        public static bool IsUInt(this string s)
        {
            uint result;
            return uint.TryParse(s, out result);
        }

        public static bool IsLong(this string s)
        {
            long result;
            return long.TryParse(s, out result);
        }

        public static bool IsULong(this string s)
        {
            ulong result;
            return ulong.TryParse(s, out result);
        }

        public static bool IsDateTime(this string s)
        {
            DateTime result;
            return DateTime.TryParse(s, out result);
        }

        public static bool IsGuid(this string s)
        {
            Guid result;
            return Guid.TryParse(s, out result);
        }

        public static string Repet(this string str, int count)
        {
            if (count <= 0)
            {
                return string.Empty;
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("");
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(str);
            }

            return stringBuilder.ToString();
        }

        public static string Left(this string s, int length)
        {
            return s.IsNullOrEmpty() ? s : ((length <= s.Length) ? s.Substring(0, length) : s);
        }

        public static string Middle(this string s, int start, int length)
        {
            return s.IsNullOrEmpty() ? s : ((length <= s.Length - start) ? s.Substring(start, length) : s.Substring(start, s.Length - start));
        }

        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool IsValid(this string s)
        {
            return !string.IsNullOrEmpty(s);
        }

        public static string TrimToMaxLength(this string value, int maxLength)
        {
            return (value == null || value.Length <= maxLength) ? value : value.Substring(0, maxLength);
        }

        public static string IfEmpty(this string value, string defaultValue)
        {
            return value.IsNullOrEmpty() ? defaultValue : value;
        }

        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        public static string Right(this string s, int length)
        {
            if (s.IsNullOrEmpty())
            {
                return s;
            }

            return (length >= s.Length) ? s : s.Substring(s.Length - length, length);
        }

        public static bool IsNumber(this string s)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.Match(s).Success;
        }

        public static bool IsNumberWithSign(this string s)
        {
            Regex regex = new Regex("^[+-]?[0-9]+$");
            return regex.Match(s).Success;
        }

        public static bool HasCnChar(this string s)
        {
            Regex regex = new Regex("[一-龥]");
            return regex.Match(s).Success;
        }

        public static string Md5String(this string s)
        {
            return s.Md5String(Encoding.UTF8).ToUpper();
        }

        private static string Md5String(this string s, Encoding encode)
        {
            MD5 mD = MD5.Create();
            try
            {
                byte[] array = mD.ComputeHash(encode.GetBytes(s));
                StringBuilder stringBuilder = new StringBuilder();
                byte[] array2 = array;
                foreach (byte b in array2)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }

                return stringBuilder.ToString();
            }
            finally
            {
                mD.Dispose();
            }
        }

        public static string DesEncrypt(this string s, string key = "")
        {
            try
            {
                string text = key + "!@#$%^&*";
                byte[] bytes = Encoding.UTF8.GetBytes(text.Substring(0, 8));
                byte[] rgbIV = bytes;
                byte[] bytes2 = Encoding.UTF8.GetBytes(s);
                DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(bytes, rgbIV), CryptoStreamMode.Write);
                cryptoStream.Write(bytes2, 0, bytes2.Length);
                cryptoStream.FlushFinalBlock();
                return Convert.ToBase64String(memoryStream.ToArray());
            }
            catch
            {
                return "";
            }
        }

        public static string DesDecrypt(this string s, string key = "")
        {
            try
            {
                string text = key + "!@#$%^&*";
                byte[] bytes = Encoding.UTF8.GetBytes(text.Substring(0, 8));
                byte[] rgbIV = bytes;
                byte[] array = Convert.FromBase64String(s);
                DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Write);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
            catch
            {
                return "";
            }
        }

        public static string MyEncrypt(this string s, string key = "")
        {
            try
            {
                string text = key + "!@#$%^&*";
                byte[] bytes = Encoding.UTF8.GetBytes(text.Substring(0, 8));
                byte[] rgbIV = bytes;
                byte[] bytes2 = Encoding.UTF8.GetBytes(s);
                DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(bytes, rgbIV), CryptoStreamMode.Write);
                cryptoStream.Write(bytes2, 0, bytes2.Length);
                cryptoStream.FlushFinalBlock();
                string text2 = Convert.ToBase64String(memoryStream.ToArray());
                int num = 0;
                int num2 = text2.Length - 1;
                while (num2 >= 0 && text2[num2] == '=')
                {
                    num++;
                    num2--;
                }

                return text2.Left(text2.Length - num) + num;
            }
            catch
            {
                return "";
            }
        }

        public static string MyDecrypt(this string s, string key = "")
        {
            try
            {
                string text = key + "!@#$%^&*";
                byte[] bytes = Encoding.UTF8.GetBytes(text.Substring(0, 8));
                byte[] rgbIV = bytes;
                int num = s.Right(1).ToInt();
                s = s.Left(s.Length - 1);
                for (int i = 0; i < num; i++)
                {
                    s += "=";
                }

                byte[] array = Convert.FromBase64String(s);
                DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Write);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
            catch
            {
                return "";
            }
        }

        public static bool IsIP4(this string s)
        {
            string[] array = s.Split(".");
            if (array.Length != 4)
            {
                return false;
            }

            string[] array2 = array;
            foreach (string text in array2)
            {
                if (!text.Trim().IsNumber())
                {
                    return false;
                }

                if (text.Trim().ToInt() < 0)
                {
                    return false;
                }

                if (text.Trim().ToInt() > 255)
                {
                    return false;
                }
            }

            return true;
        }

        public static string[] Split(this string s, string separator, bool ignoreEmpty = false)
        {
            string[] array = s.Split(new string[1]
            {
                separator
            }, StringSplitOptions.None);
            if (!ignoreEmpty)
            {
                return array;
            }

            List<string> list = new List<string>();
            string[] array2 = array;
            foreach (string text in array2)
            {
                if (!text.IsNullOrEmpty())
                {
                    list.Add(text);
                }
            }

            return list.ToArray();
        }

        public static int SplitSeparatorCount(this string s, string separator)
        {
            if (!s.Contains(separator))
            {
                return 0;
            }

            string text = s.Replace(separator, "");
            return (s.Length - text.Length) / separator.Length;
        }

        //public static string SplitLast(this string s, string separator, bool ignoreEmpty = false)
        //{
        //    string[] array = s.Split(separator, ignoreEmpty);
        //    return (array.Length == 0) ? string.Empty : array[1];
        //}

        public static string SplitFirst(this string s, string separator, bool ignoreEmpty = false)
        {
            string[] array = s.Split(separator, ignoreEmpty);
            return (array.Length == 0) ? string.Empty : array[0];
        }

        public static string SplitIndex(this string s, string separator, int index, bool ignoreEmpty = false)
        {
            string[] array = s.Split(separator, ignoreEmpty);
            return (array.Length == 0) ? string.Empty : array[index];
        }

        public static string SplitBeforeLast(this string s, string separator)
        {
            int num = s.LastIndexOf(separator, StringComparison.Ordinal);
            return (num > 0) ? s.Substring(0, num) : s;
        }

        public static bool IsMail(this string s)
        {
            string text = s.Trim();
            if (text == "" || text.Length == 0)
            {
                return false;
            }

            if (s.SplitSeparatorCount("@") != 1)
            {
                return false;
            }

            string[] array = text.Split('@');
            if (array.Length != 2)
            {
                return false;
            }

            if (array[0] == "" || array[1] == "")
            {
                return false;
            }

            string[] array2 = array;
            foreach (string text2 in array2)
            {
                for (int j = 0; j < text2.Length; j++)
                {
                    string separator = text2.Substring(j, 1).ToLower();
                    if ("abcdefghijklmnopqrstuvwxyz_-.0123456789".SplitSeparatorCount(separator) == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static byte[] ToEnBytes(this string s, int len)
        {
            byte[] array = s.ToEncodeBytes(Encoding.ASCII);
            byte[] array2 = new byte[len];
            Array.Copy(array, 0, array2, 0, Math.Min(array.Length, len));
            return array2;
        }

        public static string ToEnString(this byte[] s)
        {
            return s.ToEncodeString(Encoding.ASCII).Trim('\0').Trim();
        }

        public static byte[] ToEncodeBytes(this string dealString, Encoding encode)
        {
            return encode.GetBytes(dealString);
        }

        public static string ToEncodeString(this byte[] dealBytes, Encoding encode)
        {
            return encode.GetString(dealBytes);
        }

        public static string Before(this string value, string x)
        {
            int num = value.IndexOf(x, StringComparison.Ordinal);
            return (num == -1) ? string.Empty : value.Substring(0, num);
        }

        public static string Between(this string value, string x, string y)
        {
            int num = value.IndexOf(x, StringComparison.Ordinal);
            int num2 = value.LastIndexOf(y, StringComparison.Ordinal);
            if (num == -1 || num == -1)
            {
                return string.Empty;
            }

            int num3 = num + x.Length;
            return (num3 >= num2) ? string.Empty : value.Substring(num3, num2 - num3).Trim();
        }

        public static string After(this string value, string x)
        {
            int num = value.LastIndexOf(x, StringComparison.Ordinal);
            if (num == -1)
            {
                return string.Empty;
            }

            int num2 = num + x.Length;
            return (num2 >= value.Length) ? string.Empty : value.Substring(num2).Trim();
        }

        public static string Base64Encode(this string value)
        {
            return value.Base64Encode(null);
        }

        public static string Base64Encode(this string value, Encoding encoding)
        {
            encoding = (encoding ?? Encoding.UTF8);
            byte[] bytes = encoding.GetBytes(value);
            return Convert.ToBase64String(bytes);
        }

        public static string Base64Decode(this string encodedValue)
        {
            return encodedValue.Base64Decode(null);
        }

        public static string Base64Decode(this string encodedValue, Encoding encoding)
        {
            encoding = (encoding ?? Encoding.UTF8);
            byte[] bytes = Convert.FromBase64String(encodedValue);
            return encoding.GetString(bytes);
        }

        public static string SHA1Hash(this string stringToHash)
        {
            if (stringToHash.IsNullOrEmpty())
            {
                return null;
            }

            byte[] bytes = Encoding.UTF8.GetBytes(stringToHash);
            byte[] inArray = new SHA1CryptoServiceProvider().ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }

        public static string RemoveLeft(this string str, int number_of_characters)
        {
            if (str.Length <= number_of_characters)
            {
                return "";
            }

            return str.Substring(number_of_characters);
        }

        public static string RemoveRight(this string str, int number_of_characters)
        {
            if (str.Length <= number_of_characters)
            {
                return "";
            }

            return str.Substring(0, str.Length - number_of_characters);
        }

        public static SecureString ToSecureString(this string u, bool makeReadOnly = true)
        {
            if (u.IsNullOrEmpty())
            {
                return null;
            }

            SecureString secureString = new SecureString();
            foreach (char c in u)
            {
                secureString.AppendChar(c);
            }

            if (makeReadOnly)
            {
                secureString.MakeReadOnly();
            }

            return secureString;
        }

        public static string ToUnSecureString(this SecureString s)
        {
            if (s == null)
            {
                return null;
            }

            IntPtr intPtr = IntPtr.Zero;
            try
            {
                intPtr = Marshal.SecureStringToGlobalAllocUnicode(s);
                return Marshal.PtrToStringUni(intPtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
            }
        }

        //public static string GZipCompress(this string input)
        //{
        //    return input.IsNullOrEmpty() ? input : Convert.ToBase64String(Encoding.Default.GetBytes(input).GZipCompress());
        //}

        //public static string GZipDecompress(this string input)
        //{
        //    return input.IsNullOrEmpty() ? input : Encoding.Default.GetString(Convert.FromBase64String(input).GZipDecompress());
        //}

        public static bool IsPureEnglishChar(string str)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            return regex.IsMatch(str);
        }

        public static bool IsNameSpace(string str)
        {
            Regex regex = new Regex("^[a-zA-Z.]+$");
            return regex.IsMatch(str) && !str.StartsWith(".") && !str.EndsWith(".") && str.SplitSeparatorCount(".") <= 3 && !str.Contains("..") && !str.Contains("...");
        }

        public static string Reverse(this string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
