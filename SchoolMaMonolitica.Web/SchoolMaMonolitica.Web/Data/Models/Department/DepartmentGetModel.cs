namespace SchoolMaMonolitica.Web.Data.Models.Department
{
    public class DepartmentGetModel
    {
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
