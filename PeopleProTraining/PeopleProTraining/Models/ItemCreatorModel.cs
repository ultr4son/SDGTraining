using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace PeopleProTraining.Models
{
    public class ItemCreatorModel
    {
        public string Label { get; set; }
        public string EditItem { get; set; }
        public string TableId { get; set; }
        public string Controller { get; set; }

        public Expression<Func<object, string>> For { get; set; }
        
    }
}