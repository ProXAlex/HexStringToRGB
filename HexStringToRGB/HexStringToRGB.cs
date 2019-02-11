using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexStringToRGB
{
    public class HexStringToRGB
    {
        public static RGB ConvertHexToRGB(string hexString)
        {
            if (hexString == null)
                throw new ArgumentNullException("Argument cannot be null");

            if (hexString.Length < 7 || hexString.Length > 7 || hexString[0] != '#')
                throw new ArgumentException("Argument can only be a hex value color");

            for (int i = 1; i < hexString.Length; i++)
            {
                if (char.IsDigit(hexString[i]))
                    continue;
               
                if (char.ToUpper(hexString[i]) == 'A'
                   || char.ToUpper(hexString[i]) == 'B'
                   || char.ToUpper(hexString[i]) == 'C'
                   || char.ToUpper(hexString[i]) == 'D'
                   || char.ToUpper(hexString[i]) == 'E'
                   || char.ToUpper(hexString[i]) == 'F')
                    continue;

                    throw new ArgumentException("Argument can only be a hex value color");
            }


            byte r = Convert.ToByte(hexString.Substring(1, 2), 16);
            byte g = Convert.ToByte(hexString.Substring(3, 2), 16);
            byte b = Convert.ToByte(hexString.Substring(5, 2), 16);

            return new RGB(r, g, b);
        }
    }

    public class RGB
    {


        public RGB()
        {
        }

        public RGB(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public override bool Equals(object obj)
        {
            var rGB = obj as RGB;
            return rGB != null &&
                   R == rGB.R &&
                   G == rGB.G &&
                   B == rGB.B;
        }
    }
}
