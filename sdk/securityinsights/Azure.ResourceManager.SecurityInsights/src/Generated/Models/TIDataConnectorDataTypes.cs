// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The available data types for TI (Threat Intelligence) data connector. </summary>
    internal partial class TIDataConnectorDataTypes
    {
        /// <summary> Initializes a new instance of <see cref="TIDataConnectorDataTypes"/>. </summary>
        public TIDataConnectorDataTypes()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TIDataConnectorDataTypes"/>. </summary>
        /// <param name="indicators"> Data type for indicators connection. </param>
        internal TIDataConnectorDataTypes(TIDataConnectorDataTypesIndicators indicators)
        {
            Indicators = indicators;
        }

        /// <summary> Data type for indicators connection. </summary>
        internal TIDataConnectorDataTypesIndicators Indicators { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        public SecurityInsightsDataTypeConnectionState? IndicatorsState
        {
            get => Indicators is null ? default : Indicators.State;
            set
            {
                if (Indicators is null)
                    Indicators = new TIDataConnectorDataTypesIndicators();
                Indicators.State = value;
            }
        }
    }
}
