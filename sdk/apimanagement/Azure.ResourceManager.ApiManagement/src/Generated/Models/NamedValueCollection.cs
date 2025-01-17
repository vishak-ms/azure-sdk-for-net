// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged NamedValue list representation. </summary>
    internal partial class NamedValueCollection
    {
        /// <summary> Initializes a new instance of NamedValueCollection. </summary>
        internal NamedValueCollection()
        {
            Value = new ChangeTrackingList<NamedValueContractData>();
        }

        /// <summary> Initializes a new instance of NamedValueCollection. </summary>
        /// <param name="value"> Page values. </param>
        /// <param name="count"> Total record count number across all pages. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        internal NamedValueCollection(IReadOnlyList<NamedValueContractData> value, long? count, string nextLink)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
        }

        /// <summary> Page values. </summary>
        public IReadOnlyList<NamedValueContractData> Value { get; }
        /// <summary> Total record count number across all pages. </summary>
        public long? Count { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
