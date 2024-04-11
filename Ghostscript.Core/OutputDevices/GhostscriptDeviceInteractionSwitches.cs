/* GhostscriptDeviceInteractionSwitches.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET
{
    public class GhostscriptDeviceInteractionSwitches
    {
        #region Batch

        /// <summary>
        /// Causes Ghostscript to exit after processing all files named on the command line, rather than going into an 
        /// interactive loop reading PostScript commands. Equivalent to putting -c quit at the end of the command line.
        /// </summary>
        [GhostscriptSwitch("-dBATCH")]
        public GhostscriptOptionalSwitch? Batch { get; set; }

        #endregion

        #region NoPagePrompt

        /// <summary>
        /// Disables only the prompt, but not the pause, at the end of each page. This may be useful on PC displays that
        /// get confused if a program attempts to write text to the console while the display is in a graphics mode.
        /// </summary>
        [GhostscriptSwitch("-dNOPAGEPROMPT")]
        public GhostscriptOptionalSwitch? NoPagePrompt { get; set; }

        #endregion

        #region NoPause

        /// <summary>
        /// Disables the prompt and pause at the end of each page. Normally one should use this (along with -dBATCH) when
        /// producing output on a printer or to a file; it also may be desirable for applications where another program is
        /// "driving" Ghostscript.
        /// </summary>
        [GhostscriptSwitch("-dNOPAUSE")]
        public GhostscriptOptionalSwitch? NoPause { get; set; }

        #endregion

        #region NoPrompt

        /// <summary>
        /// Disables the prompt printed by Ghostscript when it expects interactive input, as well as the end-of-page prompt
        /// (-dNOPAGEPROMPT). This allows piping input directly into Ghostscript, as long as the data doesn't refer to currentfile.
        /// </summary>
        [GhostscriptSwitch("-dNOPROMPT")]
        public GhostscriptOptionalSwitch? NoPrompt { get; set; }

        #endregion

        #region Quiet

        /// <summary>
        /// Suppresses routine information comments on standard output. This is currently necessary when redirecting 
        /// device output to standard output.
        /// </summary>
        [GhostscriptSwitch("-dQUIET")]
        public GhostscriptOptionalSwitch? Quiet { get; set; }

        #endregion

        #region ShortErrors

        /// <summary>
        /// Makes certain error and information messages more Adobe-compatible.
        /// </summary>
        [GhostscriptSwitch("-dSHORTERRORS")]
        public GhostscriptOptionalSwitch? ShortErrors { get; set; }

        #endregion
    }
}
