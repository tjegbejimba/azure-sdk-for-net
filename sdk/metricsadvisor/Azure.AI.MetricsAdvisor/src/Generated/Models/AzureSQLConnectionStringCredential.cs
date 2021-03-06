// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureSQLConnectionStringCredential. </summary>
    internal partial class AzureSQLConnectionStringCredential : DatasourceCredential
    {
        /// <summary> Initializes a new instance of AzureSQLConnectionStringCredential. </summary>
        /// <param name="name"> Name of data source credential. </param>
        /// <param name="parameters"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public AzureSQLConnectionStringCredential(string name, AzureSQLConnectionStringParam parameters) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            DataSourceCredentialType = DataSourceCredentialType.AzureSQLConnectionString;
        }

        /// <summary> Initializes a new instance of AzureSQLConnectionStringCredential. </summary>
        /// <param name="dataSourceCredentialType"> Type of data source credential. </param>
        /// <param name="id"> Unique id of data source credential. </param>
        /// <param name="name"> Name of data source credential. </param>
        /// <param name="description"> Description of data source credential. </param>
        /// <param name="parameters"> . </param>
        internal AzureSQLConnectionStringCredential(DataSourceCredentialType dataSourceCredentialType, string id, string name, string description, AzureSQLConnectionStringParam parameters) : base(dataSourceCredentialType, id, name, description)
        {
            Parameters = parameters;
            DataSourceCredentialType = dataSourceCredentialType;
        }

        public AzureSQLConnectionStringParam Parameters { get; set; }
    }
}
