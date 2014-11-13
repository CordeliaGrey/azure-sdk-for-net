// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Insights.Models;

namespace Microsoft.Azure.Insights
{
    /// <summary>
    /// Operations for event data.
    /// </summary>
    public partial interface IEventOperations
    {
        /// <summary>
        /// The List Digest Event Values operation lists the digest events.
        /// </summary>
        /// <param name='filterString'>
        /// The filter string
        /// </param>
        /// <param name='selectedProperties'>
        /// The list of property names to be returned. You can save bandwith by
        /// selecting only the properties you need.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        Task<EventDataListResponse> ListDigestEventsAsync(string filterString, string selectedProperties, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Digest Event Next operation lists the next set of digest
        /// events.
        /// </summary>
        /// <param name='nextLink'>
        /// The next link
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        Task<EventDataListResponse> ListDigestEventsNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The count of events in a subscription.
        /// </summary>
        /// <param name='filterString'>
        /// The filter string.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        Task<EventCountSummaryListResponse> ListEventCountSummaryItemsAsync(string filterString, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Event Values operation lists the events.
        /// </summary>
        /// <param name='filterString'>
        /// The filter string
        /// </param>
        /// <param name='selectedProperties'>
        /// The list of property names to be returned. You can save bandwith by
        /// selecting only the properties you need.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        Task<EventDataListResponse> ListEventsAsync(string filterString, string selectedProperties, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Event Next operation lists the next set of events.
        /// </summary>
        /// <param name='nextLink'>
        /// The next link
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        Task<EventDataListResponse> ListEventsNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The status count of events in a subscription.
        /// </summary>
        /// <param name='filterString'>
        /// The filter string.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List event status count summary operation response.
        /// </returns>
        Task<EventStatusCountSummaryListResponse> ListEventStatusCountSummaryItemsAsync(string filterString, CancellationToken cancellationToken);
    }
}
