// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> Request to the action call to bulk claim devices. </summary>
    public partial class ClaimSphereDevicesContent
    {
        /// <summary> Initializes a new instance of <see cref="ClaimSphereDevicesContent"/>. </summary>
        /// <param name="deviceIdentifiers"> Device identifiers of the devices to be claimed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceIdentifiers"/> is null. </exception>
        public ClaimSphereDevicesContent(IEnumerable<string> deviceIdentifiers)
        {
            Argument.AssertNotNull(deviceIdentifiers, nameof(deviceIdentifiers));

            DeviceIdentifiers = deviceIdentifiers.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ClaimSphereDevicesContent"/>. </summary>
        /// <param name="deviceIdentifiers"> Device identifiers of the devices to be claimed. </param>
        internal ClaimSphereDevicesContent(IList<string> deviceIdentifiers)
        {
            DeviceIdentifiers = deviceIdentifiers;
        }

        /// <summary> Device identifiers of the devices to be claimed. </summary>
        public IList<string> DeviceIdentifiers { get; }
    }
}
