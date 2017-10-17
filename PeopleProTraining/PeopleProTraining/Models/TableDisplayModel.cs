using System.Collections.Generic;

namespace PeopleProTraining.Models
{
    public class TableDisplayModel
    {
        public IEnumerable<TableRowDisplayModel> Table { get; set; }
        public string DisplayName { get; set; }
        public string TableId { get; set; }


    }
}