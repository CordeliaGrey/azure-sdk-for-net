// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The status of virtual machine patch operations. </summary>
    public partial class VirtualMachinePatchStatus
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachinePatchStatus"/>. </summary>
        internal VirtualMachinePatchStatus()
        {
            ConfigurationStatuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachinePatchStatus"/>. </summary>
        /// <param name="availablePatchSummary"> The available patch summary of the latest assessment operation for the virtual machine. </param>
        /// <param name="lastPatchInstallationSummary"> The installation summary of the latest installation operation for the virtual machine. </param>
        /// <param name="configurationStatuses"> The enablement status of the specified patchMode. </param>
        internal VirtualMachinePatchStatus(AvailablePatchSummary availablePatchSummary, LastPatchInstallationSummary lastPatchInstallationSummary, IReadOnlyList<InstanceViewStatus> configurationStatuses)
        {
            AvailablePatchSummary = availablePatchSummary;
            LastPatchInstallationSummary = lastPatchInstallationSummary;
            ConfigurationStatuses = configurationStatuses;
        }

        /// <summary> The available patch summary of the latest assessment operation for the virtual machine. </summary>
        public AvailablePatchSummary AvailablePatchSummary { get; }
        /// <summary> The installation summary of the latest installation operation for the virtual machine. </summary>
        public LastPatchInstallationSummary LastPatchInstallationSummary { get; }
        /// <summary> The enablement status of the specified patchMode. </summary>
        public IReadOnlyList<InstanceViewStatus> ConfigurationStatuses { get; }
    }
}
