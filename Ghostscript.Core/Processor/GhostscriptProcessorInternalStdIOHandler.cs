/* GhostscriptProcessorInternalStdIOHandler.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET.Processor
{
    internal class GhostscriptProcessorInternalStdIOHandler : GhostscriptStdIO
    {
        private StdInputEventHandler _input;
        private StdOutputEventHandler _output;
        private StdErrorEventHandler _error;

        public GhostscriptProcessorInternalStdIOHandler(StdInputEventHandler input, StdOutputEventHandler output, StdErrorEventHandler error) : base(true, true, true) 
        {
            _input = input;
            _output = output;
            _error = error;
        }

        public override void StdIn(out string input, int count)
        {
            _input(out input, count);
        }

        public override void StdOut(string output)
        {
            _output(output);
        }

        public override void StdError(string error)
        {
            _error(error);
        }
    }
}
