using System;
using System.Collections.Generic;

namespace FoodOrganizer
{
    public class MeatAndDairy : Makro
    {
        public string Nazwa { set; get; }
        public decimal Masa { set; get; }
        public string DataWaznosci { set; get; }

        public MeatAndDairy(string nazwa, decimal masa, string datawaznosci, decimal fat, decimal carbs, decimal sugar, decimal protein) : base(fat, carbs, sugar, protein)
        {
            this.Nazwa = nazwa;
            this.Masa = masa;
            this.DataWaznosci = datawaznosci;
        }

        public new string Info()
        {
            return string.Format("{0}, {1}[g], data ważności: {2}. {3}", Nazwa, Masa, DataWaznosci, base.Info());
        }
    }
}
