using ToplantiTalep.Models;

namespace ToplantiTalep.Business.Abstract
{
    public interface ITalepService
    {
        List<Talep> GetList();
        void TalepAdd(Talep talep);
        Talep GetByID(int id);
        void TalepDelete(Talep talep);
        void TalepUpdate(Talep talep);
    }
}
