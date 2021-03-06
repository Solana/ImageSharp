﻿// <copyright file="FileTestBase.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Tests
{
    using System.Collections.Generic;

    /// <summary>
    /// The test base class for reading and writing to files.
    /// </summary>
    public abstract class FileTestBase : TestBase
    {
        /// <summary>
        /// A collection made up of one file for each image format
        /// </summary>
        public static IEnumerable<string> DefaultFiles =
            new[]
            {
                TestImages.Bmp.Car,
                TestImages.Jpeg.Baseline.Calliphora,
                TestImages.Png.Splash,
                TestImages.Gif.Trans
            };

        /// <summary>
        /// A collection of all the bmp test images
        /// </summary>
        public static IEnumerable<string> AllBmpFiles = TestImages.Bmp.All;

        /// <summary>
        /// A collection of all the jpeg test images
        /// </summary>
        public static IEnumerable<string> AllJpegFiles = TestImages.Jpeg.All;

        /// <summary>
        /// A collection of all the png test images
        /// </summary>
        public static IEnumerable<string> AllPngFiles = TestImages.Png.All;

        /// <summary>
        /// A collection of all the gif test images
        /// </summary>
        public static IEnumerable<string> AllGifFiles = TestImages.Gif.All;

        /// <summary>
        /// The standard pixel format enumeration
        /// </summary>
        public const PixelTypes DefaultPixelType = PixelTypes.Rgba32;

        public static class Extensions
        {
            public const string Bmp = "bmp";

            public const string Jpeg = "jpg";

            public const string Png = "png";

            public const string Gif = "gif";
        }

        /// <summary>
        /// The collection of image files to test against.
        /// </summary>
        protected static readonly List<TestFile> Files = new List<TestFile>
        {
               TestFile.Create(TestImages.Jpeg.Baseline.Calliphora),
            // TestFile.Create(TestImages.Jpeg.Baseline.Turtle), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Jpeg.Baseline.Ycck), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Jpeg.Baseline.Cmyk), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Jpeg.Baseline.Floorplan), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Jpeg.Baseline.Bad.MissingEOF), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Jpeg.Progressive.Fb), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Jpeg.Progressive.Progress), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Jpeg.Baseline.GammaDalaiLamaGray), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Jpeg.Progressive.Bad.BadEOF), // Perf: Enable for local testing only
               TestFile.Create(TestImages.Bmp.Car),
            // TestFile.Create(TestImages.Bmp.NegHeight), // Perf: Enable for local testing only
               TestFile.Create(TestImages.Png.Splash),
            // TestFile.Create(TestImages.Png.Cross), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.ChunkLength1), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.ChunkLength2), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Powerpoint), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Blur), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Indexed), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.SplashInterlaced), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Interlaced), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Filter0), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Filter1), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Filter2), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Filter3), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Filter4), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.FilterVar), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.P1), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Png.Pd), // Perf: Enable for local testing only
               TestFile.Create(TestImages.Gif.Rings),
            // TestFile.Create(TestImages.Gif.Trans), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Gif.Cheers), // Perf: Enable for local testing only
            // TestFile.Create(TestImages.Gif.Giphy) // Perf: Enable for local testing only
        };
    }
}