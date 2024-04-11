/* FileCleanupHelper.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;
using System.IO;
using System.Collections.Generic;

namespace Ghostscript.NET
{
    internal class FileCleanupHelper
    {

        #region Private variables

        private List<string> _paths = new List<string>();

        #endregion

        #region Add

        public void Add(string path)
        {
            _paths.Add(path);
        }

        #endregion

        #region Cleanup

        public void Cleanup()
        {
            foreach (string path in _paths)
            {
                if (File.Exists(path))
                {
                    try
                    {
                        File.Delete(path);
                    }
                    catch { }
                }
            }

            _paths.Clear();
        }

        #endregion

    }
}
