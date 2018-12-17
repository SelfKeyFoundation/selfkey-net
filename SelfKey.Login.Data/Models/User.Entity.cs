using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace SelfKey.Login.Data.Models
{
    public partial class User : IdentityUser
    {
        [JsonIgnore]
        public string TypeCsv
        {
            get => Type is null ? null : String.Join(",", Type);
            set => Type = value?.Split(',').ToList();
        }
    }
}
