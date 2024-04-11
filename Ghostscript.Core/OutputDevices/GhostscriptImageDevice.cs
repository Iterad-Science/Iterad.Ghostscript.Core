/* GhostscriptImageDevice.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET
{

    #region GhostscriptImageDeviceAlphaBits

    public enum GhostscriptImageDeviceAlphaBits
    {
        /// <summary>
        /// 1.
        /// </summary>
        [GhostscriptSwitchValue("1")]
        V_1,
        /// <summary>
        /// 2.
        /// </summary>
        [GhostscriptSwitchValue("2")]
        V_2,
        /// <summary>
        /// 4.
        /// </summary>
        [GhostscriptSwitchValue("4")]
        V_4
    }

    #endregion

    #region GhostscriptImageDeviceResolution

    public class GhostscriptImageDeviceResolution
    {

        #region Constructor

        public GhostscriptImageDeviceResolution(int x, int y)
        {
            X = x;
            Y = y;
        }

        #endregion

        #region X

        public int? X { get; set; }

        #endregion

        #region Y

        public int? Y { get; set; }

        #endregion

    }

    #endregion

    public class GhostscriptImageDevice : GhostscriptDevice
    {
        #region Constructor

        public GhostscriptImageDevice()
        {
            this.Other.Safer = GhostscriptOptionalSwitch.Include;
            this.Interaction.Batch = GhostscriptOptionalSwitch.Include;
            this.Interaction.NoPause = GhostscriptOptionalSwitch.Include;
        }

        #endregion

        #region Resolution

        /// <summary>
        /// This option sets the resolution of the output file in dots per inch. The default value if you don't specify this options is usually 72 dpi.
        /// </summary>
        [GhostscriptSwitch("-r{0}")]
        public int? Resolution { get; set; }

        #endregion

        #region ResolutionXY

        /// <summary>
        /// This option sets the resolution of the output file in dots per inch. The default value if you don't specify this options is usually 72 dpi.
        /// </summary>
        [GhostscriptSwitch("-r{0}x{1}")]
        public GhostscriptImageDeviceResolution ResolutionXY { get; set; }

        #endregion

        #region TextAlphaBits

        /// <summary>
        /// These option control the use of subsample anti-aliasing. 
        /// Their use is highly recommended for producing high quality rasterizations of the input files. 
        /// The size of the subsampling box n should be 4 for optimum output, but smaller values can be used for faster rendering. 
        /// Anti-aliasing is enabled separately for text and graphics content.
        /// </summary>
        [GhostscriptSwitch("-dTextAlphaBits={0}")]
        public GhostscriptImageDeviceAlphaBits? TextAlphaBits { get; set; }

        #endregion

        #region GraphicsAlphaBits

        /// <summary>
        /// These option control the use of subsample anti-aliasing. 
        /// Their use is highly recommended for producing high quality rasterizations of the input files. 
        /// The size of the subsampling box n should be 4 for optimum output, but smaller values can be used for faster rendering. 
        /// Anti-aliasing is enabled separately for text and graphics content.
        /// </summary>
        [GhostscriptSwitch("-dGraphicsAlphaBits={0}")]
        public GhostscriptImageDeviceAlphaBits? GraphicsAlphaBits { get; set; }

        #endregion
    }
}
