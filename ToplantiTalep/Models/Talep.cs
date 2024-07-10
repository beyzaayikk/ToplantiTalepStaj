using System.ComponentModel.DataAnnotations;

namespace ToplantiTalep.Models
{
    public class Talep
    {

        [Key]
        public int TalepID { get; set; }
        [StringLength(50)]
        public string TalepAd { get; set; }

        //public string TalepAciklama { get; set; }
        //public DateTime ToplantiBas { get; set; }
        //public DateTime ToplantiBitis { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public bool EnvanterTalep { get; set; }
        [StringLength(150)]
        public string EnvanterAciklama { get; set; }
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public int DepartmanID { get; set; }
        public Departman Departman { get; set; }
        public int KurumID { get; set; }
        public Kurum Kurum { get; set; }
        public int OdaID { get; set; }
        public Oda Oda { get; set; }
        public int ToplantiTurID { get; set; }
        public ToplantiTur ToplantiTur { get; set; }
    }
}
