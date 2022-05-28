using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SkiaSharp;
using System.Drawing;

namespace EDLinesCSharpSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SKBitmap img = SKBitmap.Decode(Directory.GetCurrentDirectory() + "/1");

            IntPtr ptr = IntPtr.Zero;
            if (img.ColorType == SKColorType.Gray8)
                ptr = img.GetPixels();
            else
                ptr = GetIntPtrFromColorImage(img);

            var ptrToData = new SWIGTYPE_p_unsigned_char(ptr, true);
            var bb = new boundingbox_t()
            {
                width = img.Width,
                height = img.Height
            };

            var scale = 0.3f;

            var lines = new List_line_float_t();
            var res = edlines.EdgeDrawingLineDetector(ptrToData, img.Width, img.Height, scale, scale, bb, lines);

            var cropImageInfo = new SkiaSharp.SKImageInfo(img.Width, img.Height);

            var newImg = new SKBitmap(cropImageInfo);
            SKPaint skp = new SKPaint();
            skp.StrokeWidth = 4;
            skp.Style = SKPaintStyle.StrokeAndFill;
            skp.Color = SKColors.Red;

            using (SKCanvas canvas = new SKCanvas(newImg))
            {
                canvas.DrawBitmap(img, new SKPoint(0, 0));
                foreach (var line in lines)
                {
                    canvas.DrawLine(new SKPoint(line.startx, line.starty), new SKPoint(line.endx, line.endy), skp);
                }
            }


            var a = newImg.Encode(SKEncodedImageFormat.Jpeg, 100);
            using (var fs = new FileStream(Directory.GetCurrentDirectory() + "/result", FileMode.OpenOrCreate))
            {
                a.SaveTo(fs);
            }
        }

        public static IntPtr GetIntPtrFromColorImage(SKBitmap btm)
        {
            var X = btm.Width;
            var Y = btm.Height;
            int size = X * Y;
            byte[] bytes = new byte[size];
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    bytes[i + j * X] = btm.GetPixel(i, j).Red;
                }
            }
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            var data = handle.AddrOfPinnedObject();
            return data;
        }
    }
}
