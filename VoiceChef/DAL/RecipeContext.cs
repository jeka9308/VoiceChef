﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using VoiceChef.Models;

namespace VoiceChef.DAL
{
    public class RecipeContext : DbContext
    {
        public RecipeContext()
            : base("RecipeContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}