// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of active directory only authentications. </summary>
    public partial class AzureADOnlyAuthListResult
    {
        /// <summary> Initializes a new instance of AzureADOnlyAuthListResult. </summary>
        internal AzureADOnlyAuthListResult()
        {
            Value = new ChangeTrackingList<ServerAzureADOnlyAuthentication>();
        }

        /// <summary> Initializes a new instance of AzureADOnlyAuthListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal AzureADOnlyAuthListResult(IReadOnlyList<ServerAzureADOnlyAuthentication> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ServerAzureADOnlyAuthentication> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
