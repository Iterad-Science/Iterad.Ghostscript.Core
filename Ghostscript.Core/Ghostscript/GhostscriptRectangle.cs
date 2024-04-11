/* GhostscriptRectangle.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET
{
    /// <summary>
    /// Stores a set of four float values that represent lower-left and upper-right corner of rectangle.
    /// </summary>
    public class GhostscriptRectangle
    {

        #region Private values

        private float _llx;
        private float _lly;
        private float _urx;
        private float _ury;

        #endregion

        #region Static variables

        public static GhostscriptRectangle Empty = new GhostscriptRectangle();

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the Ghostscript.NET.GhostscriptRectangle class.
        /// </summary>
        public GhostscriptRectangle() { }

        #endregion

        #region Constructor - llx, lly, urx, ury

        /// <summary>
        /// Initializes a new instance of the Ghostscript.NET.GhostscriptRectangle class.
        /// </summary>
        /// <param name="llx">Lower-left x.</param>
        /// <param name="lly">Lower-left y.</param>
        /// <param name="urx">Upper-right x.</param>
        /// <param name="ury">Upper-right y.</param>
        public GhostscriptRectangle(float llx, float lly, float urx, float ury)
        {
            _llx = llx;
            _lly = lly;
            _urx = urx;
            _ury = ury;
        }

        #endregion

        #region llx

        /// <summary>
        /// Gets lower-left x.
        /// </summary>
        public float llx
        {
            get { return _llx; }
            set { _llx = value; }
        }

        #endregion

        #region lly

        /// <summary>
        /// Gets lower-left y.
        /// </summary>
        public float lly
        {
            get { return _lly; }
            set { _lly = value; }
        }

        #endregion

        #region urx

        /// <summary>
        /// Gets upper-right x.
        /// </summary>
        public float urx
        {
            get { return _urx; }
            set { _urx = value; }
        }

        #endregion

        #region ury

        /// <summary>
        /// Gets upper-right y.
        /// </summary>
        public float ury
        {
            get { return _ury; }
            set { _ury = value; }
        }

        #endregion

    }
}
