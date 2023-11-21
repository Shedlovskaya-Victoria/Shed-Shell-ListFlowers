using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shed_Shell__ListFlowers.DTO
{
    public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int CategoryFlowerId { get; set; }
       
       public CategoryFlower Category { get {

                if(Category == null)
                {
                    return App.dboContext.Categories.FirstOrDefault(c => c.Id == CategoryFlowerId);
                }
                else if (CategoryFlowerId == 0 | CategoryFlowerId == null)
                {
                    return new CategoryFlower() { Title = "Нет категории" };
                }
                return Category;
            }
        }
    }
}
