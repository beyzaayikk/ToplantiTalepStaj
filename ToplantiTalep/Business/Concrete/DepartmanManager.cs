using ToplantiTalep.Business.Abstract;
using ToplantiTalep.DataAccess.Abstract;
using ToplantiTalep.Models;

namespace ToplantiTalep.Business.Concrete
{
    public class DepartmanManager:IDepartmanService
    {
        IDepartmanD _departmanD;

        public DepartmanManager(IDepartmanD departmanD)
        {
            _departmanD = departmanD;
        }

        public void DepartmanAdd(Departman departman)
        {
            _departmanD.Insert(departman);
        }

        public List<Departman> GetList()
        {
            return _departmanD.List();
        }
        public void DepartmanDelete(Departman departman)
        {
            _departmanD.Delete(departman);
        }

        public void DepartmanUpdate(Departman departman)
        {
            _departmanD.Update(departman);
        }

        public Departman GetByID(int id)
        {
            return _departmanD.Get(x => x.DepartmanID == id);
        }
    }
}
