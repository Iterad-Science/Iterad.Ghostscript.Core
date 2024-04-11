/* StringHelper.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Ghostscript.NET
{
    public class StringHelper
    {
        #region ToUtf8String

        public static string ToUtf8String(string value)
        {
            return Encoding.UTF8.GetString(Encoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(value)));
        }

        #endregion

        #region NativeUtf8FromString

        public static IntPtr NativeUtf8FromString(string managedString)
        {
            int len = Encoding.UTF8.GetByteCount(managedString);
            byte[] buffer = new byte[len + 1]; // null-terminator allocated
            Encoding.UTF8.GetBytes(managedString, 0, managedString.Length, buffer, 0);
            IntPtr nativeUtf8 = Marshal.AllocHGlobal(buffer.Length);
            Marshal.Copy(buffer, 0, nativeUtf8, buffer.Length);
            return nativeUtf8;
        }

        #endregion

        #region HasNonASCIIChars

        public static bool HasNonASCIIChars(string str)
        {
            return (Encoding.UTF8.GetByteCount(str) != str.Length);
        }

        #endregion
    }
}
