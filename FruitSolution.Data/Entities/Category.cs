using FruitSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FruitSolution.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public int IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }
        public ProductInCategory ProductInCategories { get; set; }
    }
}
