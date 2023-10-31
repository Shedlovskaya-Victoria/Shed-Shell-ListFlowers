using System;
using System.Collections.Generic;
using System.Text;

namespace Shed_Shell__ListFlowers.DTO
{
    public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public CategoryFlower Category { get; set; }
    }

    public class CategoryFlower
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
