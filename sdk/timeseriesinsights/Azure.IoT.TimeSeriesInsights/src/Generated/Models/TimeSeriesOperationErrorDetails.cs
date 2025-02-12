// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Additional error information. </summary>
    public partial class TimeSeriesOperationErrorDetails
    {
        /// <summary> Initializes a new instance of <see cref="TimeSeriesOperationErrorDetails"/>. </summary>
        internal TimeSeriesOperationErrorDetails()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="TimeSeriesOperationErrorDetails"/>. </summary>
        /// <param name="code"> Language-independent, human-readable string that defines a service-specific error code. This code serves as a more specific indicator for the HTTP error code specified in the response. Can be used to programmatically handle specific error cases. </param>
        /// <param name="message"> Human-readable, language-independent representation of the error. It is intended as an aid to developers and is not suitable for exposure to end users. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal TimeSeriesOperationErrorDetails(string code, string message, IReadOnlyDictionary<string, object> additionalProperties)
        {
            Code = code;
            Message = message;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Language-independent, human-readable string that defines a service-specific error code. This code serves as a more specific indicator for the HTTP error code specified in the response. Can be used to programmatically handle specific error cases. </summary>
        public string Code { get; }
        /// <summary> Human-readable, language-independent representation of the error. It is intended as an aid to developers and is not suitable for exposure to end users. </summary>
        public string Message { get; }
    }
}
