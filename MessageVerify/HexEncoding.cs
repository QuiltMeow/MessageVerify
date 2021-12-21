using System;
using System.Text.RegularExpressions;

public class HexEncoding
{
    public static byte[] GetBytes(string hexString)
    {
        string newString = string.Empty;
        char c;

        for (int i = 0; i < hexString.Length; ++i)
        {
            c = hexString[i];
            if (isHexDigit(c))
            {
                newString += c;
            }
        }

        if (newString.Length % 2 != 0)
        {
            newString = newString.Substring(0, newString.Length - 1);
        }

        int byteLength = newString.Length / 2;
        byte[] bytes = new byte[byteLength];
        string hex;
        int j = 0;
        for (int i = 0; i < bytes.Length; ++i)
        {
            hex = new string(new char[] { newString[j], newString[j + 1] });
            bytes[i] = HexToByte(hex);
            j = j + 2;
        }
        return bytes;
    }

    public static bool isHexDigit(char c)
    {
        int numChar;
        int numA = Convert.ToInt32('A');
        int num1 = Convert.ToInt32('0');
        c = char.ToUpper(c);
        numChar = Convert.ToInt32(c);
        if (numChar >= numA && numChar < (numA + 6))
        {
            return true;
        }
        if (numChar >= num1 && numChar < (num1 + 10))
        {
            return true;
        }
        return false;
    }

    public static string ToStringFromAscii(byte[] bytes)
    {
        char[] ret = new char[bytes.Length];
        for (int i = 0; i < bytes.Length; ++i)
        {
            if (bytes[i] < 32 && bytes[i] >= 0)
            {
                ret[i] = '.';
            }
            else
            {
                int chr = bytes[i] & 0xFF;
                ret[i] = (char)chr;
            }
        }
        return new string(ret);
    }

    private static byte HexToByte(string hex)
    {
        if (hex.Length > 2 || hex.Length <= 0)
        {
            throw new ArgumentException("HEX 長度必須是 1 ~ 2 之間");
        }
        byte newByte = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        return newByte;
    }

    public static bool onlyHexInString(string data)
    {
        return Regex.IsMatch(data, @"\A\b[0-9a-fA-F]+\b\Z");
    }
}