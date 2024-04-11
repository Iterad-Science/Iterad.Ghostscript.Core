/* iapi.h.delegates.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET
{
    /// <summary>
    /// Callback function for stdio.
    /// </summary>
    /// <param name="handle"></param>
    /// <param name="pointer"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    public delegate int gsapi_stdio_callback(IntPtr handle, IntPtr pointer, int count);

    /// <summary>
    /// Callback function for gsapi_set_poll function.
    /// </summary>
    /// <param name="handle"></param>
    /// <returns></returns>
    public delegate int gsapi_pool_callback(IntPtr handle);
}
