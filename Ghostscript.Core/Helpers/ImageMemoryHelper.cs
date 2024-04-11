/* ImageMemoryHelper.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;
using System.Runtime.InteropServices;

namespace Ghostscript.NET
{
    internal class ImageMemoryHelper
    {
        #region Set24bppRgbImageColor

        public unsafe static void Set24bppRgbImageColor(IntPtr image, int width, int height, byte r, byte g, byte b)
        {
            byte* ptr = (byte*)image;
            int stride = (((width * 3) + 3) & ~3);

            int padding = stride - (width * 3);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    *ptr++ = r;
                    *ptr++ = g;
                    *ptr++ = b;
                }

                ptr+=padding;
            }
        }

        #endregion

        #region CopyImagePartFrom

        public static void CopyImagePartFrom(IntPtr src, IntPtr dest, int x, int y, int width, int height, int stride, int bytesPerPixel)
        {
            int destStride = (((width * bytesPerPixel) + 3) & ~3); 

            int srcTop = y;
            int destTop = 0;
            int srcBottom = y + height - 1;
            int posSrcTop = 0;
            int posDestTop = 0;

            while (srcTop <= srcBottom)
            {
                posSrcTop = (srcTop * (stride)) + (x * bytesPerPixel);
                posDestTop = (destTop * (destStride));

                wdm.MoveMemory(new IntPtr((long)dest + posDestTop), new IntPtr((long)src + posSrcTop), (uint)(width * bytesPerPixel));

                srcTop++;
                destTop++;
            }
        }

        #endregion

        #region CopyImagePartTo

        public static void CopyImagePartTo(IntPtr dest, IntPtr src, int x, int y, int width, int height, int stride, int bytesPerPixel)
        {
            int partStride = (((width * bytesPerPixel) + 3) & ~3); 

            int destTop = y;
            int srcTop = 0;
            int destBottom = y + height - 1;
            int posDestTop = 0;
            int posSrcTop = 0;

            while (destTop <= destBottom)
            {
                posDestTop = (destTop * stride) + (x * bytesPerPixel);
                posSrcTop = (srcTop * partStride);

                wdm.MoveMemory(new IntPtr((long)dest + posDestTop), new IntPtr((long)src + posSrcTop), (uint)(width * bytesPerPixel));

                destTop++;
                srcTop++;
            }
        }

        #endregion

        #region FlipImageVertically

        public static void FlipImageVertically(IntPtr src, IntPtr dest, int height, int stride)
        {
            int size = height * stride;

            var buffer = new byte[size];
            Marshal.Copy(src, buffer, 0, size);

            byte[] row = new byte[stride];

            int top = 0;
            int bottom = height - 1;
            int posTop;
            int posBottom;

            while (top <= bottom)
            {
                posTop = top * stride;
                posBottom = bottom * stride;

                Array.Copy(buffer, posTop, row, 0, stride);
                Array.Copy(buffer, posBottom, buffer, posTop, stride);
                Array.Copy(row, 0, buffer, posBottom, stride);

                top++;
                bottom--;
            }

            Marshal.Copy(buffer, 0, dest, size);
        }

        #endregion
    }
}
