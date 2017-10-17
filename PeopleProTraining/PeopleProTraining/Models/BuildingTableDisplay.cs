using PeopleProTraining.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleProTraining.Models
{
    public class BuildingTableDisplay : TableDisplayModel
    {
        public BuildingTableDisplay(IEnumerable<Building> buildings, string displayName)
        {
            Table = buildings.Select(building => new TableRowDisplayModel { DisplayValue = building.BuildingName, EditId = building.BuildingId });
            DisplayName = displayName;
            TableId = "BuildingsTable";
        }
    }
}