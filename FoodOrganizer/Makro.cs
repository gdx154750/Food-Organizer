using System;
namespace FoodOrganizer
{
    public class Makro
    {
        public decimal Fat { set; get; }
        public decimal Carbs { set; get; }
        public decimal Sugar { set; get; }
        public decimal Protein { set; get; }

        public Makro(decimal fat, decimal carbs, decimal sugar, decimal protein)
        {
            Fat = fat;
            Carbs = carbs;
            Sugar = sugar;
            Protein = protein;
        }

        public string Info()
        {
            return string.Format("Tłuszcz: {0}, węglowodany: {1}, w tym cukry: {2}, białko {3}.", Fat, Carbs, Sugar, Protein);
        }
    }
}
