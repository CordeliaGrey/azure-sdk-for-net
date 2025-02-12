// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A class representing the HybridContainerServiceAgentPool data model.
    /// The agentPool resource definition
    /// </summary>
    public partial class HybridContainerServiceAgentPoolData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceAgentPoolData"/>. </summary>
        /// <param name="location"> The location. </param>
        public HybridContainerServiceAgentPoolData(AzureLocation location) : base(location)
        {
            AvailabilityZones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceAgentPoolData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Extended Location definition. </param>
        /// <param name="availabilityZones"> AvailabilityZones - The list of Availability zones to use for nodes. Datacenter racks modelled as zones. </param>
        /// <param name="osType"> The particular KubernetesVersion's Image's OS Type (Linux, Windows). </param>
        /// <param name="osSku"> Specifies the OS SKU used by the agent pool. The default is CBLMariner if OSType is Linux. The default is Windows2019 when OSType is Windows. </param>
        /// <param name="nodeImageVersion"> The version of node image. </param>
        /// <param name="count"> Count - Number of agents to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1. </param>
        /// <param name="vmSize"> VmSize - The size of the agent pool VMs. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="status"> Defines the observed state of the agent pool. </param>
        internal HybridContainerServiceAgentPoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, HybridContainerServiceExtendedLocation extendedLocation, IList<string> availabilityZones, HybridContainerServiceOSType? osType, HybridContainerServiceOSSku? osSku, string nodeImageVersion, int? count, string vmSize, HybridContainerServiceResourceProvisioningState? provisioningState, AgentPoolProvisioningStatus status) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            AvailabilityZones = availabilityZones;
            OSType = osType;
            OSSku = osSku;
            NodeImageVersion = nodeImageVersion;
            Count = count;
            VmSize = vmSize;
            ProvisioningState = provisioningState;
            Status = status;
        }

        /// <summary> Extended Location definition. </summary>
        public HybridContainerServiceExtendedLocation ExtendedLocation { get; set; }
        /// <summary> AvailabilityZones - The list of Availability zones to use for nodes. Datacenter racks modelled as zones. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> The particular KubernetesVersion's Image's OS Type (Linux, Windows). </summary>
        public HybridContainerServiceOSType? OSType { get; set; }
        /// <summary> Specifies the OS SKU used by the agent pool. The default is CBLMariner if OSType is Linux. The default is Windows2019 when OSType is Windows. </summary>
        public HybridContainerServiceOSSku? OSSku { get; set; }
        /// <summary> The version of node image. </summary>
        public string NodeImageVersion { get; set; }
        /// <summary> Count - Number of agents to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1. </summary>
        public int? Count { get; set; }
        /// <summary> VmSize - The size of the agent pool VMs. </summary>
        public string VmSize { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public HybridContainerServiceResourceProvisioningState? ProvisioningState { get; }
        /// <summary> Defines the observed state of the agent pool. </summary>
        public AgentPoolProvisioningStatus Status { get; set; }
    }
}
