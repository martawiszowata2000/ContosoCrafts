using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContosoCrafts.Models
{
    public class Product
    {
        [Key, Range(0, 100)]
        public int Key { get; set; }
        [MaxLength(40)]
        public string Id {get; set;}
        [MaxLength(20)]
        public string Maker { get; set; }
        [JsonPropertyName("img"), MaxLength(120)]
        public string Image { get; set; }
        [MaxLength(120)]
        public string Url { get; set; }
        [MaxLength(70)]
        public string Title { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
