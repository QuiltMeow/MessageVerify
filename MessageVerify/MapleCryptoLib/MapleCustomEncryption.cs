public class MapleCustomEncryption
{
    public static void decrypt(byte[] data)
    {
        int size = data.Length;
        int j;
        byte a, b, c;
        for (int i = 0; i < 3; ++i)
        {
            a = 0;
            b = 0;
            for (j = size; j > 0; --j)
            {
                c = data[j - 1];
                c = rol(c, 3);
                c ^= 0x13;
                a = c;
                c ^= b;
                c = (byte)(c - j);
                c = ror(c, 4);
                b = a;
                data[j - 1] = c;
            }
            a = 0;
            b = 0;
            for (j = size; j > 0; --j)
            {
                c = data[size - j];
                c -= 0x48;
                c ^= 0xFF;
                c = rol(c, j);
                a = c;
                c ^= b;
                c = (byte)(c - j);
                c = ror(c, 3);
                b = a;
                data[size - j] = c;
            }
        }
    }

    public static void encrypt(byte[] data)
    {
        int size = data.Length;
        int j;
        byte a, c;
        for (int i = 0; i < 3; ++i)
        {
            a = 0;
            for (j = size; j > 0; --j)
            {
                c = data[size - j];
                c = rol(c, 3);
                c = (byte)(c + j);
                c ^= a;
                a = c;
                c = ror(a, j);
                c ^= 0xFF;
                c += 0x48;
                data[size - j] = c;
            }
            a = 0;
            for (j = data.Length; j > 0; --j)
            {
                c = data[j - 1];
                c = rol(c, 4);
                c = (byte)(c + j);
                c ^= a;
                a = c;
                c ^= 0x13;
                c = ror(c, 3);
                data[j - 1] = c;
            }
        }
    }

    public static byte rol(byte value, int num)
    {
        int highBit;
        for (int i = 0; i < num; ++i)
        {
            highBit = ((value & 0x80) != 0 ? 1 : 0);
            value <<= 1;
            value |= (byte)highBit;
        }
        return value;
    }

    public static byte ror(byte value, int num)
    {
        int lowBit;
        for (int i = 0; i < num; ++i)
        {
            lowBit = ((value & 1) != 0 ? 1 : 0);
            value >>= 1;
            value |= (byte)(lowBit << 7);
        }
        return value;
    }
}