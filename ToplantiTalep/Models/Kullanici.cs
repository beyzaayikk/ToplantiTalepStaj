using System.ComponentModel.DataAnnotations;

namespace ToplantiTalep.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }
        [StringLength(50)]
        public string KullaniciAd { get; set; }
        [StringLength(50)]
        public string KullaniciSoyad { get; set; }
        [StringLength(100)]
        public string KullaniciMail { get; set; }
        [StringLength(50)]
        public string KullaniciTelNo { get; set; }
        [StringLength(100)]
        public string KullaniciUnvan { get; set; }
        [StringLength(100)]
        public string KullaniciParola { get; set; }
        public int KurumID { get; set; }
        public Kurum Kurum { get; set; }
    }
}
