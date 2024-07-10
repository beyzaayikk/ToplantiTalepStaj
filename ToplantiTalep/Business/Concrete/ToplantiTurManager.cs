using ToplantiTalep.Business.Abstract;
using ToplantiTalep.DataAccess.Abstract;
using ToplantiTalep.Models;

namespace ToplantiTalep.Business.Concrete
{
    public class ToplantiTurManager:IToplantiTurService
    {
        IToplantiTurD _toplantiTurD;
        public ToplantiTurManager(IToplantiTurD toplantiTurD)
        {
            _toplantiTurD = toplantiTurD;
        }

        public void ToplantiTurAdd(ToplantiTur toplantiTur)
        {
            _toplantiTurD.Insert(toplantiTur);
        }

        public List<ToplantiTur> GetList()
        {
            return _toplantiTurD.List();
        }
        public void ToplantiTurDelete(ToplantiTur toplantiTur)
        {
            _toplantiTurD.Delete(toplantiTur);
        }

        public void ToplantiTurUpdate(ToplantiTur toplantiTur)
        {
            _toplantiTurD.Update(toplantiTur);
        }

        public ToplantiTur GetByID(int id)
        {
            return _toplantiTurD.Get(x => x.ToplantiTurID == id);
        }
    }
}
