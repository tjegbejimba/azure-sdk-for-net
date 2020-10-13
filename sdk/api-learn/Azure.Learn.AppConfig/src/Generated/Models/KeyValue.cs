// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Learn.AppConfig.Models
{
    /// <summary> The KeyValue. </summary>
    public partial class KeyValue
    {
        /// <summary> Initializes a new instance of KeyValue. </summary>
        public KeyValue()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of KeyValue. </summary>
        /// <param name="key"> The unique name of the key-value. </param>
        /// <param name="label"> The label of the key-value. </param>
        /// <param name="contentType"> The content type of the key-value. </param>
        /// <param name="value"> The value of the key-value. </param>
        /// <param name="lastModified"> The time the key-value was last modified. </param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="locked"> Indicates whether or not this key-value is readonly. </param>
        /// <param name="etag"> The entity-tag of the key-value. </param>
        internal KeyValue(string key, string label, string contentType, string value, DateTimeOffset? lastModified, IDictionary<string, string> tags, bool? locked, string etag)
        {
            Key = key;
            Label = label;
            ContentType = contentType;
            Value = value;
            LastModified = lastModified;
            Tags = tags;
            Locked = locked;
            Etag = etag;
        }

        /// <summary> The unique name of the key-value. </summary>
        public string Key { get; set; }
        /// <summary> The label of the key-value. </summary>
        public string Label { get; set; }
        /// <summary> The content type of the key-value. </summary>
        public string ContentType { get; set; }
        /// <summary> The value of the key-value. </summary>
        public string Value { get; set; }
        /// <summary> The time the key-value was last modified. </summary>
        public DateTimeOffset? LastModified { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Indicates whether or not this key-value is readonly. </summary>
        public bool? Locked { get; set; }
        /// <summary> The entity-tag of the key-value. </summary>
        public string Etag { get; set; }
    }
}