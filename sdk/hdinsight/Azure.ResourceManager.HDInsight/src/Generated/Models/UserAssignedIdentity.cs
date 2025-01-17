// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The User Assigned Identity. </summary>
    public partial class UserAssignedIdentity
    {
        /// <summary> Initializes a new instance of UserAssignedIdentity. </summary>
        public UserAssignedIdentity()
        {
        }

        /// <summary> Initializes a new instance of UserAssignedIdentity. </summary>
        /// <param name="principalId"> The principal id of user assigned identity. </param>
        /// <param name="clientId"> The client id of user assigned identity. </param>
        /// <param name="tenantId"> The tenant id of user assigned identity. </param>
        internal UserAssignedIdentity(string principalId, string clientId, Guid? tenantId)
        {
            PrincipalId = principalId;
            ClientId = clientId;
            TenantId = tenantId;
        }

        /// <summary> The principal id of user assigned identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The client id of user assigned identity. </summary>
        public string ClientId { get; }
        /// <summary> The tenant id of user assigned identity. </summary>
        public Guid? TenantId { get; set; }
    }
}
