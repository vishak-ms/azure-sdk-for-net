// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> AzureDisk CSI Driver settings for the storage profile. </summary>
    internal partial class ManagedClusterStorageProfileDiskCSIDriver
    {
        /// <summary> Initializes a new instance of ManagedClusterStorageProfileDiskCSIDriver. </summary>
        public ManagedClusterStorageProfileDiskCSIDriver()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterStorageProfileDiskCSIDriver. </summary>
        /// <param name="enabled"> Whether to enable AzureDisk CSI Driver. The default value is true. </param>
        internal ManagedClusterStorageProfileDiskCSIDriver(bool? enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Whether to enable AzureDisk CSI Driver. The default value is true. </summary>
        public bool? Enabled { get; set; }
    }
}
