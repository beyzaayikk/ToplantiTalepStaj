using ToplantiTalep.DataAccess.Abstract;
using ToplantiTalep.DataAccess.Concrete.Repositories;
using ToplantiTalep.Models;

namespace ToplantiTalep.DataAccess.EntityFramework
{
    public class EfOdaD : GenericRepository<Oda>, IOdaD
    {
    }
}
