using ToplantiTalep.Business.Abstract;
using ToplantiTalep.DataAccess.Abstract;
using ToplantiTalep.Models;

namespace ToplantiTalep.Business.Concrete
{
    public class KullaniciManager:IKullaniciService
    {
        IKullaniciD _kullaniciD;

        public KullaniciManager(IKullaniciD kullaniciD)
        {
            _kullaniciD = kullaniciD;
        }

        public void KullaniciAdd(Kullanici kullanici)
        {
            _kullaniciD.Insert(kullanici);
        }

        public List<Kullanici> GetList()
        {
            return _kullaniciD.List();
        }
        public void KullaniciDelete(Kullanici kullanici)
        {
            _kullaniciD.Delete(kullanici);
        }

        public void KullaniciUpdate(Kullanici kullanici)
        {
            _kullaniciD.Update(kullanici);
        }

        public Kullanici GetByID(int id)
        {
            return _kullaniciD.Get(x => x.KullaniciID == id);
        }
    }
}
