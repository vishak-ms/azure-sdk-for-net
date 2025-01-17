// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Skip error file. </summary>
    public partial class SkipErrorFile
    {
        /// <summary> Initializes a new instance of SkipErrorFile. </summary>
        public SkipErrorFile()
        {
        }

        /// <summary> Initializes a new instance of SkipErrorFile. </summary>
        /// <param name="fileMissing"> Skip if file is deleted by other client during copy. Default is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="dataInconsistency"> Skip if source/sink file changed by other concurrent write. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        internal SkipErrorFile(BinaryData fileMissing, BinaryData dataInconsistency)
        {
            FileMissing = fileMissing;
            DataInconsistency = dataInconsistency;
        }

        /// <summary> Skip if file is deleted by other client during copy. Default is true. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData FileMissing { get; set; }
        /// <summary> Skip if source/sink file changed by other concurrent write. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData DataInconsistency { get; set; }
    }
}
