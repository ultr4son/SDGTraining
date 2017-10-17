using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopleProTraining.Dal.Models
{
    [MetadataType(typeof(DepartmentMetaData))]
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Building> DepartmentBuilding { get; set; }
    }
    public class DepartmentMetaData
    {
        public int DepartmentId;

        [Display(Name = "Department Name")]
        public string DepartmentName;
    }
}
