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
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
