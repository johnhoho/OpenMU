// <copyright file="StatAttributeDefinition.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.BasicModel
{
    using System;
    using System.Collections.Generic;
    using MUnique.OpenMU.Persistence.Json;
    
    /// <summary>
    /// A plain implementation of <see cref="StatAttributeDefinition"/>.
    /// </summary>
    public partial class StatAttributeDefinition : MUnique.OpenMU.DataModel.Configuration.StatAttributeDefinition, IIdentifiable, IConvertibleTo<StatAttributeDefinition>
    {
        /// <inheritdoc />
        public StatAttributeDefinition()
        {
        }

        /// <inheritdoc />
        public StatAttributeDefinition(MUnique.OpenMU.AttributeSystem.AttributeDefinition attribute, System.Single baseValue, System.Boolean increasableByPlayer)
            : base(attribute, baseValue, increasableByPlayer)
        {
        }

        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the raw object of <see cref="Attribute" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attribute")]
        [System.Text.Json.Serialization.JsonPropertyName("attribute")]
        public AttributeDefinition RawAttribute
        {
            get => base.Attribute as AttributeDefinition;
            set => base.Attribute = value;
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override MUnique.OpenMU.AttributeSystem.AttributeDefinition Attribute
        {
            get => base.Attribute;
            set => base.Attribute = value;
        }


        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            var baseObject = obj as IIdentifiable;
            if (baseObject != null)
            {
                return baseObject.Id == this.Id;
            }

            return base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        /// <inheritdoc/>
        public StatAttributeDefinition Convert() => this;
    }
}