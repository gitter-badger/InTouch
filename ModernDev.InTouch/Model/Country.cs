/**
 * This file\code is part of InTouch project.
 *
 * InTouch - is a .NET wrapper for the vk.com API.
 * https://github.com/virtyaluk/InTouch
 *
 * Copyright (c) 2016 Bohdan Shtepan
 * http://modern-dev.com/
 *
 * Licensed under the GPLv3 license.
 */

using System.Diagnostics;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    /// <summary>
    /// A <see cref="Country"/> class describes a country.
    /// </summary>
    [DataContract]
    [DebuggerDisplay("Country {Title}")]
    public class Country
    {
        /// <summary>
        /// Country ID.
        /// </summary>
        [DataMember]
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the country.
        /// </summary>
        [DataMember]
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}