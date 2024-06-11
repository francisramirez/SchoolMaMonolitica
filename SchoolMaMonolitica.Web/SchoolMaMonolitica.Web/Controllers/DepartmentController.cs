using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMaMonolitica.Web.BL.Services;
using SchoolMaMonolitica.Web.Data.Context;
using SchoolMaMonolitica.Web.Data.Interfaces;
using SchoolMaMonolitica.Web.Data.Models.Department;

namespace SchoolMaMonolitica.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentDb departmentDb;

        public DepartmentController(IDepartmentDb departmentDb)
        {
            this.departmentDb = departmentDb;
        }
        // GET: DepartmentController
        public ActionResult Index()
        {
            var deparments = this.departmentDb.GetDepartments();
            return View(deparments);
        }

        // GET: DepartmentController/Details/5
        public ActionResult Details(int id)
        {

            var department = this.departmentDb.GetDepartment(id);

            return View(department);
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DepartmentSaveModel departmentSave)
        {
            try
            {
                departmentSave.ChangeDate = DateTime.Now;
                departmentSave.ChangeUser = 1;
                this.departmentDb.SaveDepartment(departmentSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int id)
        {
            var department = this.departmentDb.GetDepartment(id);

            return View(department);
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DepartmentUpdateModel departmentUpdate)
        {
            try
            {
                departmentUpdate.ChangeDate = DateTime.Now;
                departmentUpdate.ChangeUser = 1;

                this.departmentDb.UpdateDepartment(departmentUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
    }
}
