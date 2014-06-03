using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoiceChef.Models
{
    public class CookingStep
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public string EngDescription { get; set; }
        public string RusDescription { get; set; }
        public string RusDescriptionTimer { get; set; }
        public string EngDescriptionTimer { get; set; }
        public string ImageUrl { get; set; }
        public string AudioUrl { get; set; }
        public long AudioLength { get; set; } // в милисекундах
    }
}