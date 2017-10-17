using System.ComponentModel.DataAnnotations;

namespace PeopleProTraining.Dal.Models
{
    public class Building
    {
        [Key]
        public int BuildingId { get;  set;}
        public string BuildingName { get; set; }
        public virtual Department BuildingDepartment { get; set; }
    }
}
