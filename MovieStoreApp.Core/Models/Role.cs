using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Core.Models 
{
    public class Role {
        [Required]
        public int RoleId { get; set; }
        [MaxLength(128)]
        [Column(TypeName = "Varchar")]
        public string RoleName { get; set; }
    }
}

