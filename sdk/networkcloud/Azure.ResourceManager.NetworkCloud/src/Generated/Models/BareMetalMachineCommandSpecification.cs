// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachineCommandSpecification represents the command and optional arguments to exercise against the bare metal machine. </summary>
    public partial class BareMetalMachineCommandSpecification
    {
        /// <summary> Initializes a new instance of <see cref="BareMetalMachineCommandSpecification"/>. </summary>
        /// <param name="command"> The command to execute against the bare metal machine. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="command"/> is null. </exception>
        public BareMetalMachineCommandSpecification(string command)
        {
            Argument.AssertNotNull(command, nameof(command));

            Arguments = new ChangeTrackingList<string>();
            Command = command;
        }

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineCommandSpecification"/>. </summary>
        /// <param name="arguments"> The list of string arguments that will be passed to the script in order as separate arguments. </param>
        /// <param name="command"> The command to execute against the bare metal machine. </param>
        internal BareMetalMachineCommandSpecification(IList<string> arguments, string command)
        {
            Arguments = arguments;
            Command = command;
        }

        /// <summary> The list of string arguments that will be passed to the script in order as separate arguments. </summary>
        public IList<string> Arguments { get; }
        /// <summary> The command to execute against the bare metal machine. </summary>
        public string Command { get; }
    }
}
