using SchoolMaMonolitica.Web.Data.Context;
using SchoolMaMonolitica.Web.Data.Entities;
using SchoolMaMonolitica.Web.Data.Exceptions;
using SchoolMaMonolitica.Web.Data.Interfaces;
using SchoolMaMonolitica.Web.Data.Models;
using SchoolMaMonolitica.Web.Data.Extentions;
namespace SchoolMaMonolitica.Web.Data.DbObjects
{
    public class DepartmentDb : IDepartmentDb
    {
        private readonly SchoolContext context;

        public DepartmentDb(SchoolContext context)
        {
            this.context = context;
        }
        public DepartmentModel GetDepartment(int idDepartment)
        {
            var department = this.context.Departments.Find(idDepartment)
                                                      .ConvertDeptoEntitytoDepartmentModel();




            //DepartmentModel departmentModel = new DepartmentModel()
            //{
            //    Administrator = department.Administrator,
            //    Budget = department.Budget,
            //    CreationDate = department.CreationDate,
            //    Name = department.Name,
            //    DepartmentId = department.DepartmentId,
            //    StartDate = department.StartDate
            //};

            return departmentModel;
        }

        public List<DepartmentModel> GetDepartments()
        {
            return this.context.Departments.Select(department => new DepartmentModel()
            {
                Administrator = department.Administrator,
                Budget = department.Budget,
                CreationDate = department.CreationDate,
                Name = department.Name,
                DepartmentId = department.DepartmentId,
                StartDate = department.StartDate
            }).ToList();
        }

        public void RemoveDepartment(DepartmentRemoveModel departmentRemove)
        {
            Department departmentToDelete = this.context.Departments.Find(departmentRemove.DepartmentId);

            if (departmentToDelete is null)
            {
                throw new DepartmentDbException("El departamento no se encuentra registrado.");
            }


            departmentToDelete.Deleted = departmentRemove.Deleted;
            departmentToDelete.DeletedDate = departmentRemove.DeleteDate;
            departmentToDelete.UserDeleted = departmentRemove.UserDelete;

            this.context.Departments.Update(departmentToDelete);

            this.context.SaveChanges();


        }

        public void SaveDepartment(DepartmentSaveModel departmentSave)
        {

            Department department = new Department()
            {
                Administrator = departmentSave.Administrator,
                Budget = departmentSave.Budget,
                CreationDate = departmentSave.CreationDate,
                Name = departmentSave.Name,
                StartDate = departmentSave.StartDate,
                CreationUser = departmentSave.CreationUser
            };

            this.context.Departments.Add(department);
            this.context.SaveChanges();
        }

        public void UpdateDepartment(DepartmentUpdateModel updateModel)
        {
            Department departmentToUpdate = this.context.Departments.Find(updateModel.DepartmentId);


            if (departmentToUpdate is null)
            {
                throw new DepartmentDbException("El departamento no se encuentra registrado.");
            }

            departmentToUpdate.ModifyDate = updateModel.ModifyDate;
            departmentToUpdate.UserMod = updateModel.UserMod;
            departmentToUpdate.Name = updateModel.Name;
            departmentToUpdate.StartDate = updateModel.StartDate;
            departmentToUpdate.Budget = updateModel.Budget;
            departmentToUpdate.Administrator = updateModel.Administrator;

            this.context.Departments.Update(departmentToUpdate);
            this.context.SaveChanges();
        }
    }
}
