// <copyright file="AttributeRelationship.Generated.cs" company="MUnique">
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
    /// A plain implementation of <see cref="AttributeRelationship"/>.
    /// </summary>
    public partial class AttributeRelationship : MUnique.OpenMU.AttributeSystem.AttributeRelationship, IIdentifiable, IConvertibleTo<AttributeRelationship>
    {
        /// <inheritdoc />
        public AttributeRelationship()
        {
        }

        /// <inheritdoc />
        public AttributeRelationship(MUnique.OpenMU.AttributeSystem.AttributeDefinition targetAttribute, System.Single inputOperand, MUnique.OpenMU.AttributeSystem.AttributeDefinition inputAttribute)
            : base(targetAttribute, inputOperand, inputAttribute)
        {
        }

        /// <inheritdoc />
        public AttributeRelationship(MUnique.OpenMU.AttributeSystem.AttributeDefinition targetAttribute, System.Single inputOperand, MUnique.OpenMU.AttributeSystem.AttributeDefinition inputAttribute, MUnique.OpenMU.AttributeSystem.InputOperator inputOperator)
            : base(targetAttribute, inputOperand, inputAttribute, inputOperator)
        {
        }

        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the raw object of <see cref="TargetAttribute" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("targetAttribute")]
        [System.Text.Json.Serialization.JsonPropertyName("targetAttribute")]
        public AttributeDefinition RawTargetAttribute
        {
            get => base.TargetAttribute as AttributeDefinition;
            set => base.TargetAttribute = value;
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override MUnique.OpenMU.AttributeSystem.AttributeDefinition TargetAttribute
        {
            get => base.TargetAttribute;
            set => base.TargetAttribute = value;
        }

        /// <summary>
        /// Gets the raw object of <see cref="InputAttribute" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inputAttribute")]
        [System.Text.Json.Serialization.JsonPropertyName("inputAttribute")]
        public AttributeDefinition RawInputAttribute
        {
            get => base.InputAttribute as AttributeDefinition;
            set => base.InputAttribute = value;
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override MUnique.OpenMU.AttributeSystem.AttributeDefinition InputAttribute
        {
            get => base.InputAttribute;
            set => base.InputAttribute = value;
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
        public AttributeRelationship Convert() => this;
    }
}