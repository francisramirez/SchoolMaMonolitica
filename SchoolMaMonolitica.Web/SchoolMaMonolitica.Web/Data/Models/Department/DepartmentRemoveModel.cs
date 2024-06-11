namespace SchoolMaMonolitica.Web.Data.Models.Department
{
    public class DepartmentRemoveModel
    {
        public int DepartmentId { get; set; }
        public int UserDelete { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool Deleted { get; set; }

    }
}
