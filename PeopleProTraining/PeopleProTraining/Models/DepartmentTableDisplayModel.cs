using PeopleProTraining.Dal.Models;
using System.Collections.Generic;

namespace PeopleProTraining.Models
{
    public class DepartmentTableDisplayModel
    {
        /// <summary>
        /// Create a TableDisplayModel based on items.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public static TableDisplayModel make(IEnumerable<Department> items)
        {
            return ModelUtil.table(
                items,
                d => new TableRowDisplayModel { DisplayValue = d.DepartmentName, EditId = d.DepartmentId },
                d => d.DepartmentName,
                "DepartmentsTable"
                );
        }
    }
}