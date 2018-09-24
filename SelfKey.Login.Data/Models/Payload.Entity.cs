using System;
using System.Linq;
using Newtonsoft.Json;

#pragma warning disable IDE1006 // Naming Styles

namespace SelfKey.Login.Data.Models
{
    public partial class Payload
    {
        [JsonIgnore]
        public string TypeCsv
        {
            get => Type is null ? null : String.Join(",", Type);
            set => Type = value?.Split(',').ToList();
        }
    }
}
