/* GhostscriptProcessor.EventsRelated.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET.Processor
{

    #region Internal delegates

    internal delegate void StdInputEventHandler(out string input, int count);
    internal delegate void StdOutputEventHandler(string output);
    internal delegate void StdErrorEventHandler(string error);

    #endregion

    #region Public delegates

    public delegate void GhostscriptProcessorEventHandler(object sender, GhostscriptProcessorEventArgs e);
    public delegate void GhostscriptProcessorProcessingEventHandler(object sender, GhostscriptProcessorProcessingEventArgs e);
    public delegate void GhostscriptProcessorErrorEventHandler(object sender, GhostscriptProcessorErrorEventArgs e);

    #endregion

    #region GhostscriptProcessorEventArgs

    public class GhostscriptProcessorEventArgs : EventArgs
    {
        public GhostscriptProcessorEventArgs() { }
    }

    #endregion

    #region GhostscriptProcessorProcessingEventArgs

    public class GhostscriptProcessorProcessingEventArgs : EventArgs
    {
        private int _currentPage;
        private int _totalPages;

        internal GhostscriptProcessorProcessingEventArgs(int currentPage, int totalPages)
        {
            _currentPage = currentPage;
            _totalPages = totalPages;
        }

        public int CurrentPage
        {
            get { return _currentPage; }
        }

        public int TotalPages
        {
            get { return _totalPages; }
        }
    }

    #endregion

    #region GhostscriptProcessorErrorEventArgs

    public class GhostscriptProcessorErrorEventArgs : EventArgs
    {
        private string _errorMessage;

        public GhostscriptProcessorErrorEventArgs(string errorMessage)
        {
            _errorMessage = errorMessage;
        }

        public string Message
        {
            get { return _errorMessage; }
        }
    }

    #endregion

}
