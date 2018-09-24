using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

#pragma warning disable IDE1006 // Naming Styles

namespace SelfKey.Login.Data.Models
{
    public partial class Proof
    {
        [Key, JsonIgnore]
        public long Id { get; set; }
    }
}
