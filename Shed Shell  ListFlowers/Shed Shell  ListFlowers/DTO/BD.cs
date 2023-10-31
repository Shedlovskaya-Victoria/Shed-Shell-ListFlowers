using Shed_Shell__ListFlowers.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Shed_Shell__ListFlowers
{
    public class BD
    {
        private static ObservableCollection<Flower> Flowers;
        private static ObservableCollection<CategoryFlower> Categories;

        public static ObservableCollection<Flower> GetInstance()
        {
            if (Flowers == null)
                Flowers = new ObservableCollection<Flower>();
            return Flowers;
        }
        public static Flower GetFlowerByID(int Id)
        {
           return Flowers.FirstOrDefault(x => x.Id == Id);
        }
        public static ObservableCollection<CategoryFlower> GetCategories()
        {
            if (Categories == null)
                Categories = new ObservableCollection<CategoryFlower>();
            return Categories;
        }
        public void AddCategory(CategoryFlower category)
        {
            if (category == null)
                return;

            Categories.Add(new CategoryFlower
            {
                Id = Incrementation(),
                Title = category.Title,
            });
        }
        public void DeleteCategory(CategoryFlower category)
        {
            if (category == null)
                return;

            Categories.Remove(category);
        }
        public void EditCategory(CategoryFlower newCategory)
        {
            if (newCategory == null)
                return;

            var a = Flowers.FirstOrDefault(s => s.Id == newCategory.Id);
            a.Name = newCategory.Title;
           /// int index = Categories.IndexOf(newCategory);
            //Categories[index] = newCategory;

        }
        public void AddFlower(Flower flower)
        {
            if (flower == null)
            {
                return;
            }

            Flowers.Add(new Flower
            {
                Id = Incrementation(),
                Name = flower.Name,
                Cost = flower.Cost,
                Category = flower.Category,
            });
        }
        public void EditFlower(Flower newFlower)
        {
            if ( newFlower == null)
                return;
            //  int index = Flowers.IndexOf(oldFlower);
            // Flowers[index] = newFlower;

            var a = Flowers.FirstOrDefault(s => s.Id == newFlower.Id);
            a.Cost = newFlower.Cost;
            a.Name = newFlower.Name;
            a.Category = newFlower.Category;
        }
        public void DeleteFlower(Flower flower)
        {
            if (flower == null)
                return;

            Flowers.Remove(flower);
        }
        static int id = 0;
        int Incrementation() => ++id;
        static CategoryFlower Ctg;
        public static void GetCtg(CategoryFlower selectedCategory)
        {
            Ctg = selectedCategory;
        }
        static object Obj;
        public static void Set(object obg)
        {
            Obj = obg;
        }
        public static object Get()
        {
           return Obj;
        }
    }
}
