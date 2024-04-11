/* GhostscriptJpegDevice.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;
using System.Drawing;

namespace Ghostscript.NET
{

    #region GhostscriptJpegDeviceType

    public enum GhostscriptJpegDeviceType
    {
        /// <summary>
        /// Produce color JPEG files.
        /// </summary>
        [GhostscriptSwitchValue("jpeg")]
        Jpeg,
        /// <summary>
        /// Produce grayscale JPEG files.
        /// </summary>
        [GhostscriptSwitchValue("jpeggray")]
        JpegGray
    }

    #endregion

    public class GhostscriptJpegDevice : GhostscriptImageDevice
    {

        #region Constructor

        public GhostscriptJpegDevice() : this(GhostscriptJpegDeviceType.Jpeg) { }

        #endregion

        #region Constructor - deviceType

        public GhostscriptJpegDevice(GhostscriptJpegDeviceType deviceType)
        {
            this.Device = deviceType;
        }

        #endregion

        #region Device

        public new GhostscriptJpegDeviceType Device
        {
            get
            {
                return (GhostscriptJpegDeviceType)base.Device;
            }
            set
            {
                base.Device = value;
            }
        }

        #endregion

        #region JpegQuality

        /// <summary>
        /// (integer from 0 to 100, default 75)
        /// Set the quality level value according to the widely used IJG quality scale, which balances the extent of compression 
        /// against the fidelity of the image when reconstituted. Lower values drop more information from the image to achieve 
        /// higher compression, and therefore have lower quality when reconstituted.
        /// </summary>
        [GhostscriptSwitch("-dJPEGQ={0}")]
        public int? JpegQuality { get; set; }

        #endregion

        #region QualityFactor

        /// <summary>
        /// (float from 0.0 to 1.0).
        /// Adobe's QFactor quality scale, which you may use in place of JPEGQ above. The QFactor scale is used by PostScript's
        /// DCTEncode filter but is nearly unheard-of elsewhere.
        /// </summary>
        [GhostscriptSwitch("-dQFactor={0}")]
        public float? QualityFactor { get; set; }

        #endregion

        #region Process

        public static void Process(GhostscriptJpegDeviceType deviceType, string[] inputFiles, string outputPath, GhostscriptStdIO stdIO_callback)
        {
            GhostscriptJpegDevice dev = new GhostscriptJpegDevice(deviceType);
            dev.InputFiles.AddRange(inputFiles);
            dev.OutputPath = outputPath;
            dev.Process(stdIO_callback);
        }

        #endregion

    }

}