// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Data.Tables
{
    internal partial class TableQueryEntityWithPartitionAndRowKeyHeaders
    {
        private readonly Response _response;
        public TableQueryEntityWithPartitionAndRowKeyHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Indicates the version of the Table service used to execute the request. This header is returned for requests made against version 2009-09-19 and above. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> This header contains the continuation token value for partition key. </summary>
        public string XMsContinuationNextPartitionKey => _response.Headers.TryGetValue("x-ms-continuation-NextPartitionKey", out string value) ? value : null;
        /// <summary> This header contains the continuation token value for row key. </summary>
        public string XMsContinuationNextRowKey => _response.Headers.TryGetValue("x-ms-continuation-NextRowKey", out string value) ? value : null;
    }
}
