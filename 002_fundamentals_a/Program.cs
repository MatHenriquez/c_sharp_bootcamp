public class DataType
{
    // Integers
    sbyte sShortNumber = 127;                   // 8 bits, signed (- or +)
    byte byteNumber = 255;                      // 8 bits, unsigned (0 or +)
    short shortNumber = 32767;                  // 16 bits, signed
    ushort uShortNumber = 65535;                // 16 bits, unsigned
    int intNumber = 2147483647;                 // 32 bits, signed
    uint uintNumber = 2147483648;               // 32 bits, unsigned
    long longNumber = 922564415646;             // 64 bits, signed
    ulong ulongNumber = 9225644156465555555;    // 64 bits, unsigned

    // Rational numbers
    float floatNumber = 15.05f;                 // 32 bits
    double doubleNumber = 10.3232;              // 64 bits
    decimal decimalNumber = 100.0254m;          // 128 bits
}
