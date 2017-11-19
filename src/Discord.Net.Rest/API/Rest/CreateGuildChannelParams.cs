﻿#pragma warning disable CS1591
using System;
using Newtonsoft.Json;

namespace Discord.API.Rest
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    internal class CreateGuildChannelParams
    {
        [JsonProperty("name")]
        public string Name { get; }
        
        [JsonProperty("type")]
        public ChannelType Type { get; }

        [JsonProperty("bitrate")]
        public Optional<int> Bitrate { get; set; }
        
        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        public CreateGuildChannelParams(string name, ChannelType type)
        {
            Name = name;
            Type = type;
        }
    }
}
