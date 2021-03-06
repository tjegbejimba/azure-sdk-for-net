// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using System.Linq;

    /// <summary>
    /// Alert rule.
    /// </summary>
    public partial class AlertRule : ResourceWithEtag
    {
        /// <summary>
        /// Initializes a new instance of the AlertRule class.
        /// </summary>
        public AlertRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertRule class.
        /// </summary>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="etag">Etag of the azure resource</param>
        public AlertRule(string id = default(string), string name = default(string), string type = default(string), string etag = default(string))
            : base(id, name, type, etag)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
