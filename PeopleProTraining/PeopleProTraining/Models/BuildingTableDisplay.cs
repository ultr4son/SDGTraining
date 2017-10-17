using PeopleProTraining.Dal.Models;
using System.Collections.Generic;

namespace PeopleProTraining.Models
{
    public class BuildingTableDisplayModel 
    {
        /// <summary>
        /// Generate TableDisplayModel
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public static TableDisplayModel make(IEnumerable<Building> items)
        {
            return ModelUtil.table(items,
            b => new TableRowDisplayModel { DisplayValue = b.BuildingName, EditId = b.BuildingId },
            b => b.BuildingName,
            "BuildingsTable");
        }
    }
}