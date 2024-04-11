/* GhostscriptException.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET
{
    public class GhostscriptException : Exception
    {
        private int _code = -1000;

        public GhostscriptException(string message) : base(message)
        { }

        public GhostscriptException(string message, int code) : base(message)
        {
            _code = code;
        }

        public int Code
        {
            get { return _code; }
        }

        public string CodeName
        {
            get 
            {
                if (_code <= -1000)
                {
                    return string.Empty;
                }

                return ierrors.GetErrorName(_code);
            }
        }
    }
}
