using ToplantiTalep.DataAccess.Abstract;
using ToplantiTalep.Models;

namespace ToplantiTalep.Business.Abstract
{
    public interface IKullaniciService
    {
        List<Kullanici> GetList();
        void KullaniciAdd(Kullanici kullanici);
        Kullanici GetByID(int id);
        void KullaniciDelete(Kullanici kullanici);
        void KullaniciUpdate(Kullanici kullanici);
    }
}
