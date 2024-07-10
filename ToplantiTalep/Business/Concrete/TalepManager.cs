using ToplantiTalep.Business.Abstract;
using ToplantiTalep.DataAccess.Abstract;
using ToplantiTalep.Models;

namespace ToplantiTalep.Business.Concrete
{
    public class TalepManager:ITalepService
    {
        ITalepD _talepD;

        public TalepManager(ITalepD talepD)
        {
            _talepD = talepD;
        }

        public void TalepAdd(Talep talep)
        {
            _talepD.Insert(talep);
        }

        public List<Talep> GetList()
        {
            return _talepD.List();
        }
        public void TalepDelete(Talep talep)
        {
            _talepD.Delete(talep);
        }

        public void TalepUpdate(Talep talep)
        {
            _talepD.Update(talep);
        }

        public Talep GetByID(int id)
        {
            return _talepD.Get(x => x.TalepID == id);
        }

    }
}
