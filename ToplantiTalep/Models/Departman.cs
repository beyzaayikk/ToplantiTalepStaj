using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ToplantiTalep.Models
{
    public class Departman
    {
        [Key]
        public int DepartmanID { get; set; }
        [StringLength(150)]
        public string DepartmanAd { get; set; }
        public List<Oda> Odas { get; set; }
        public List<Talep> Taleps { get; set; }
    }
}
