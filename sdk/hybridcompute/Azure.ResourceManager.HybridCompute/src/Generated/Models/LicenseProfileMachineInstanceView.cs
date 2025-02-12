// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> License Profile Instance View in Machine Properties. </summary>
    public partial class LicenseProfileMachineInstanceView
    {
        /// <summary> Initializes a new instance of <see cref="LicenseProfileMachineInstanceView"/>. </summary>
        public LicenseProfileMachineInstanceView()
        {
            ProductFeatures = new ChangeTrackingList<HybridComputeProductFeature>();
        }

        /// <summary> Initializes a new instance of <see cref="LicenseProfileMachineInstanceView"/>. </summary>
        /// <param name="licenseStatus"> Indicates the license status of the OS. </param>
        /// <param name="licenseChannel"> Indicates the license channel. </param>
        /// <param name="esuProfile"> Properties for the Machine ESU profile. </param>
        /// <param name="subscriptionStatus"> Indicates the subscription status of the product. </param>
        /// <param name="productType"> Indicates the product type of the license. </param>
        /// <param name="billingStartOn"> The timestamp in UTC when the billing starts. </param>
        /// <param name="enrollmentOn"> The timestamp in UTC when the user enrolls the feature. </param>
        /// <param name="disenrollmentOn"> The timestamp in UTC when the user disenrolled the feature. </param>
        /// <param name="productFeatures"> The list of product features. </param>
        /// <param name="isSoftwareAssuranceCustomer"> Specifies if this machine is licensed as part of a Software Assurance agreement. </param>
        internal LicenseProfileMachineInstanceView(HybridComputeLicenseStatus? licenseStatus, string licenseChannel, LicenseProfileMachineInstanceViewEsuProperties esuProfile, LicenseProfileSubscriptionStatus? subscriptionStatus, LicenseProfileProductType? productType, DateTimeOffset? billingStartOn, DateTimeOffset? enrollmentOn, DateTimeOffset? disenrollmentOn, IList<HybridComputeProductFeature> productFeatures, bool? isSoftwareAssuranceCustomer)
        {
            LicenseStatus = licenseStatus;
            LicenseChannel = licenseChannel;
            EsuProfile = esuProfile;
            SubscriptionStatus = subscriptionStatus;
            ProductType = productType;
            BillingStartOn = billingStartOn;
            EnrollmentOn = enrollmentOn;
            DisenrollmentOn = disenrollmentOn;
            ProductFeatures = productFeatures;
            IsSoftwareAssuranceCustomer = isSoftwareAssuranceCustomer;
        }

        /// <summary> Indicates the license status of the OS. </summary>
        public HybridComputeLicenseStatus? LicenseStatus { get; }
        /// <summary> Indicates the license channel. </summary>
        public string LicenseChannel { get; }
        /// <summary> Properties for the Machine ESU profile. </summary>
        public LicenseProfileMachineInstanceViewEsuProperties EsuProfile { get; set; }
        /// <summary> Indicates the subscription status of the product. </summary>
        public LicenseProfileSubscriptionStatus? SubscriptionStatus { get; set; }
        /// <summary> Indicates the product type of the license. </summary>
        public LicenseProfileProductType? ProductType { get; set; }
        /// <summary> The timestamp in UTC when the billing starts. </summary>
        public DateTimeOffset? BillingStartOn { get; }
        /// <summary> The timestamp in UTC when the user enrolls the feature. </summary>
        public DateTimeOffset? EnrollmentOn { get; }
        /// <summary> The timestamp in UTC when the user disenrolled the feature. </summary>
        public DateTimeOffset? DisenrollmentOn { get; }
        /// <summary> The list of product features. </summary>
        public IList<HybridComputeProductFeature> ProductFeatures { get; }
        /// <summary> Specifies if this machine is licensed as part of a Software Assurance agreement. </summary>
        public bool? IsSoftwareAssuranceCustomer { get; set; }
    }
}
