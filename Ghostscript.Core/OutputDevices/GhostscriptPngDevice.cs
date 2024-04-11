/* GhostscriptPngDevice.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;
using System.Drawing;

namespace Ghostscript.NET
{

    #region GhostscriptPngDeviceType

    public enum GhostscriptPngDeviceType
    {
        /// <summary>
        /// 24bit RGB color.
        /// </summary>
        [GhostscriptSwitchValue("png16m")]
        Png16m,
        /// <summary>
        /// Transparency support.
        /// </summary>
        [GhostscriptSwitchValue("pngalpha")]
        PngAlpha,
        /// <summary>
        /// Grayscale output.
        /// </summary>
        [GhostscriptSwitchValue("pnggray")]
        PngGray,
        /// <summary>
        /// 8-bit color.
        /// </summary>
        [GhostscriptSwitchValue("png256")]
        Png256,
        /// <summary>
        /// 4-bit color.
        /// </summary>
        [GhostscriptSwitchValue("png16")]
        Png16,
        /// <summary>
        /// Black-and-white only.
        /// </summary>
        [GhostscriptSwitchValue("pngmono")]
        PngMono,
        /// <summary>
        /// Black-and-white, but the output is formed from an internal 8 bit grayscale rendering which is then error diffused and converted down to 1bpp.
        /// </summary>
        [GhostscriptSwitchValue("pngmonod")]
        PngMonoD
    }

    #endregion

    #region GhostscriptPngDeviceMinFeatureSize

    public enum GhostscriptPngDeviceMinFeatureSize
    {
        [GhostscriptSwitchValue("0")]
        V_0,
        [GhostscriptSwitchValue("1")]
        V_1,
        [GhostscriptSwitchValue("2")]
        V_2,
        [GhostscriptSwitchValue("3")]
        V_3,
        [GhostscriptSwitchValue("4")]
        V_4
    }

    #endregion

    public class GhostscriptPngDevice : GhostscriptImageDevice
    {

        #region Constructor

        public GhostscriptPngDevice() : this(GhostscriptPngDeviceType.Png16m) { }

        #endregion

        #region Constructor - deviceType

        public GhostscriptPngDevice(GhostscriptPngDeviceType deviceType)
        {
            this.Device = deviceType;
        }

        #endregion

        #region Device

        public new GhostscriptPngDeviceType Device
        {
            get
            {
                return (GhostscriptPngDeviceType)base.Device;
            }
            set
            {
                base.Device = value;
            }
        }

        #endregion

        #region DownScaleFactor

        [GhostscriptSwitch("-dDownScaleFactor={0}")]
        public int? DownScaleFactor { get; set; }

        #endregion

        #region MinFeatureSize

        [GhostscriptSwitch("-dMinFeatureSize={0}")]
        public GhostscriptPngDeviceMinFeatureSize? MinFeatureSize { get; set; }

        #endregion

        #region BackgroundColor

        [GhostscriptSwitch("-dBackgroundColor={0}")]
        public Color? BackgroundColor { get; set; }

        #endregion

        #region Process

        public static void Process(GhostscriptPngDeviceType pngDeviceType, string[] inputFiles, string outputPath, GhostscriptStdIO stdIO_callback)
        {
            GhostscriptPngDevice dev = new GhostscriptPngDevice(pngDeviceType);
            dev.InputFiles.AddRange(inputFiles);
            dev.OutputPath = outputPath;
            dev.Process(stdIO_callback);
        }

        #endregion

    }

}