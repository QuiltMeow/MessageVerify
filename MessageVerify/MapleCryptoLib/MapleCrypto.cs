using System;

public class MapleCrypto
{
    private short _mapleVersion;

    public MapleCrypto(byte[] IV, short mapleVersion)
    {
        this.IV = IV;
        _mapleVersion = mapleVersion;
    }

    public byte[] IV { get; set; }

    public static byte[] getNewIV(byte[] oldIV)
    {
        byte[] start = new byte[4] { 0xf2, 0x53, 0x50, 0xc6 };
        for (int i = 0; i < 4; ++i)
        {
            shuffle(oldIV[i], start);
        }
        return start;
    }

    public static int getPacketLength(int packetHeader)
    {
        return getPacketLength(BitConverter.GetBytes(packetHeader));
    }

    public static int getPacketLength(byte[] packetHeader)
    {
        if (packetHeader.Length < 4)
        {
            return -1;
        }
        return (packetHeader[0] + (packetHeader[1] << 8)) ^ (packetHeader[2] + (packetHeader[3] << 8));
    }

    public static byte[] multiplyByte(byte[] input, int count, int multiply)
    {
        byte[] ret = new byte[count * multiply];
        for (int i = 0; i < ret.Length; ++i)
        {
            ret[i] = input[i % count];
        }
        return ret;
    }

    public static byte[] shuffle(byte inputByte, byte[] start)
    {
        byte a = start[1];
        byte b = a;
        uint c, d;
        b = CryptoConstant.bShuffle[b];
        b -= inputByte;
        start[0] += b;
        b = start[2];
        b ^= CryptoConstant.bShuffle[inputByte];
        a -= b;
        start[1] = a;
        a = start[3];
        b = a;
        a -= start[0];
        b = CryptoConstant.bShuffle[b];
        b += inputByte;
        b ^= start[2];
        start[2] = b;
        a += CryptoConstant.bShuffle[inputByte];
        start[3] = a;

        c = (uint)(start[0] + start[1] * 0x100 + start[2] * 0x10000 + start[3] * 0x1000000);
        d = c;
        c >>= 0x1D;
        d <<= 0x03;
        c |= d;
        start[0] = (byte)(c % 0x100);
        c /= 0x100;
        start[1] = (byte)(c % 0x100);
        c /= 0x100;
        start[2] = (byte)(c % 0x100);
        start[3] = (byte)(c / 0x100);

        return start;
    }

    public bool checkPacketToServer(byte[] packet)
    {
        int a = packet[0] ^ IV[2];
        int b = _mapleVersion;
        int c = packet[1] ^ IV[3];
        int d = _mapleVersion >> 8;
        return a == b && c == d;
    }

    public void crypt(byte[] data)
    {
        AESEncryption.AESCrypt(IV, data, data.Length);
        updateIV();
    }

    public byte[] getHeaderToClient(int size)
    {
        byte[] header = new byte[4];
        int a = IV[3] * 0x100 + IV[2];
        a ^= -(_mapleVersion + 1);
        int b = a ^ size;
        header[0] = (byte)(a % 0x100);
        header[1] = (byte)((a - header[0]) / 0x100);
        header[2] = (byte)(b ^ 0x100);
        header[3] = (byte)((b - header[2]) / 0x100);
        return header;
    }

    public byte[] getHeaderToServer(int size)
    {
        byte[] header = new byte[4];
        int a = IV[3] * 0x100 + IV[2];
        a = a ^ (_mapleVersion);
        int b = a ^ size;
        header[0] = Convert.ToByte(a % 0x100);
        header[1] = Convert.ToByte(a / 0x100);
        header[2] = Convert.ToByte(b % 0x100);
        header[3] = Convert.ToByte(b / 0x100);
        return header;
    }

    public void updateIV()
    {
        IV = getNewIV(IV);
    }
}