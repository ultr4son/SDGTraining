using System.ComponentModel.DataAnnotations;

namespace PeopleProTraining.Dal.Models
{
    [MetadataType(typeof(EmployeeMetaData))]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public virtual Department Department { get; set; }
    }
    public class EmployeeMetaData
    {
        public int EmployeeId;

        [Required]
        [Display(Name = "First Name")]
        public string FirstName;

    }


}
