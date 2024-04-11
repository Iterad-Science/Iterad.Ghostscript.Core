/* GhostscriptLicence.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET
{
    /// <summary>
    /// Ghostscript license type.
    /// </summary>
    public enum GhostscriptLicense
    {
        /// <summary>
        /// Open source releases.
        /// </summary>
        GPL = 0,

        /// <summary>
        /// Old open source releases.
        /// </summary>
        AFPL = 1,

        /// <summary>
        /// Commercially licensed release.
        /// </summary>
        Artifex = 2
    }
}
