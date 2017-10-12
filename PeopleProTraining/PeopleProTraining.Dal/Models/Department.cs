using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProTraining.Dal.Models
{
    [MetadataType(typeof(DepartmentMetaData))]
    public class Department
    {
        [Key, ForeignKey("DepartmentBuilding")]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Building DepartmentBuilding { get; set; }
    }
    public class DepartmentMetaData
    {
        [Display(Name = "Department Name")]
        public string DepartmentName;
    }
}
