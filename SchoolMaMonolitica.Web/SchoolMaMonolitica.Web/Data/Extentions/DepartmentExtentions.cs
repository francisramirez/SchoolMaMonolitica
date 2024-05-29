using SchoolMaMonolitica.Web.Data.DbObjects;
using SchoolMaMonolitica.Web.Data.Entities;
using SchoolMaMonolitica.Web.Data.Models;

namespace SchoolMaMonolitica.Web.Data.Extentions
{
    public static class DepartmentExtentions
    {
        /// <summary>
        /// Metodo para convertir de la entidad departamento a department model 
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public static DepartmentModel ConvertDeptoEntitytoDepartmentModel(this Department department) 
        {
            DepartmentModel departmentModel = new DepartmentModel()
            {
                Administrator = department.Administrator,
                Budget = department.Budget,
                CreationDate = department.CreationDate,
                Name = department.Name,
                DepartmentId = department.DepartmentId,
                StartDate = department.StartDate
            };

            return departmentModel;
        }
    }
}
