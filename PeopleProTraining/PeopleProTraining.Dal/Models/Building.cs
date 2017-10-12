using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
