/* GhostscriptLibraryNotInstalledException.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET
{
    public class GhostscriptLibraryNotInstalledException : GhostscriptException
    {
        public GhostscriptLibraryNotInstalledException()
            : base(Environment.Is64BitProcess ?
                    "This managed library is running under 64-bit process and requires 64-bit Ghostscript native library installation on this machine! To download proper Ghostscript native library please visit: http://www.ghostscript.com/download/gsdnld.html" :
                    "This managed library is running under 32-bit process and requires 32-bit Ghostscript native library installation on this machine! To download proper Ghostscript native library please visit: http://www.ghostscript.com/download/gsdnld.html"
            , -1001) { }
    }
}
