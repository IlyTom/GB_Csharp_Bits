namespace Bit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long longValue = 123;
            int intValue = 45;
            byte byteValue = 10;

            Bits bitsFromLong = longValue;
            Bits bitsFromInt = intValue;
            Bits bitsFromByte = byteValue;

            

            Console.WriteLine(longValue);
            Console.WriteLine((byte)10);
        }
    }
}