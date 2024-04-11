/* ierrors.h.helper.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;
using System.Collections.Generic;

namespace Ghostscript.NET
{
    public partial class ierrors
    {
        public static bool IsError(int code)
        {
            return code < 0;
        }

        public static bool IsErrorIgnoreQuit(int code)
        {
            return (code < 0) && (code != ierrors.e_Quit);
        }

        public static bool IsFatalIgnoreNeedInput(int code)
        {
            return (code <= ierrors.e_Fatal) && (code != ierrors.e_NeedInput);
        }

        public static bool IsInterrupt(int ecode)
        {
            return ((ecode) == e_interrupt || (ecode) == e_timeout);
        }

        public static bool IsFatal(int code)
        {
            return code <= ierrors.e_Fatal;
        }

        /// <summary>
        /// Returns error name.
        /// </summary>
        /// <param name="code">Return code from the Ghostscript.</param>
        /// <returns>Error name.</returns>
        public static string GetErrorName(int code)
        {
            int errorNameIndex = ~code + 1;
            return ERROR_NAMES[errorNameIndex];
        }
    }
}
