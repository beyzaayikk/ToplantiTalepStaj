using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ToplantiTalep.Models
{
    public class Oda
    {
        [Key]
        public int OdaID { get; set; }
        [StringLength(20)]
        public string OdaKat { get; set; }
        [StringLength(20)]
        public string OdaNo { get; set; }
        public virtual Departman Departman { get; set; }
        public ICollection<Talep> Taleps { get; set; }
    }
}
