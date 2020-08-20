// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> An instance of PageView represents a generic action on a page like a button click. It is also the base type for PageView. </summary>
    public partial class RequestData : MonitorDomain
    {
        /// <summary> Initializes a new instance of RequestData. </summary>
        /// <param name="ver"> Schema version. </param>
        /// <param name="id"> Identifier of a request call instance. Used for correlation between request and other telemetry items. </param>
        /// <param name="duration"> Request duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </param>
        /// <param name="success"> Indication of successfull or unsuccessfull call. </param>
        /// <param name="responseCode"> Result of a request execution. HTTP status code for HTTP requests. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="duration"/>, or <paramref name="responseCode"/> is null. </exception>
        public RequestData(int ver, string id, string duration, bool success, string responseCode)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (duration == null)
            {
                throw new ArgumentNullException(nameof(duration));
            }
            if (responseCode == null)
            {
                throw new ArgumentNullException(nameof(responseCode));
            }

            Ver = ver;
            Id = id;
            Duration = duration;
            Success = success;
            ResponseCode = responseCode;
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Initializes a new instance of RequestData. </summary>
        /// <param name="test"> Ignored value. </param>
        /// <param name="ver"> Schema version. </param>
        /// <param name="id"> Identifier of a request call instance. Used for correlation between request and other telemetry items. </param>
        /// <param name="name"> Name of the request. Represents code path taken to process request. Low cardinality value to allow better grouping of requests. For HTTP requests it represents the HTTP method and URL path template like &apos;GET /values/{id}&apos;. </param>
        /// <param name="duration"> Request duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </param>
        /// <param name="success"> Indication of successfull or unsuccessfull call. </param>
        /// <param name="responseCode"> Result of a request execution. HTTP status code for HTTP requests. </param>
        /// <param name="source"> Source of the request. Examples are the instrumentation key of the caller or the ip address of the caller. </param>
        /// <param name="url"> Request URL with all query string parameters. </param>
        /// <param name="properties"> Collection of custom properties. TODO: max key length validate. </param>
        /// <param name="measurements"> Collection of custom measurements. TODO: max key length validate. </param>
        internal RequestData(string test, int ver, string id, string name, string duration, bool success, string responseCode, string source, string url, IDictionary<string, string> properties, IDictionary<string, double> measurements) : base(test)
        {
            Ver = ver;
            Id = id;
            Name = name;
            Duration = duration;
            Success = success;
            ResponseCode = responseCode;
            Source = source;
            Url = url;
            Properties = properties;
            Measurements = measurements;
        }

        /// <summary> Schema version. </summary>
        public int Ver { get; set; }
        /// <summary> Identifier of a request call instance. Used for correlation between request and other telemetry items. </summary>
        public string Id { get; set; }
        /// <summary> Name of the request. Represents code path taken to process request. Low cardinality value to allow better grouping of requests. For HTTP requests it represents the HTTP method and URL path template like &apos;GET /values/{id}&apos;. </summary>
        public string Name { get; set; }
        /// <summary> Indication of successfull or unsuccessfull call. </summary>
        public bool Success { get; set; }
        /// <summary> Result of a request execution. HTTP status code for HTTP requests. </summary>
        public string ResponseCode { get; set; }
        /// <summary> Source of the request. Examples are the instrumentation key of the caller or the ip address of the caller. </summary>
        public string Source { get; set; }
        /// <summary> Request URL with all query string parameters. </summary>
        public string Url { get; set; }
        /// <summary> Collection of custom properties. TODO: max key length validate. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Collection of custom measurements. TODO: max key length validate. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}