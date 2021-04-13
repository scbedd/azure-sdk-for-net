// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitory.Query.Models
{
    /// <summary> An array of requests. </summary>
    internal partial class BatchRequest
    {
        /// <summary> Initializes a new instance of BatchRequest. </summary>
        public BatchRequest()
        {
            Requests = new ChangeTrackingList<LogQueryRequest>();
        }

        /// <summary> An single request in a batch. </summary>
        public IList<LogQueryRequest> Requests { get; }
    }
}
