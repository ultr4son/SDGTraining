using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleProTraining.Models
{
    public static class ModelUtil
    {
        /// <summary>
        /// Generate table display model
        /// </summary>
        /// <typeparam name="T">Type of the items in the table</typeparam>
        /// <param name="items">The items in the table</param>
        /// <param name="map">A function that maps items of type T to items of type TableRowDisplayModel</param>
        /// <param name="displayNameProperty">A function that accesses the proprerty from T to show the display name</param>
        /// <param name="tableId">The ID of the table to be referred to by other partial veiws.</param>
        /// <returns></returns>
        public static TableDisplayModel table<T>(IEnumerable<T> items, Func<T, TableRowDisplayModel> map, System.Linq.Expressions.Expression<Func<T, object>> displayNameProperty, string tableId)
        {
            return new TableDisplayModel
            {
                DisplayName = Core.Infrastructure.Util.GetPropertyDisplayName<T>(displayNameProperty),
                Table = items.Select(map),
                TableId = tableId
            };
        }
    }
}