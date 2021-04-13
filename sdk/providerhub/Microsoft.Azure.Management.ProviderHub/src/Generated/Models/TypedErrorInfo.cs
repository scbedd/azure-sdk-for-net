// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TypedErrorInfo
    {
        /// <summary>
        /// Initializes a new instance of the TypedErrorInfo class.
        /// </summary>
        public TypedErrorInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TypedErrorInfo class.
        /// </summary>
        public TypedErrorInfo(string type, object info = default(object))
        {
            Type = type;
            Info = info;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public object Info { get; private set; }

    }
}
