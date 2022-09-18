namespace FitYourSelf.DataAccess.Migrations
{
    using FitYorSelf.Entities.Concrete;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FitYourSelf.DataAccess.Context.FitYourSelfContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FitYourSelf.DataAccess.Context.FitYourSelfContext context)
        {
            FoodCategory sutUrunleri = new FoodCategory() { CategoryName = "Süt ve Süt Ürünleri" };
            FoodCategory etUrunleriVeYumurta = new FoodCategory() { CategoryName = "Et Ürünleri ve Yumurta" };
            FoodCategory bakliyat = new FoodCategory() { CategoryName = "Bakliyat" };
            FoodCategory sebzeler = new FoodCategory() { CategoryName = "sebzeler" };
            FoodCategory meyveler = new FoodCategory() { CategoryName = "Meyveler" };
            FoodCategory tatlilar = new FoodCategory() { CategoryName = "Tatlılar" };
            FoodCategory atistirmaliklar = new FoodCategory() { CategoryName = "Atıştırmalıklar" };
            FoodCategory icecekler = new FoodCategory() { CategoryName = "İçecekler" };

            context.FoodCategories.Add(sutUrunleri);
            context.FoodCategories.Add(etUrunleriVeYumurta);
            context.FoodCategories.Add(bakliyat);
            context.FoodCategories.Add(sebzeler);
            context.FoodCategories.Add(meyveler);
            context.FoodCategories.Add(tatlilar);
            context.FoodCategories.Add(atistirmaliklar);
            context.FoodCategories.Add(icecekler);

            Foods icliPilav = new Foods()
            {
                FoodName = "İçli Pilav",
                FoodCategory = bakliyat,
                Calorie = 189,
                Fat = 2.5,
                Carbonhidrate = 25.99,
                Protein = 2.6,
                Description = "1 porsiyon 100 gramdır."
            };
            context.Foods.Add(icliPilav);          

        }
    }
}
