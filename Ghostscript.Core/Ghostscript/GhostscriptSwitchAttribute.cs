/* GhostscriptSwitchAttribute.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET
{
    /// <summary>
    /// Represents a GhostscriptSwitch attribute.
    /// </summary>
    public sealed class GhostscriptSwitchAttribute : Attribute
    {

        #region Private variables

        private string _name;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the Ghostscript.NET.GhostscriptSwitchAttribute class.
        /// </summary>
        /// <param name="name">The Switch name.</param>
        public GhostscriptSwitchAttribute(string name)
        {
            _name = name;
        }

        #endregion

        #region Name

        /// <summary>
        /// Gets the switch name.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        #endregion

    }

    /// <summary>
    /// Represents a GhostscriptSwitchValue attribute.
    /// </summary>
    public sealed class GhostscriptSwitchValueAttribute : Attribute
    {

        #region Private variables

        private string _value;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the Ghostscript.NET.GhostscriptSwitchValueAttribute class.
        /// </summary>
        /// <param name="value"></param>
        public GhostscriptSwitchValueAttribute(string value)
        {
            _value = value;
        }

        #endregion

        #region Value

        /// <summary>
        /// Gets the switch value.
        /// </summary>
        public string Value
        {
            get { return _value; }
        }

        #endregion

    }
}
