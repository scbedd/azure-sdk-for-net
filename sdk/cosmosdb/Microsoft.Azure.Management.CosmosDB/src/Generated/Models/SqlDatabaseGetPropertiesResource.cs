// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SqlDatabaseGetPropertiesResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlDatabaseGetPropertiesResource
        /// class.
        /// </summary>
        public SqlDatabaseGetPropertiesResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlDatabaseGetPropertiesResource
        /// class.
        /// </summary>
        /// <param name="id">Name of the Cosmos DB SQL database</param>
        /// <param name="_rid">A system generated property. A unique
        /// identifier.</param>
        /// <param name="_ts">A system generated property that denotes the last
        /// updated timestamp of the resource.</param>
        /// <param name="_etag">A system generated property representing the
        /// resource etag required for optimistic concurrency control.</param>
        /// <param name="_colls">A system generated property that specified the
        /// addressable path of the collections resource.</param>
        /// <param name="_users">A system generated property that specifies the
        /// addressable path of the users resource.</param>
        public SqlDatabaseGetPropertiesResource(string id, string _rid = default(string), double? _ts = default(double?), string _etag = default(string), string _colls = default(string), string _users = default(string))
        {
            Id = id;
            this._rid = _rid;
            this._ts = _ts;
            this._etag = _etag;
            this._colls = _colls;
            this._users = _users;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Cosmos DB SQL database
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "_rid")]
        public string _rid { get; private set; }

        /// <summary>
        /// Gets a system generated property that denotes the last updated
        /// timestamp of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "_ts")]
        public double? _ts { get; private set; }

        /// <summary>
        /// Gets a system generated property representing the resource etag
        /// required for optimistic concurrency control.
        /// </summary>
        [JsonProperty(PropertyName = "_etag")]
        public string _etag { get; private set; }

        /// <summary>
        /// Gets or sets a system generated property that specified the
        /// addressable path of the collections resource.
        /// </summary>
        [JsonProperty(PropertyName = "_colls")]
        public string _colls { get; set; }

        /// <summary>
        /// Gets or sets a system generated property that specifies the
        /// addressable path of the users resource.
        /// </summary>
        [JsonProperty(PropertyName = "_users")]
        public string _users { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
