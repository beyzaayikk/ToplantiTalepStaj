using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using ToplantiTalep.Business.Concrete;
using ToplantiTalep.Business.ValidationRules;
using ToplantiTalep.DataAccess.EntityFramework;
using ToplantiTalep.Models;

namespace ToplantiTalep.Controllers
{
    public class DepartmanController : Controller
    {
        DepartmanManager dm = new DepartmanManager(new EfDepartmanD());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetDepartmanList()
        {
            var departmanvalues = dm.GetList();
            return View(departmanvalues);
        }
        [HttpGet]
        public ActionResult AddDepartman()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDepartman(Departman dep)
        {
            //dm.DepartmanAddBL(dep);
            DepartmanValidator departmanValidator = new DepartmanValidator();
            ValidationResult results = departmanValidator.Validate(dep);
            if (results.IsValid)
            {
                dm.DepartmanAdd(dep);
                return RedirectToAction("GetDepartmanList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
