using ToplantiTalep.Business.Abstract;
using ToplantiTalep.DataAccess.Abstract;
using ToplantiTalep.Models;

namespace ToplantiTalep.Business.Concrete
{
    public class OdaManager:IOdaService
    {
        IOdaD _odaD;

        public OdaManager(IOdaD odaD)
        {
            _odaD = odaD;
        }

        public void OdaAdd(Oda oda)
        {
            _odaD.Insert(oda);
        }

        public List<Oda> GetList()
        {
            return _odaD.List();
        }
        public void OdaDelete(Oda oda)
        {
            _odaD.Delete(oda);
        }

        public void OdaUpdate(Oda oda)
        {
            _odaD.Update(oda);
        }

        public Oda GetByID(int id)
        {
            return _odaD.Get(x => x.OdaID == id);
        }
    }
}
