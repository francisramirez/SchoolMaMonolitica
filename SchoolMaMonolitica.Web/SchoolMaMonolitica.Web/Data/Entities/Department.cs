﻿using SchoolMaMonolitica.Web.Data.Core;

namespace SchoolMaMonolitica.Web.Data.Entities
{
    public class Department : BaseEntity
    {
        public int DepartmentId { get; set; }
        public string? Name { get; set; }

        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }

        public int? Administrator { get; set; }

    }
}
