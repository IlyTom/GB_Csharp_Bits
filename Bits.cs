using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit
{
    internal class Bits
    {
        private byte value;

        public Bits(byte value)
        {
            this.value = value;
        }

        public static implicit operator Bits(long value)
        {
            return new Bits((byte)value);
        }

        public static implicit operator Bits(int value)
        {
            return new Bits((byte)value);
        }

        public static implicit operator Bits(byte value)
        {
            return new Bits(value);
        }
        public override string ToString()
        {
            return $"Bits: {this.value}";
        }
    }
}
