using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    public class Lab08Tests
    {
        [TestCase(12.123537, 12.123536, ExpectedResult = true)]
        [TestCase(1, .999999, ExpectedResult = true)]
        [TestCase(12, 13, ExpectedResult = false)]
        [TestCase(1, 10, ExpectedResult = false)]
        public bool GivenTwoDoubles_ReturnTrueIfClose(double num1, double num2) => Program.isClose(num1, num2);

        [TestCase(1, ExpectedResult = 2.54)]
        [TestCase(6, ExpectedResult = 15.24)]
        [TestCase(24, ExpectedResult = 60.96)]
        [TestCase(1234, ExpectedResult = 3134.36)]
        public double GivenInchecs_ReturnsConversionToCentimeters(double inches) => Program.InchesToCentimeters(inches);

        [TestCase(1, ExpectedResult = .9144)]
        [TestCase(6, ExpectedResult = 5.4864)]
        [TestCase(24, ExpectedResult = 21.9456)]
        [TestCase(1234, ExpectedResult = 1128.3696)]
        public double GivenYards_ReturnsConversionToMeters(double yards) => Program.YardsToMeters(yards);

        [TestCase(1, ExpectedResult = 1.609344)]
        [TestCase(6, ExpectedResult = 9.656064)]
        [TestCase(24, ExpectedResult = 38.624256)]
        [TestCase(100, ExpectedResult = 160.9344)]
        public double GivenMiles_ReturnsConversionToKilometers(double miles) => Program.MilesToKilometers(miles);
    }
}
