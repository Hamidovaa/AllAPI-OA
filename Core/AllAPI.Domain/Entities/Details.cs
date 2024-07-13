using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllAPI.Domain.Common;

namespace AllAPI.Domain.Entities
{
    public class Details : EntityBase
    {
        public Details() 
        { 

        }
        public Details(string title, string description, int categoryId) 
        {
            CategoryId = categoryId;
            Title = title;
            Description = description;
        }
        public  string Title { get; set; }
        public  string Description { get; set; }
        public  int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
