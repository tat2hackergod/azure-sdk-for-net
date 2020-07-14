// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Allows for the selection of particular streams from another node.
    /// </summary>
    public partial class MediaGraphOutputSelector
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphOutputSelector class.
        /// </summary>
        public MediaGraphOutputSelector()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphOutputSelector class.
        /// </summary>
        /// <param name="property">The stream property to compare with.
        /// Possible values include: 'mediaType'</param>
        /// <param name="operatorProperty">The operator to compare streams by.
        /// Possible values include: 'is', 'isNot'</param>
        /// <param name="value">Value to compare against.</param>
        public MediaGraphOutputSelector(MediaGraphOutputSelectorProperty? property = default(MediaGraphOutputSelectorProperty?), MediaGraphOutputSelectorOperator? operatorProperty = default(MediaGraphOutputSelectorOperator?), string value = default(string))
        {
            Property = property;
            OperatorProperty = operatorProperty;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the stream property to compare with. Possible values
        /// include: 'mediaType'
        /// </summary>
        [JsonProperty(PropertyName = "property")]
        public MediaGraphOutputSelectorProperty? Property { get; set; }

        /// <summary>
        /// Gets or sets the operator to compare streams by. Possible values
        /// include: 'is', 'isNot'
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public MediaGraphOutputSelectorOperator? OperatorProperty { get; set; }

        /// <summary>
        /// Gets or sets value to compare against.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}