// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace KafkaRestProxy.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class AbstractConfigData : global::KafkaRestProxy.Client.Models.Resource, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The cluster_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClusterId { get; set; }
#nullable restore
#else
        public string ClusterId { get; set; }
#endif
        /// <summary>The is_default property</summary>
        public bool? IsDefault { get; set; }
        /// <summary>The is_read_only property</summary>
        public bool? IsReadOnly { get; set; }
        /// <summary>The is_sensitive property</summary>
        public bool? IsSensitive { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source { get; set; }
#nullable restore
#else
        public string Source { get; set; }
#endif
        /// <summary>The synonyms property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::KafkaRestProxy.Client.Models.ConfigSynonymData>? Synonyms { get; set; }
#nullable restore
#else
        public List<global::KafkaRestProxy.Client.Models.ConfigSynonymData> Synonyms { get; set; }
#endif
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; set; }
#nullable restore
#else
        public string Value { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KafkaRestProxy.Client.Models.AbstractConfigData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::KafkaRestProxy.Client.Models.AbstractConfigData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KafkaRestProxy.Client.Models.AbstractConfigData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "cluster_id", n => { ClusterId = n.GetStringValue(); } },
                { "is_default", n => { IsDefault = n.GetBoolValue(); } },
                { "is_read_only", n => { IsReadOnly = n.GetBoolValue(); } },
                { "is_sensitive", n => { IsSensitive = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "source", n => { Source = n.GetStringValue(); } },
                { "synonyms", n => { Synonyms = n.GetCollectionOfObjectValues<global::KafkaRestProxy.Client.Models.ConfigSynonymData>(global::KafkaRestProxy.Client.Models.ConfigSynonymData.CreateFromDiscriminatorValue)?.AsList(); } },
                { "value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("cluster_id", ClusterId);
            writer.WriteBoolValue("is_default", IsDefault);
            writer.WriteBoolValue("is_read_only", IsReadOnly);
            writer.WriteBoolValue("is_sensitive", IsSensitive);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("source", Source);
            writer.WriteCollectionOfObjectValues<global::KafkaRestProxy.Client.Models.ConfigSynonymData>("synonyms", Synonyms);
            writer.WriteStringValue("value", Value);
        }
    }
}