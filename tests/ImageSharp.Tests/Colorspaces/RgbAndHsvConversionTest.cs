﻿namespace ImageSharp.Tests.Colorspaces
{
    using System.Collections.Generic;

    using ImageSharp.ColorSpaces;
    using ImageSharp.ColorSpaces.Conversion;

    using Xunit;

    /// <summary>
    /// Tests <see cref="Rgb"/>-<see cref="Hsv"/> conversions.
    /// </summary>
    /// <remarks>
    /// Test data generated using:
    /// <see href="http://www.colorhexa.com"/>
    /// </remarks>
    public class RgbAndHsvConversionTest
    {
        private static readonly IEqualityComparer<float> FloatRoundingComparer = new FloatRoundingComparer(4);

        private static readonly ColorSpaceConverter Converter = new ColorSpaceConverter();

        /// <summary>
        /// Tests conversion from <see cref="Hsv"/> to <see cref="Rgb"/>.
        /// </summary>
        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0)]
        [InlineData(0, 0, 1, 1, 1, 1)]
        [InlineData(360, 1, 1, 1, 0, 0)]
        [InlineData(0, 1, 1, 1, 0, 0)]
        [InlineData(120, 1, 1, 0, 1, 0)]
        [InlineData(240, 1, 1, 0, 0, 1)]
        public void Convert_Hsv_To_Rgb(float h, float s, float v, float r, float g, float b)
        {
            // Arrange
            Hsv input = new Hsv(h, s, v);

            // Act
            Rgb output = Converter.ToRgb(input);

            // Assert
            Assert.Equal(Rgb.DefaultWorkingSpace, output.WorkingSpace);
            Assert.Equal(r, output.R, FloatRoundingComparer);
            Assert.Equal(g, output.G, FloatRoundingComparer);
            Assert.Equal(b, output.B, FloatRoundingComparer);
        }

        /// <summary>
        /// Tests conversion from <see cref="Rgb"/> to <see cref="Hsv"/>.
        /// </summary>
        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0)]
        [InlineData(1, 1, 1, 0, 0, 1)]
        [InlineData(1, 0, 0, 0, 1, 1)]
        [InlineData(0, 1, 0, 120, 1, 1)]
        [InlineData(0, 0, 1, 240, 1, 1)]
        public void Convert_Rgb_To_Hsv(float r, float g, float b, float h, float s, float v)
        {
            // Arrange
            Rgb input = new Rgb(r, g, b);

            // Act
            Hsv output = Converter.ToHsv(input);

            // Assert
            Assert.Equal(h, output.H, FloatRoundingComparer);
            Assert.Equal(s, output.S, FloatRoundingComparer);
            Assert.Equal(v, output.V, FloatRoundingComparer);
        }
    }
}
