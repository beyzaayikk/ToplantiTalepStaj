using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ToplantiTalep.Models
{
    public class Kurum
    {
        [Key]
        public int KurumID { get; set; }
        [StringLength(100)]
        public string KurumAd { get; set; }
        public ICollection<Kullanici> Kullanicis { get; set; }
        public ICollection<Talep> Taleps { get; set; }
    }
}
