using Microsoft.EntityFrameworkCore;
using SchoolMaMonolitica.Web.Data.Entities;

namespace SchoolMaMonolitica.Web.Data.Context
{
    public class SchoolContext : DbContext
    {

        #region"Constructor"
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        #endregion

        #region"Db Sets"
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        #endregion
    }
}
