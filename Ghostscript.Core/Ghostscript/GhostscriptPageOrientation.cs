/* GhostscriptPageOrientation.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET
{
    public enum GhostscriptPageOrientation : int
    {
        Portrait = 0,
        Seascape = 1,
        UpsideDown = 2,
        Landscape = 3
    }
}
