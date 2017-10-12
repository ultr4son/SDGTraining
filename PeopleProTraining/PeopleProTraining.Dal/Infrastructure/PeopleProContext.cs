using PeopleProTraining.Dal.Interfaces;
using PeopleProTraining.Dal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProTraining.Dal.Infrastructure
{
    public class PeopleProContext : DbContext, IPeopleProContext
    {
        public PeopleProContext() : base("name=PeopleProTrainingDB") {

        }
        public IDbSet<Employee> EmployeesList { get; set; }
        public IDbSet<Department> DepartmentsList { get; set; }
        public IDbSet<Building> BuildingsList { get; set; }

    }
}
