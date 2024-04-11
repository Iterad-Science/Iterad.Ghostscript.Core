﻿/* GhostscriptDevicePdfSwitches.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET
{
    public class GhostscriptDevicePageSwitches
    {
        #region FixedMedia

        /// <summary>
        /// Causes the media size to be fixed after initialization, forcing pages of other sizes or orientations
        /// to be clipped. This may be useful when printing documents on a printer that can handle their requested
        /// paper size but whose default is some other size. Note that -g automatically sets -dFIXEDMEDIA, 
        /// but -sPAPERSIZE= does not.
        /// </summary>
        [GhostscriptSwitch("-dFIXEDMEDIA")]
        public GhostscriptOptionalSwitch? FixedMedia { get; set; }

        #endregion

        #region FixedResolution

        /// <summary>
        /// Causes the media resolution to be fixed similarly. -r automatically sets -dFIXEDRESOLUTION.
        /// </summary>
        [GhostscriptSwitch("-dFIXEDRESOLUTION")]
        public GhostscriptOptionalSwitch? FixedResolution { get; set; }

        #endregion

        #region PSFitPage

        /// <summary>
        /// The page size from the PostScript file setpagedevice operator, or one of the older statusdict page size 
        /// operators (such as letter or a4) will be rotated, scaled and centered on the "best fit" page size from 
        /// those availiable in the InputAttributes list. The -dPSFitPage is most easily used to fit pages when used
        /// with the -dFIXEDMEDIA option. This option is also set by the -dFitPage option.
        /// </summary>
        [GhostscriptSwitch("-dPSFitPage")]
        public GhostscriptOptionalSwitch? PSFitPage { get; set; }

        #endregion

        #region Orient1

        /// <summary>
        /// Defines the meaning of the 0 and 1 orientation values for the setpage[params] compatibility operators. 
        /// The default value of ORIENT1 is true (set in gs_init.ps), which is the correct value for most files that
        /// use setpage[params] at all, namely, files produced by badly designed applications that "know" that the 
        /// output will be printed on certain roll-media printers: these applications use 0 to mean landscape and 1 
        /// to mean portrait. -dORIENT1=false declares that 0 means portrait and 1 means landscape, which is the 
        /// convention used by a smaller number of files produced by properly written applications.
        /// </summary>
        [GhostscriptSwitch("-dORIENT1={0}")]
        public GhostscriptBooleanSwitch? Orient1 { get; set; }

        #endregion

        #region DeviceWidthPoints

        /// <summary>
        /// Sets the initial page width to desired value respectively, specified in 1/72" units.
        /// </summary>
        [GhostscriptSwitch("-dDEVICEWIDTHPOINTS={0}")]
        public int? DeviceWidthPoints { get; set; }

        #endregion

        #region DeviceHeightPoints

        /// <summary>
        /// Sets the initial page height to desired value respectively, specified in 1/72" units.
        /// </summary>
        [GhostscriptSwitch("-dDEVICEHEIGHTPOINTS={0}")]
        public int? DeviceHeightPoints { get; set; }

        #endregion

        #region DefaultPaperSize

        /// <summary>
        /// This value will be used to replace the device default papersize ONLY if the default papersize for the device
        /// is 'letter' or 'a4' serving to insulate users of A4 or 8.5x11 from particular device defaults (the collection
        /// of contributed drivers in Ghostscript vary as to the default size).
        /// </summary>
        [GhostscriptSwitch("-sDEFAULTPAPERSIZE={0}")]
        public string DefaultPaperSize { get; set; }

        #endregion

        #region FitPage

        /// <summary>
        /// This is a "convenience" operator that sets the various options to perform page fitting for specific file types.
        /// This option sets the -dEPSFitPage, -dPDFFitPage, and the -dFitPage options.
        /// </summary>
        [GhostscriptSwitch("-dFitPage")]
        public GhostscriptOptionalSwitch? FitPage { get; set; }

        #endregion
    }
}
