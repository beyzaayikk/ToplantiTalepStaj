using ToplantiTalep.Models;

namespace ToplantiTalep.Business.Abstract
{
    public interface IDepartmanService
    {
        List<Departman> GetList();
        void DepartmanAdd(Departman departman);
        Departman GetByID(int id);
        void DepartmanDelete(Departman departman);
        void DepartmanUpdate(Departman departman);
    }
}
