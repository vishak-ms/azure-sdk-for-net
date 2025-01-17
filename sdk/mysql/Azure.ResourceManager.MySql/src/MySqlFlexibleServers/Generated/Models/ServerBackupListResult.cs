// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql.FlexibleServers;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> A list of server backups. </summary>
    internal partial class ServerBackupListResult
    {
        /// <summary> Initializes a new instance of ServerBackupListResult. </summary>
        internal ServerBackupListResult()
        {
            Value = new ChangeTrackingList<ServerBackupData>();
        }

        /// <summary> Initializes a new instance of ServerBackupListResult. </summary>
        /// <param name="value"> The list of backups of a server. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        internal ServerBackupListResult(IReadOnlyList<ServerBackupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of backups of a server. </summary>
        public IReadOnlyList<ServerBackupData> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}
