// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> KPack ClusterStack properties payload. </summary>
    public partial class StackProperties
    {
        /// <summary> Initializes a new instance of StackProperties. </summary>
        public StackProperties()
        {
        }

        /// <summary> Initializes a new instance of StackProperties. </summary>
        /// <param name="id"> Id of the ClusterStack. </param>
        /// <param name="version"> Version of the ClusterStack. </param>
        internal StackProperties(string id, string version)
        {
            Id = id;
            Version = version;
        }

        /// <summary> Id of the ClusterStack. </summary>
        public string Id { get; set; }
        /// <summary> Version of the ClusterStack. </summary>
        public string Version { get; set; }
    }
}
