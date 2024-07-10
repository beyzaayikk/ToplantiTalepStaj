using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ToplantiTalep.Models
{
    public class Admin: IdentityUser
    {
        [Key]
        public int AdminID { get; set; }
        [StringLength(50)]
        public string AdminAd { get; set; }
        [StringLength(50)]
        public string AdminSoyad { get; set; }
        [StringLength(100)]
        public string AdminMail { get; set; }
        [StringLength(50)]
        public string AdminTelNo { get; set; }
        [StringLength(100)]
        public string AdminParola { get; set; }
    }
}
