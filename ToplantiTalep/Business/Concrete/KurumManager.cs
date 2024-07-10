using ToplantiTalep.Business.Abstract;
using ToplantiTalep.DataAccess.Abstract;
using ToplantiTalep.Models;

namespace ToplantiTalep.Business.Concrete
{
    public class KurumManager:IKurumService
    {
        IKurumD _kurumD;

        public KurumManager(IKurumD kurumD)
        {
            _kurumD = kurumD;
        }

        public void KurumAdd(Kurum kurum)
        {
            _kurumD.Insert(kurum);
        }

        public List<Kurum> GetList()
        {
            return _kurumD.List();
        }
        public void KurumDelete(Kurum kurum)
        {
            _kurumD.Delete(kurum);
        }

        public void KurumUpdate(Kurum kurum)
        {
            _kurumD.Update(kurum);
        }

        public Kurum GetByID(int id)
        {
            return _kurumD.Get(x => x.KurumID == id);
        }
    }
}
