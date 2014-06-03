using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VoiceChef.Models;

namespace VoiceChef.DAL
{
    public class RecipeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RecipeContext>
    {
        protected override void Seed(RecipeContext context)
        {
            var categories = new List<Category>()
                {
                    new Category(){
                        Name ="Молочный отдел", EngName = "Молочный отдел"
                    },
                          new Category(){
                        Name ="Мясной отдел", EngName = "Мясной отдел"
                    },
                          new Category(){
                        Name ="Рыбный отдел", EngName = "«Рыбный отдел»"
                    },
                          new Category(){
                        Name ="Бакалея", EngName = "Бакалея"
                    }
                };

            context.Categories.AddRange(categories);
            context.SaveChanges();
        }
    }
}