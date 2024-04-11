/* gdevdsp.h.delegates.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;
using System.Runtime.InteropServices;

namespace Ghostscript.NET
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int display_open_callback(IntPtr handle, IntPtr device);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int display_preclose_callback(IntPtr handle, IntPtr device);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int display_close_callback(IntPtr handle, IntPtr device);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int display_presize_callback(IntPtr handle, IntPtr device, Int32 width, Int32 height, Int32 raster, UInt32 format);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int display_size_callback(IntPtr handle, IntPtr device, Int32 width, Int32 height, Int32 raster, UInt32 format, IntPtr pimage);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int display_sync_callback(IntPtr handle, IntPtr device);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int display_page_callback(IntPtr handle, IntPtr device, Int32 copies, Int32 flush);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int display_update_callback(IntPtr handle, IntPtr device, Int32 x, Int32 y, Int32 w, Int32 h);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void display_memalloc_callback(IntPtr handle, IntPtr device, UInt32 size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int display_memfree_callback(IntPtr handle, IntPtr device, IntPtr mem);

    // added in v2
    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public delegate int display_separation_callback(IntPtr handle, IntPtr device, Int32 component, String component_name, UInt16 c, UInt16 m, UInt16 y, UInt16 k);

    // added in v3
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int display_adjust_band_height(IntPtr handle, IntPtr device, Int32 bandheight);

    // added in v3
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int display_rectangle_request(IntPtr handle, IntPtr device, IntPtr memory, Int32 ox, Int32 oy, Int32 raster, Int32 plane_raster, Int32 x, Int32 y, Int32 w, Int32 h);
}
