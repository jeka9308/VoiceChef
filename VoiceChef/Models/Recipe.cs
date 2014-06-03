using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoiceChef.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EngName { get; set; }
        public int CookingTime { get; set; }
        public string MainImageUrl { get; set; }
        public int PortionMinWeight { get; set; }
        public int Weight { get; set; }
        public string AudioStartUrl { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public virtual ICollection<CookingStep> CookingSteps { get; set; }
    }
}