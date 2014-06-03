using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoiceChef.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EngName { get; set; }
        public int Pieces { get; set; } // кол-во штук
        public string NamePieces { get; set; }
        public string EngNamePieces { get; set; }
        public double Teaspoon { get; set; } //чайная ложка
        public double Tablespoon { get; set; } //столовая ложка
        public Category Category { get; set; } // отдел
    }
}