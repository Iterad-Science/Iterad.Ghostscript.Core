/* GhostscriptDevicePdfSwitches.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET
{
    public class GhostscriptDevicePdfSwitches
    {
        #region FirstPage

        /// <summary>
        /// Begins interpreting on the designated page of the document. Pages of all documents in PDF collections are numbered sequentially.
        /// </summary>
        [GhostscriptSwitch("-dFirstPage={0}")]
        public int? FirstPage { get; set; }

        #endregion

        #region LastPage

        /// <summary>
        /// Stops interpreting after the designated page of the document. Pages of all documents in PDF collections are numbered sequentially.
        /// </summary>
        [GhostscriptSwitch("-dLastPage={0}")]
        public int? LastPage { get; set; }

        #endregion
    }
}
