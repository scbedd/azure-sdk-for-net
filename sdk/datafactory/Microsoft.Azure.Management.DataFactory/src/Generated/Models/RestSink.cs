// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity Rest service Sink.
    /// </summary>
    public partial class RestSink : CopySink
    {
        /// <summary>
        /// Initializes a new instance of the RestSink class.
        /// </summary>
        public RestSink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestSink class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="writeBatchSize">Write batch size. Type: integer (or
        /// Expression with resultType integer), minimum: 0.</param>
        /// <param name="writeBatchTimeout">Write batch timeout. Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="sinkRetryCount">Sink retry count. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="sinkRetryWait">Sink retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the sink data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="requestMethod">The HTTP method used to call the
        /// RESTful API. The default is POST. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="additionalHeaders">The additional HTTP headers in the
        /// request to the RESTful API. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="httpRequestTimeout">The timeout (TimeSpan) to get an
        /// HTTP response. It is the timeout to get a response, not the timeout
        /// to read response data. Default value: 00:01:40. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="requestInterval">The time to await before sending next
        /// request, in milliseconds </param>
        /// <param name="httpCompressionType">Http Compression Type to Send
        /// data in compressed format with Optimal Compression Level, Default
        /// is None. And The Only Supported option is Gzip. </param>
        public RestSink(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object writeBatchSize = default(object), object writeBatchTimeout = default(object), object sinkRetryCount = default(object), object sinkRetryWait = default(object), object maxConcurrentConnections = default(object), object requestMethod = default(object), object additionalHeaders = default(object), object httpRequestTimeout = default(object), object requestInterval = default(object), object httpCompressionType = default(object))
            : base(additionalProperties, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections)
        {
            RequestMethod = requestMethod;
            AdditionalHeaders = additionalHeaders;
            HttpRequestTimeout = httpRequestTimeout;
            RequestInterval = requestInterval;
            HttpCompressionType = httpCompressionType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the HTTP method used to call the RESTful API. The
        /// default is POST. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "requestMethod")]
        public object RequestMethod { get; set; }

        /// <summary>
        /// Gets or sets the additional HTTP headers in the request to the
        /// RESTful API. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "additionalHeaders")]
        public object AdditionalHeaders { get; set; }

        /// <summary>
        /// Gets or sets the timeout (TimeSpan) to get an HTTP response. It is
        /// the timeout to get a response, not the timeout to read response
        /// data. Default value: 00:01:40. Type: string (or Expression with
        /// resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "httpRequestTimeout")]
        public object HttpRequestTimeout { get; set; }

        /// <summary>
        /// Gets or sets the time to await before sending next request, in
        /// milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "requestInterval")]
        public object RequestInterval { get; set; }

        /// <summary>
        /// Gets or sets http Compression Type to Send data in compressed
        /// format with Optimal Compression Level, Default is None. And The
        /// Only Supported option is Gzip.
        /// </summary>
        [JsonProperty(PropertyName = "httpCompressionType")]
        public object HttpCompressionType { get; set; }

    }
}
