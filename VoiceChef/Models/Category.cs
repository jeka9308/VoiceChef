using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoiceChef.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public string EngName { get; set; }

    }
}