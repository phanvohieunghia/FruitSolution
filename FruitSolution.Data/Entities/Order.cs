using System;
using System.Collections.Generic;
using System.Text;

namespace FruitSolution.Data.Entities
{
    public class Order
    {
        public string Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }

    }
}
