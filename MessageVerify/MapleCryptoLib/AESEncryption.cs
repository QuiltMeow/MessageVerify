using System;
using System.IO;
using System.Security.Cryptography;

public class AESEncryption
{
    public static byte[] AESCrypt(byte[] IV, byte[] data, int length)
    {
        return AESCrypt(IV, data, length, CryptoConstant.getTrimmedUserKey());
    }

    public static byte[] AESCrypt(byte[] IV, byte[] data, int length, byte[] key)
    {
        AesManaged crypto = new AesManaged();
        crypto.KeySize = 256;
        crypto.Key = key;
        crypto.Mode = CipherMode.ECB; // 單區塊加密 模式不影響輸出

        MemoryStream memStream = new MemoryStream();
        CryptoStream cryptoStream = new CryptoStream(memStream, crypto.CreateEncryptor(), CryptoStreamMode.Write);

        int remaining = length;
        int offsetLength = 0x5B0;
        int start = 0;
        while (remaining > 0)
        {
            byte[] currentIV = MapleCrypto.multiplyByte(IV, 4, 4);
            if (remaining < offsetLength)
            {
                offsetLength = remaining;
            }
            for (int i = start; i < start + offsetLength; ++i)
            {
                if ((i - start) % currentIV.Length == 0)
                {
                    cryptoStream.Write(currentIV, 0, currentIV.Length);
                    byte[] newIV = memStream.ToArray();
                    Array.Copy(newIV, currentIV, currentIV.Length);
                    memStream.Position = 0;
                }
                data[i] ^= currentIV[(i - start) % currentIV.Length];
            }
            start += offsetLength;
            remaining -= offsetLength;
            offsetLength = 0x5B4;
        }

        try
        {
            cryptoStream.Dispose();
            memStream.Dispose();
        }
        catch (Exception ex)
        {
            Console.WriteLine("丟棄 AES 串流時發生例外狀況 : " + ex);
        }
        return data;
    }
}