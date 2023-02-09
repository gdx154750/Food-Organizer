using System;
namespace FoodOrganizer
{
    public class VegetablesAndFruits : Makro
    {
        public string Nazwa { set; get; }
        public int Ilosc { set; get; }

        public VegetablesAndFruits(string nazwa, int ilosc, decimal fat, decimal carbs, decimal sugar, decimal protein) : base(fat, carbs, sugar, protein)
        {
            this.Nazwa = nazwa;
            this.Ilosc = ilosc;
        }
        public new string Info()
        {
            return string.Format("{0}, w ilości: {1}. {2}", Nazwa, Ilosc, base.Info());
        }
    }
}
