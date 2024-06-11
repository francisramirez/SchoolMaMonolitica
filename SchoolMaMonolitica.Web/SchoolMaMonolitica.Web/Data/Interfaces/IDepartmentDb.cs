using SchoolMaMonolitica.Web.Data.Entities;
using SchoolMaMonolitica.Web.Data.Models.Department;

namespace SchoolMaMonolitica.Web.Data.Interfaces
{
    public interface IDepartmentDb
    {
        void SaveDepartment(DepartmentSaveModel department);
        void UpdateDepartment(DepartmentUpdateModel updateModel);
        void RemoveDepartment(DepartmentRemoveModel departmentRemove);
        List<DepartmentGetModel> GetDepartments();
        DepartmentGetModel GetDepartment(int idDepartment);

    }
}
