using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SelfKey.Login.Data.Models
{
    public partial class Claim
    {
        [Key, JsonIgnore]
        public long Id { get; set; }
    }
}
