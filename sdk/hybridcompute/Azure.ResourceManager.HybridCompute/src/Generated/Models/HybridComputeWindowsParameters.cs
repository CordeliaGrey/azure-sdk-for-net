// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Input for InstallPatches on a Windows VM, as directly received by the API. </summary>
    public partial class HybridComputeWindowsParameters
    {
        /// <summary> Initializes a new instance of <see cref="HybridComputeWindowsParameters"/>. </summary>
        public HybridComputeWindowsParameters()
        {
            ClassificationsToInclude = new ChangeTrackingList<VmGuestPatchClassificationWindow>();
            KbNumbersToInclude = new ChangeTrackingList<string>();
            KbNumbersToExclude = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputeWindowsParameters"/>. </summary>
        /// <param name="classificationsToInclude"> The update classifications to select when installing patches for Windows. </param>
        /// <param name="kbNumbersToInclude"> Kbs to include in the patch operation. </param>
        /// <param name="kbNumbersToExclude"> Kbs to exclude in the patch operation. </param>
        /// <param name="excludeKbsRequiringReboot"> Filters out Kbs that don't have an InstallationRebootBehavior of 'NeverReboots' when this is set to true. </param>
        /// <param name="maxPatchPublishOn"> This is used to install patches that were published on or before this given max published date. </param>
        internal HybridComputeWindowsParameters(IList<VmGuestPatchClassificationWindow> classificationsToInclude, IList<string> kbNumbersToInclude, IList<string> kbNumbersToExclude, bool? excludeKbsRequiringReboot, DateTimeOffset? maxPatchPublishOn)
        {
            ClassificationsToInclude = classificationsToInclude;
            KbNumbersToInclude = kbNumbersToInclude;
            KbNumbersToExclude = kbNumbersToExclude;
            ExcludeKbsRequiringReboot = excludeKbsRequiringReboot;
            MaxPatchPublishOn = maxPatchPublishOn;
        }

        /// <summary> The update classifications to select when installing patches for Windows. </summary>
        public IList<VmGuestPatchClassificationWindow> ClassificationsToInclude { get; }
        /// <summary> Kbs to include in the patch operation. </summary>
        public IList<string> KbNumbersToInclude { get; }
        /// <summary> Kbs to exclude in the patch operation. </summary>
        public IList<string> KbNumbersToExclude { get; }
        /// <summary> Filters out Kbs that don't have an InstallationRebootBehavior of 'NeverReboots' when this is set to true. </summary>
        public bool? ExcludeKbsRequiringReboot { get; set; }
        /// <summary> This is used to install patches that were published on or before this given max published date. </summary>
        public DateTimeOffset? MaxPatchPublishOn { get; set; }
    }
}
