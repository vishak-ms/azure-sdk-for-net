// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The parameters for updating a machine learning workspace. </summary>
    public partial class MachineLearningWorkspacePatch
    {
        /// <summary> Initializes a new instance of MachineLearningWorkspacePatch. </summary>
        public MachineLearningWorkspacePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The resource tags for the machine learning workspace. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The sku of the workspace. </summary>
        public MachineLearningSku Sku { get; set; }
        /// <summary> The identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The description of this workspace. </summary>
        public string Description { get; set; }
        /// <summary> The friendly name for this workspace. </summary>
        public string FriendlyName { get; set; }
        /// <summary> The compute name for image build. </summary>
        public string ImageBuildCompute { get; set; }
        /// <summary> The service managed resource settings. </summary>
        internal ServiceManagedResourcesSettings ServiceManagedResourcesSettings { get; set; }
        /// <summary> The throughput of the collections in cosmosdb database. </summary>
        public int? CosmosDbCollectionsThroughput
        {
            get => ServiceManagedResourcesSettings is null ? default : ServiceManagedResourcesSettings.CosmosDbCollectionsThroughput;
            set
            {
                if (ServiceManagedResourcesSettings is null)
                    ServiceManagedResourcesSettings = new ServiceManagedResourcesSettings();
                ServiceManagedResourcesSettings.CosmosDbCollectionsThroughput = value;
            }
        }

        /// <summary> The user assigned identity resource id that represents the workspace identity. </summary>
        public string PrimaryUserAssignedIdentity { get; set; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> ARM id of the application insights associated with this workspace. </summary>
        public string ApplicationInsights { get; set; }
        /// <summary> ARM id of the container registry associated with this workspace. </summary>
        public string ContainerRegistry { get; set; }
    }
}
