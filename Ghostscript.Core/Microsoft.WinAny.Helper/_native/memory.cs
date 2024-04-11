/* memory.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;
using System.Runtime.InteropServices;

namespace Microsoft.WinAny
{
    internal static unsafe class memory
    {
        /// <summary>
        /// Copies bytes between buffers.
        /// </summary>
        /// <param name="dest">New buffer.</param>
        /// <param name="src">Buffer to copy from.</param>
        /// <param name="count">Number of characters to copy.</param>
        public static void memcpy(byte* dest, byte* src, uint count)
        {
            for (uint i = 0; i < count; i++)
            {
                *(dest + i) = *(src + i);
            }
        }

        /// <summary>
        /// Sets buffers to a specified character.
        /// </summary>
        /// <param name="dest">Pointer to destination.</param>
        /// <param name="c">Character to set.</param>
        /// <param name="count">Number of characters.</param>
        public static void memset(byte* dest, byte c, uint count)
        {
            for (uint i = 0; i < count; i++)
            {
                *dest = c;
            }
        }

        /// <summary>
        /// Reallocate memory blocks.
        /// </summary>
        /// <param name="memblock">Pointer to previously allocated memory block.</param>
        /// <param name="size">Previously allocated memory block size.</param>
        /// <param name="newsize">New size in bytes.</param>
        /// <returns></returns>
        public static byte* realloc(byte* memblock, uint size, uint newsize)
        {
            byte* newMemBlock = (byte*)Marshal.AllocHGlobal((int)newsize).ToPointer();

            memcpy(newMemBlock, memblock, size);

            Marshal.FreeHGlobal(new IntPtr(memblock));

            return newMemBlock;
        }
    }
}
