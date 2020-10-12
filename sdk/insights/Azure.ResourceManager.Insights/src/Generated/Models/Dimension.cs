// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> Specifies the criteria for converting log to metric. </summary>
    public partial class Dimension
    {
        /// <summary> Initializes a new instance of Dimension. </summary>
        /// <param name="name"> Name of the dimension. </param>
        /// <param name="operator"> Operator for dimension values. </param>
        /// <param name="values"> List of dimension values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="values"/> is null. </exception>
        public Dimension(string name, Operator @operator, IEnumerable<string> values)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            Name = name;
            Operator = @operator;
            Values = values.ToList();
        }

        /// <summary> Initializes a new instance of Dimension. </summary>
        /// <param name="name"> Name of the dimension. </param>
        /// <param name="operator"> Operator for dimension values. </param>
        /// <param name="values"> List of dimension values. </param>
        internal Dimension(string name, Operator @operator, IList<string> values)
        {
            Name = name;
            Operator = @operator;
            Values = values;
        }

        /// <summary> Name of the dimension. </summary>
        public string Name { get; set; }
        /// <summary> Operator for dimension values. </summary>
        public Operator Operator { get; set; }
        /// <summary> List of dimension values. </summary>
        public IList<string> Values { get; }
    }
}
