// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> The GitHubConnectorStatsProperties. </summary>
    public partial class GitHubConnectorStatsProperties
    {
        /// <summary> Initializes a new instance of <see cref="GitHubConnectorStatsProperties"/>. </summary>
        public GitHubConnectorStatsProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubConnectorStatsProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="ownersCount"> Gets or sets owners count. </param>
        /// <param name="reposCount"> Gets or sets repos count. </param>
        internal GitHubConnectorStatsProperties(ProvisioningState? provisioningState, long? ownersCount, long? reposCount)
        {
            ProvisioningState = provisioningState;
            OwnersCount = ownersCount;
            ReposCount = reposCount;
        }

        /// <summary> Gets or sets the provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; set; }
        /// <summary> Gets or sets owners count. </summary>
        public long? OwnersCount { get; set; }
        /// <summary> Gets or sets repos count. </summary>
        public long? ReposCount { get; set; }
    }
}
