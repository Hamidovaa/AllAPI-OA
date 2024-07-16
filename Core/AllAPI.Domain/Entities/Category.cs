using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllAPI.Domain.Common;

namespace AllAPI.Domain.Entities
{
    public class Category : EntityBase, IEntityBase
    {
        public Category()
        {

        }
        public Category(int parentId, string name, int priority)
        {
            ParentId = parentId;
            Name = name;
            Priority = priority;
        }

        public  int ParentId { get; set; }
        public  string Name { get; set; }
        public  int Priority { get; set; }
        public ICollection<Details> Details { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
