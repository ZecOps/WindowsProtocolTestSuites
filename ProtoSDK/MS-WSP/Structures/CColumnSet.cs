﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.WSP
{
    /// <summary>
    /// The CColumnSet structure specifies the column numbers to be returned. This structure is always used in reference to a specific CPidMapper structure.
    /// </summary>
    public struct CColumnSet : IWSPObject
    {
        /// <summary>
        /// A 32-bit unsigned integer specifying the number of elements in the indexes array.
        /// </summary>
        public UInt32 count;

        /// <summary>
        /// An array of 4-byte unsigned integers each representing a zero-based index into the aPropSpec array in the corresponding CPidMapper structure.
        /// The corresponding property values are returned as columns in the result set.
        /// </summary>
        public UInt32[] indexes;

        public void ToBytes(WSPBuffer buffer)
        {
            buffer.Add(count);

            foreach (var index in indexes)
            {
                buffer.Add(index);
            }
        }
    }
}