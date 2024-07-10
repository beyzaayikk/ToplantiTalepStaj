using ToplantiTalep.Models;

namespace ToplantiTalep.Business.Abstract
{
    public interface IToplantiTurService
    {
        List<ToplantiTur> GetList();
        void ToplantiTurAdd(ToplantiTur toplantiTur);
        ToplantiTur GetByID(int id);
        void ToplantiTurDelete(ToplantiTur toplantiTur);
        void ToplantiTurUpdate(ToplantiTur toplantiTur);
    }
}
