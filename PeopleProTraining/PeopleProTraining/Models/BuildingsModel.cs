using PeopleProTraining.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleProTraining.Models
{
    public class BuildingsModel
    {
     
        public IEnumerable<Building> buildings { get; set; }
        public ICollection<TableEditModel> editors { get; set; }
    }
}