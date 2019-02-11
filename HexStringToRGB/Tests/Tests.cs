using System;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace HexStringToRGB.Tests
{
    public class Tests
    {
        [Test]
        public void AddOrChangeUrlParameterTest()
        {
            Assert.AreEqual(HexStringToRGB.ConvertHexToRGB("#FF9933"), new RGB(255, 153, 51));
            Assert.AreEqual(HexStringToRGB.ConvertHexToRGB("#ff9933"), new RGB(255, 153, 51));
        }


        [Test]
        public void AddOrChangeUrlParameterTest_ArgumentNullEx()
        {
            Assert.Throws<ArgumentNullException>(() => HexStringToRGB.ConvertHexToRGB(null));
        }

        [Test]
        public void AddOrChangeUrlParameterTest_ArgumentEx()
        {
            Assert.Throws<ArgumentException>(() => HexStringToRGB.ConvertHexToRGB(""));
            Assert.Throws<ArgumentException>(() => HexStringToRGB.ConvertHexToRGB("#11"));
            Assert.Throws<ArgumentException>(() => HexStringToRGB.ConvertHexToRGB("#11111111111111"));
            Assert.Throws<ArgumentException>(() => HexStringToRGB.ConvertHexToRGB("#HH1111"));
            Assert.Throws<ArgumentException>(() => HexStringToRGB.ConvertHexToRGB("#11#1ff"));
            Assert.Throws<ArgumentException>(() => HexStringToRGB.ConvertHexToRGB("Fff9933"));

        }

    }
}


