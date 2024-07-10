using ToplantiTalep.Models;

namespace ToplantiTalep.Business.Abstract
{
    public interface IKurumService
    {
        List<Kurum> GetList();
        void KurumAdd(Kurum kurum);
        Kurum GetByID(int id);
        void KurumDelete(Kurum kurum);
        void KurumUpdate(Kurum kurum);
    }
}
