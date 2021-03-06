// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Result of the request to list Microsoft.Resources operations. It contains a list of operations and a URL link to get the next set of results. </summary>
    public partial class OperationListResult
    {
        /// <summary> Initializes a new instance of OperationListResult. </summary>
        internal OperationListResult()
        {
            Value = new ChangeTrackingList<Operation>();
        }

        /// <summary> Initializes a new instance of OperationListResult. </summary>
        /// <param name="value"> List of Microsoft.Resources operations. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal OperationListResult(IReadOnlyList<Operation> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Microsoft.Resources operations. </summary>
        public IReadOnlyList<Operation> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
