﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Primitives;
using SixLabors.Shapes;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Adds extensions that allow the drawing of polygon outlines to the <see cref="Image{TPixel}"/> type.
    /// </summary>
    public static class DrawPathExtensions
    {
        /// <summary>
        /// Draws the outline of the polygon with the provided pen.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="pen">The pen.</param>
        /// <param name="path">The path.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPathExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, IPen<TPixel> pen, IPath path)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Fill(options, pen.StrokeFill, new ShapePath(path, pen));
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IPen pen,
            IPath path) =>
            source.Fill(options, pen.StrokeFill, new ShapePath(path, pen));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPathExtensions.cs

        /// <summary>
        /// Draws the outline of the polygon with the provided pen.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="pen">The pen.</param>
        /// <param name="path">The path.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPathExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, IPen<TPixel> pen, IPath path)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(GraphicsOptions.Default, pen, path);
=======
        public static IImageProcessingContext Draw(this IImageProcessingContext source, IPen pen, IPath path) =>
            source.Draw(GraphicsOptions.Default, pen, path);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPathExtensions.cs

        /// <summary>
        /// Draws the outline of the polygon with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="path">The shape.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPathExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, IBrush<TPixel> brush, float thickness, IPath path)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(options, new Pen<TPixel>(brush, thickness), path);
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IBrush brush,
            float thickness,
            IPath path) =>
            source.Draw(options, new Pen(brush, thickness), path);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPathExtensions.cs

        /// <summary>
        /// Draws the outline of the polygon with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="path">The path.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPathExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, IBrush<TPixel> brush, float thickness, IPath path)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(new Pen<TPixel>(brush, thickness), path);
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            IBrush brush,
            float thickness,
            IPath path) =>
            source.Draw(new Pen(brush, thickness), path);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPathExtensions.cs

        /// <summary>
        /// Draws the outline of the polygon with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="color">The color.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="path">The path.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPathExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, TPixel color, float thickness, IPath path)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(options, new SolidBrush<TPixel>(color), thickness, path);
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            GraphicsOptions options,
            Color color,
            float thickness,
            IPath path) =>
            source.Draw(options, new SolidBrush(color), thickness, path);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPathExtensions.cs

        /// <summary>
        /// Draws the outline of the polygon with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="color">The color.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="path">The path.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPathExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, TPixel color, float thickness, IPath path)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(new SolidBrush<TPixel>(color), thickness, path);
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            Color color,
            float thickness,
            IPath path) =>
            source.Draw(new SolidBrush(color), thickness, path);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPathExtensions.cs
    }
}