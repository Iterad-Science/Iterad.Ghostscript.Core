/* BufferHelper.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

namespace Ghostscript.NET
{
    internal class BufferHelper
    {

        #region IndexOf

        /// <summary>
        /// The Knuth-Morris-Pratt Pattern Matching Algorithm.
        /// </summary>
        public static int IndexOf(byte[] data, byte[] pattern)
        {
            int[] failure = ComputeFailure(pattern);

            int j = 0;

            for (int i = 0; i < data.Length; i++)
            {
                while (j > 0 && pattern[j] != data[i])
                {
                    j = failure[j - 1];
                }

                if (pattern[j] == data[i])
                {
                    j++;
                }

                if (j == pattern.Length)
                {
                    return i - pattern.Length + 1;
                }
            }

            return -1;
        }

        #endregion

        #region ComputeFailure

        private static int[] ComputeFailure(byte[] pattern)
        {
            int[] failure = new int[pattern.Length];

            int j = 0;

            for (int i = 1; i < pattern.Length; i++)
            {
                while (j > 0 && pattern[j] != pattern[i])
                {
                    j = failure[j - 1];
                }

                if (pattern[j] == pattern[i])
                {
                    j++;
                }

                failure[i] = j;
            }

            return failure;
        }

        #endregion

    }
}
