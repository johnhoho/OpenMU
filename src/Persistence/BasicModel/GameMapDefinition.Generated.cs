// <copyright file="GameMapDefinition.Generated.cs" company="MUnique">
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
    /// A plain implementation of <see cref="GameMapDefinition"/>.
    /// </summary>
    public partial class GameMapDefinition : MUnique.OpenMU.DataModel.Configuration.GameMapDefinition, IIdentifiable, IConvertibleTo<GameMapDefinition>
    {
        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the raw collection of <see cref="MonsterSpawns" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("monsterSpawns")]
        [System.Text.Json.Serialization.JsonPropertyName("monsterSpawns")]
        public ICollection<MonsterSpawnArea> RawMonsterSpawns { get; } = new List<MonsterSpawnArea>();
        
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override ICollection<MUnique.OpenMU.DataModel.Configuration.MonsterSpawnArea> MonsterSpawns
        {
            get => base.MonsterSpawns ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.MonsterSpawnArea, MonsterSpawnArea>(this.RawMonsterSpawns);
            protected set
            {
                this.MonsterSpawns.Clear();
                foreach (var item in value)
                {
                    this.MonsterSpawns.Add(item);
                }
            }
        }

        /// <summary>
        /// Gets the raw collection of <see cref="EnterGates" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enterGates")]
        [System.Text.Json.Serialization.JsonPropertyName("enterGates")]
        public ICollection<EnterGate> RawEnterGates { get; } = new List<EnterGate>();
        
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override ICollection<MUnique.OpenMU.DataModel.Configuration.EnterGate> EnterGates
        {
            get => base.EnterGates ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.EnterGate, EnterGate>(this.RawEnterGates);
            protected set
            {
                this.EnterGates.Clear();
                foreach (var item in value)
                {
                    this.EnterGates.Add(item);
                }
            }
        }

        /// <summary>
        /// Gets the raw collection of <see cref="ExitGates" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exitGates")]
        [System.Text.Json.Serialization.JsonPropertyName("exitGates")]
        public ICollection<ExitGate> RawExitGates { get; } = new List<ExitGate>();
        
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override ICollection<MUnique.OpenMU.DataModel.Configuration.ExitGate> ExitGates
        {
            get => base.ExitGates ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.ExitGate, ExitGate>(this.RawExitGates);
            protected set
            {
                this.ExitGates.Clear();
                foreach (var item in value)
                {
                    this.ExitGates.Add(item);
                }
            }
        }

        /// <summary>
        /// Gets the raw collection of <see cref="DropItemGroups" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dropItemGroups")]
        [System.Text.Json.Serialization.JsonPropertyName("dropItemGroups")]
        public ICollection<DropItemGroup> RawDropItemGroups { get; } = new List<DropItemGroup>();
        
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override ICollection<MUnique.OpenMU.DataModel.Configuration.DropItemGroup> DropItemGroups
        {
            get => base.DropItemGroups ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.DropItemGroup, DropItemGroup>(this.RawDropItemGroups);
            protected set
            {
                this.DropItemGroups.Clear();
                foreach (var item in value)
                {
                    this.DropItemGroups.Add(item);
                }
            }
        }

        /// <summary>
        /// Gets the raw collection of <see cref="MapRequirements" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mapRequirements")]
        [System.Text.Json.Serialization.JsonPropertyName("mapRequirements")]
        public ICollection<AttributeRequirement> RawMapRequirements { get; } = new List<AttributeRequirement>();
        
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override ICollection<MUnique.OpenMU.DataModel.Configuration.Items.AttributeRequirement> MapRequirements
        {
            get => base.MapRequirements ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Items.AttributeRequirement, AttributeRequirement>(this.RawMapRequirements);
            protected set
            {
                this.MapRequirements.Clear();
                foreach (var item in value)
                {
                    this.MapRequirements.Add(item);
                }
            }
        }

        /// <summary>
        /// Gets the raw object of <see cref="SafezoneMap" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("safezoneMap")]
        [System.Text.Json.Serialization.JsonPropertyName("safezoneMap")]
        public GameMapDefinition RawSafezoneMap
        {
            get => base.SafezoneMap as GameMapDefinition;
            set => base.SafezoneMap = value;
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override MUnique.OpenMU.DataModel.Configuration.GameMapDefinition SafezoneMap
        {
            get => base.SafezoneMap;
            set => base.SafezoneMap = value;
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
        public GameMapDefinition Convert() => this;
    }
}