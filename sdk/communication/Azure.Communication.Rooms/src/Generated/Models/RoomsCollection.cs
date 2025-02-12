// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.Rooms
{
    /// <summary> A collection of rooms. </summary>
    internal partial class RoomsCollection
    {
        /// <summary> Initializes a new instance of <see cref="RoomsCollection"/>. </summary>
        /// <param name="value"> A collection of rooms. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RoomsCollection(IEnumerable<CommunicationRoom> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RoomsCollection"/>. </summary>
        /// <param name="value"> A collection of rooms. </param>
        /// <param name="nextLink"> If there are more rooms that can be retrieved, the next link will be populated. </param>
        internal RoomsCollection(IReadOnlyList<CommunicationRoom> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A collection of rooms. </summary>
        public IReadOnlyList<CommunicationRoom> Value { get; }
        /// <summary> If there are more rooms that can be retrieved, the next link will be populated. </summary>
        public string NextLink { get; }
    }
}
