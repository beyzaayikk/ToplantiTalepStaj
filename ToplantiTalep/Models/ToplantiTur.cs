using System.ComponentModel.DataAnnotations;

namespace ToplantiTalep.Models
{
    public class ToplantiTur
    {
        [Key]
        public int ToplantiTurID { get; set; }
        [StringLength(150)]
        public string ToplantiTurAciklama { get; set; }
        public ICollection<Talep> Taleps { get; set; }
    }
}
