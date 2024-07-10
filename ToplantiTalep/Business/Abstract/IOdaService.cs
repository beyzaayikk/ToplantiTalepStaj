using ToplantiTalep.Models;

namespace ToplantiTalep.Business.Abstract
{
    public interface IOdaService
    {
        List<Oda> GetList();
        void OdaAdd(Oda oda);
        Oda GetByID(int id);
        void OdaDelete(Oda oda);
        void OdaUpdate(Oda oda);
    }
}
