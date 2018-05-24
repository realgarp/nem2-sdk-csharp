﻿// ***********************************************************************
// Assembly         : nem2-sdk
// Author           : kailin
// Created          : 01-15-2018
//
// Last Modified By : kailin
// Last Modified On : 01-29-2018
// ***********************************************************************
// <copyright file="MosaicDefinitionDTO.cs" company="Nem.io">   
// Copyright 2018 NEM
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <summary></summary>
// ***********************************************************************

using io.nem2.sdk.Infrastructure.Buffers.Model.JsonConverters;
using Newtonsoft.Json;

namespace io.nem2.sdk.Infrastructure.Buffers.Model
{
    /// <summary>
    /// Class MosaicDefinitionDTO.
    /// </summary>
    public class MosaicDefinitionDTO
    {
        /// <summary>
        /// Gets or sets the namespace identifier.
        /// </summary>
        /// <value>The namespace identifier.</value>
        [JsonProperty("namespaceId")]
        [JsonConverter(typeof(UInt32ArrayToHex))]
        public string NamespaceId { get; set; }

        /// <summary>
        /// Gets or sets the mosaic identifier.
        /// </summary>
        /// <value>The mosaic identifier.</value>
        [JsonProperty("mosaicId")]
        [JsonConverter(typeof(UInt32ArrayToHex))]
        public string MosaicId { get; set; }

        /// <summary>
        /// Gets or sets the supply.
        /// </summary>
        /// <value>The supply.</value>
        [JsonProperty("supply")]
        [JsonConverter(typeof(UInt32ArrayToLong))]
        public ulong Supply { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        [JsonProperty("height")]
        [JsonConverter(typeof(UInt32ArrayToLong))]
        public ulong Height { get; set; }

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        /// <value>The owner.</value>
        [JsonProperty("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>The properties.</value>
        [JsonProperty("properties")]
        [JsonConverter(typeof(UInt32ArrayArrayToLongArray))]
        public ulong[] Properties { get; set; }

        /// <summary>
        /// Gets or sets the levy.
        /// </summary>
        /// <value>The levy.</value>
        [JsonProperty("levy")]
        public MosaicLevyDTO Levy { get; set; }
    }
}